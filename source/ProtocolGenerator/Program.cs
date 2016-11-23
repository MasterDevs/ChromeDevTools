using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    internal class Program
    {
        private const string CommandAttribute = "Command";
        private const string CommandResponseAttribute = "CommandResponse";
        private const string EventAttribute = "Event";
        private const string ProtocolNameClass = "ProtocolName";
        private const string RootNamespace = "MasterDevs.ChromeDevTools.Protocol";
        private const string CommandSubclass = "Command";
        private const string CommandResponseSubclass = CommandSubclass + "Response";
        private const string EventSubclass = "Event";
        private static Dictionary<string, Dictionary<string, string>> _DomainPropertyTypes = new Dictionary<string, Dictionary<string, string>>();
        private static Dictionary<string, List<string>> _DomainCommands = new Dictionary<string, List<string>>();
        private static Dictionary<string, List<string>> _DomainEvents = new Dictionary<string, List<string>>();
        private static Dictionary<string, string> _SimpleTypes = new Dictionary<string, string>();

        private static void Main(string[] args)
        {
            // At this point in time, we only process the most recent Chrome
            // and iOS (Safari) protocols.
            Dictionary<string, string> protocolFiles = new Dictionary<string, string>();
            //protocolFiles.Add("Chrome-0.1", "Inspector-0.1.json");
            //protocolFiles.Add("Chrome-1.0", "Inspector-1.0.json");
            //protocolFiles.Add("Chrome", "Inspector-1.1.json");
            protocolFiles.Add("Chrome", "protocol.json");
            //protocolFiles.Add("iOS-7.0", "Inspector-iOS-7.0.json");
            //protocolFiles.Add("iOS-8.0", "Inspector-iOS-8.0.json");
            //protocolFiles.Add("iOS-9.0", "Inspector-iOS-9.0.json");
            protocolFiles.Add("iOS", "Inspector-iOS-9.3.json");

            Collection<Protocol> protocols = new Collection<Protocol>();

            // "Explicit mappings" allow us to map one type reference to another. This is a
            // rather hard-coded way of doing things, and is only used when the same type
            // has different names accross different versions of the dev tools - e.g. the RGBA
            // type which is named RGBAColor for Safari.
            Dictionary<string, string> explicitMappings = new Dictionary<string, string>();

            foreach (var protocolFile in protocolFiles)
            {
                Protocol p = ProtocolProcessor.LoadProtocol(protocolFile.Value, protocolFile.Key);
                ProtocolProcessor.ResolveTypeReferences(p, explicitMappings);
                protocols.Add(p);
            }

            var outputFolder = "OutputProtocol";
            if (args.Length > 0)
            {
                outputFolder = args[0];
            }
            if (Directory.Exists(outputFolder))
            {
                Directory.Delete(outputFolder, true);
                Directory.CreateDirectory(outputFolder);
            }

            foreach (var protocol in protocols)
            {
                var outputDirectoryInfo = Directory.CreateDirectory(Path.Combine(outputFolder, protocol.Alias));
                WriteProtocolClasses(protocol, outputDirectoryInfo);
            }
        }

        private static void WriteProtocolClasses(Protocol protocolObject, DirectoryInfo directory)
        {
            _DomainPropertyTypes.Clear();
            _DomainCommands.Clear();
            _DomainEvents.Clear();
            _SimpleTypes.Clear();

            var domains = protocolObject.Domains;
            foreach (var domain in domains)
            {
                AddPropertyTypes(domain.Name, domain.Types);
            }
            foreach (var domain in domains)
            {
                var domainName = domain.Name;
                var types = domain.Types;
                var commands = domain.Commands;
                var events = domain.Events;
                _DomainCommands[domainName] = new List<string>();
                _DomainEvents[domainName] = new List<string>();
                WriteProtocolClasses(directory, protocolObject.Alias, domainName, types, commands, events);
            }
            WriteMethodConstants(directory, protocolObject.Alias);
        }

        private static void AddPropertyTypes(string domain, IEnumerable<Type> types)
        {
            var domainDictionary = new Dictionary<string, string>();
            _DomainPropertyTypes[domain] = domainDictionary;
            foreach (var type in types)
            {
                var propertyType = type.Kind;
                var typeName = type.Name;
                if (type.IsEnum()
                    || type.IsClass()
                    || type.IsObject())
                {
                    propertyType = domain + "." + typeName;
                }
                if ("Network" == domain && "Headers" == typeName)
                {
                    domainDictionary[typeName] = "Dictionary<string, string>";
                }
                else
                {
                    domainDictionary[typeName] = GeneratePropertyType(propertyType);
                }
                if ("array" == propertyType)
                {
                    AddArrayPropertyType(domainDictionary, domain, type);
                }
            }
        }

        private static void AddArrayPropertyType(Dictionary<string, string> domainDictionary, string domain, Type type)
        {
            var items = type.Items;
            if (null == items) return;
            var itemsType = GeneratePropertyType(items.Kind);
            if (String.IsNullOrEmpty(itemsType))
            {
                itemsType = items.TypeReference;
            }
            domainDictionary[type.Name] = domain + "." + itemsType + "[]";
        }

        private static void WriteProtocolClasses(DirectoryInfo directory, string ns, string domainName, IEnumerable<Type> types, IEnumerable<Command> commands, IEnumerable<Event> events)
        {
            var domainDirectoryInfo = CreateDomainFolder(directory, domainName);
            foreach (var type in types)
            {
                WriteType(domainDirectoryInfo, ns, type);
            }
            foreach (var command in commands)
            {
                WriteCommand(domainDirectoryInfo, ns, command);
            }
            foreach (var evnt in events)
            {
                WriteEvent(domainDirectoryInfo, ns, evnt);
            }
        }

        private static void WriteMethodConstants(DirectoryInfo domainDirectoryInfo, string ns)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("using MasterDevs.ChromeDevTools;");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}", RootNamespace, ns);
            sb.AppendLine();
            sb.AppendLine("{");
            sb.AppendFormat("\tpublic static class {0}", ProtocolNameClass);
            sb.AppendLine();
            sb.AppendLine("\t{");

            var domains = _DomainCommands.Keys.Union(_DomainEvents.Keys).Distinct();
            foreach (var domain in domains)
            {
                sb.AppendFormat("\t\tpublic static class {0}", domain);
                sb.AppendLine();
                sb.AppendLine("\t\t{");
                List<string> commands;
                if (_DomainCommands.TryGetValue(domain, out commands))
                {
                    foreach (var commandName in commands)
                    {
                        sb.AppendFormat("\t\t\tpublic const string {0} = \"{1}.{2}\";", ToCamelCase(commandName), domain, commandName);
                        sb.AppendLine();
                    }
                }
                List<string> events;
                if (_DomainEvents.TryGetValue(domain, out events))
                {
                    foreach (var eventName in events)
                    {
                        sb.AppendFormat("\t\t\tpublic const string {0} = \"{1}.{2}\";", ToCamelCase(eventName), domain, eventName);
                        sb.AppendLine();
                    }
                }
                sb.AppendLine("\t\t}");
                sb.AppendLine();
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, ProtocolNameClass, sb.ToString());
        }

        private static void WriteEvent(DirectoryInfo domainDirectoryInfo, string ns, Event evnt)
        {
            if (null == evnt) return;
            var eventName = evnt.Name;
            var description = evnt.Description;
            var parameters = evnt.Parameters;
            // ignoreing "handlers" ... i'm not sure what they are for yet
            _DomainEvents[domainDirectoryInfo.Name].Add(eventName);
            WriteEvent(domainDirectoryInfo, ns, eventName, description, parameters, evnt.SupportedBy);
        }

        private static void WriteEvent(DirectoryInfo domainDirectoryInfo, string ns, string eventName, string description, IEnumerable<Property> parameters, IEnumerable<string> supportedBy)
        {
            var className = ToCamelCase(eventName) + EventSubclass;
            var sb = new StringBuilder();
            sb.AppendFormat("using MasterDevs.ChromeDevTools;");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}.{2}", RootNamespace, ns, domainDirectoryInfo.Name);
            sb.AppendLine();
            sb.AppendLine("{");
            if (!String.IsNullOrEmpty(description))
            {
                sb.AppendLine("\t/// <summary>");
                sb.AppendFormat("\t/// {0}", description);
                sb.AppendLine();
                sb.AppendLine("\t/// </summary>");
            }
            sb.AppendFormat("\t[{0}({1}.{2}.{3})]", EventAttribute, ProtocolNameClass, domainDirectoryInfo.Name, ToCamelCase(eventName));
            sb.AppendLine();
            WriteSupportedBy(sb, supportedBy);
            sb.AppendFormat("\tpublic class {0}", className);
            sb.AppendLine();
            sb.AppendLine("\t{");
            foreach (var parameterProperty in parameters)
            {
                WriteProperty(sb, domainDirectoryInfo.Name, className, parameterProperty);
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, className, sb.ToString());
        }

        private static void WriteCommand(DirectoryInfo domainDirectoryInfo, string ns, Command command)
        {
            if (null == command) return;
            var commandName = command.Name;
            var description = command.Description;
            var parameters = command.Parameters;
            var returnObject = command.Returns;
            _DomainCommands[domainDirectoryInfo.Name].Add(commandName);
            WriteCommand(domainDirectoryInfo, ns, commandName, description, parameters, command.SupportedBy);
            WriteCommandResponse(domainDirectoryInfo, ns, commandName, description, returnObject, command.SupportedBy);
        }

        private static void WriteCommandResponse(DirectoryInfo domainDirectoryInfo, string ns, string commandName, string description, IEnumerable<Property> returnObject, IEnumerable<string> supportedBy)
        {
            var className = ToCamelCase(commandName) + CommandResponseSubclass;
            var sb = new StringBuilder();
            sb.AppendLine("using MasterDevs.ChromeDevTools;");
            sb.AppendLine("using Newtonsoft.Json;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}.{2}", RootNamespace, ns, domainDirectoryInfo.Name);
            sb.AppendLine();
            sb.AppendLine("{");
            if (!String.IsNullOrEmpty(description))
            {
                sb.AppendLine("\t/// <summary>");
                sb.AppendFormat("\t/// {0}", description);
                sb.AppendLine();
                sb.AppendLine("\t/// </summary>");
            }
            sb.AppendFormat("\t[{0}({1}.{2}.{3})]", CommandResponseAttribute, ProtocolNameClass, domainDirectoryInfo.Name, ToCamelCase(commandName));
            sb.AppendLine();
            WriteSupportedBy(sb, supportedBy);
            sb.AppendFormat("\tpublic class {0}", className);
            sb.AppendLine();
            sb.AppendLine("\t{");
            foreach (var returnObjectProperty in returnObject)
            {
                WriteProperty(sb, domainDirectoryInfo.Name, className, returnObjectProperty);
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, className, sb.ToString());
        }

        private static void WriteCommand(DirectoryInfo domainDirectoryInfo, string ns, string commandName, string description, IEnumerable<Property> parameters, IEnumerable<string> supportedBy)
        {
            var className = ToCamelCase(commandName) + CommandSubclass;
            var sb = new StringBuilder();
            sb.AppendFormat("using MasterDevs.ChromeDevTools;");
            sb.AppendLine();
            sb.AppendLine("using Newtonsoft.Json;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}.{2}", RootNamespace, ns, domainDirectoryInfo.Name);
            sb.AppendLine();
            sb.AppendLine("{");
            if (!String.IsNullOrEmpty(description))
            {
                sb.AppendLine("\t/// <summary>");
                sb.AppendFormat("\t/// {0}", description);
                sb.AppendLine();
                sb.AppendLine("\t/// </summary>");
            }
            sb.AppendFormat("\t[{0}({1}.{2}.{3})]", CommandAttribute, ProtocolNameClass, domainDirectoryInfo.Name, ToCamelCase(commandName));
            sb.AppendLine();
            WriteSupportedBy(sb, supportedBy);
            sb.AppendFormat("\tpublic class {0}", className);
            sb.AppendLine();
            sb.AppendLine("\t{");
            foreach (var parameterProperty in parameters)
            {
                WriteProperty(sb, domainDirectoryInfo.Name, className, parameterProperty);
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, className, sb.ToString());
        }

        private static void WriteType(DirectoryInfo domainDirectoryInfo, string ns, Type type)
        {
            if (null == type) return;
            if (type.Enum.Any()) WriteTypeEnum(domainDirectoryInfo, ns, type);
            if (type.Properties.Any()) WriteTypeClass(domainDirectoryInfo, ns, type);
            WriteTypeSimple(domainDirectoryInfo, type);
        }

        private static void WriteTypeSimple(DirectoryInfo domainDirectoryInfo, Type type)
        {
            _SimpleTypes[type.Name] = type.Kind;
        }

        private static void WriteTypeClass(DirectoryInfo domainDirectoryInfo, string ns, Type type)
        {
            if ("object" != type.Kind) return;
            var className = type.Name;
            var sb = new StringBuilder();
            sb.AppendFormat("using MasterDevs.ChromeDevTools;");
            sb.AppendLine();
            sb.AppendLine("using Newtonsoft.Json;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}.{2}", RootNamespace, ns, domainDirectoryInfo.Name);
            sb.AppendLine();
            sb.AppendLine("{");
            sb.AppendLine("\t/// <summary>");
            sb.AppendFormat("\t/// {0}", type.Description);
            sb.AppendLine();
            sb.AppendLine("\t/// </summary>");
            WriteSupportedBy(sb, type);
            sb.AppendFormat("\tpublic class {0}", className);
            sb.AppendLine();
            sb.AppendLine("\t{");
            foreach (var propertyDescription in type.Properties)
            {
                WriteProperty(sb, domainDirectoryInfo.Name, className, propertyDescription);
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, className, sb.ToString());
        }

        private static void WriteProperty(StringBuilder sb, string domain, string className, Property property)
        {
            var propertyName = GeneratePropertyName(property.Name);
            string propertyType = property.Kind;
            if (null != property.TypeReference)
            {
                propertyType = GeneratePropertyTypeFromReference(domain, property.TypeReference);
            }
            else if ("array" == propertyType)
            {
                var arrayDescription = property.Items;
                if (null != arrayDescription.TypeReference)
                {
                    propertyType = GeneratePropertyTypeFromReference(domain, arrayDescription.TypeReference) + "[]";
                }
                else
                {
                    var arrayType = arrayDescription.Kind;
                    if ("object" == arrayType)
                    {
                        var internalClassName = ToCamelCase(propertyName) + "Array";
                        propertyType = internalClassName + "[]";
                        sb.AppendFormat("\t\tpublic class {0}", internalClassName);
                        sb.AppendLine();
                        sb.AppendLine("\t\t{");
                        foreach (var internalProperty in arrayDescription.Properties)
                        {
                            WriteProperty(sb, domain, internalClassName, internalProperty);
                        }
                        sb.AppendLine("\t\t}");
                        sb.AppendLine();
                    }
                    else
                    {
                        propertyType = GeneratePropertyType(arrayDescription.Kind) + "[]";
                    }
                }
            }
            else
            {
                propertyType = GeneratePropertyType(propertyType.ToString());
            }
            sb.AppendLine("\t\t/// <summary>");
            sb.AppendFormat("\t\t/// Gets or sets {0}", property.Description ?? propertyName);
            sb.AppendLine();
            sb.AppendLine("\t\t/// </summary>");
            if (className == propertyName)
            {
                sb.AppendFormat("\t\t[JsonProperty(\"{0}\")]", property.Name);
                sb.AppendLine();
                propertyName += "Child";
            }
            sb.AppendFormat("\t\tpublic {0} {1} {{ get; set; }}", propertyType, propertyName);
            sb.AppendLine();
        }

        private static string GeneratePropertyTypeFromReference(string domain, string propertyRef)
        {
            if (null == propertyRef) return null;
            var propertyPaths = propertyRef.Split('.');
            if (1 == propertyPaths.Length)
            {
                Dictionary<string, string> domainDictionary;
                string inDomainType;
                if (_DomainPropertyTypes.TryGetValue(domain, out domainDictionary)
                    && domainDictionary.TryGetValue(propertyPaths[0], out inDomainType))
                {
                    if (inDomainType.StartsWith(domain + "."))
                    {
                        return inDomainType.Substring(inDomainType.IndexOf('.') + 1);
                    }
                    return inDomainType;
                }
                return propertyPaths[0];
            }
            else
            {
                domain = propertyPaths[0];
                var name = propertyPaths[1];
                return _DomainPropertyTypes[domain][name];
            }
        }

        private static string GeneratePropertyType(string propertyType)
        {
            switch (propertyType)
            {
                case "number": return "double";
                case "integer": return "long";
                case "boolean": return "bool";
                case "any": return "object";
                default: return propertyType;
            }
        }

        private static string GeneratePropertyName(string propertyName)
        {
            return ToCamelCase(propertyName);
        }

        private static string ToCamelCase(string propertyName)
        {
            return Char.ToUpper(propertyName[0]).ToString() + propertyName.Substring(1);
        }

        private static void WriteTypeEnum(DirectoryInfo domainDirectoryInfo, string ns, Type type)
        {
            var enumName = type.Name;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using MasterDevs.ChromeDevTools;");
            sb.AppendLine("using Newtonsoft.Json;");
            sb.AppendLine("using Newtonsoft.Json.Converters;");
            sb.AppendLine("using System.Runtime.Serialization;");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}.{2}", RootNamespace, ns, domainDirectoryInfo.Name);
            sb.AppendLine("{");
            sb.AppendLine("\t/// <summary>");
            sb.AppendFormat("\t/// {0}", type.Description);
            sb.AppendLine();
            sb.AppendLine("\t/// </summary>");
            sb.AppendLine("\t[JsonConverter(typeof(StringEnumConverter))]");
            sb.AppendFormat("\tpublic enum {0}", enumName);
            sb.AppendLine();
            sb.AppendLine("\t{");
            foreach (var enumValueName in type.Enum)
            {
                if (enumValueName.Contains("-"))
                {
                    sb.AppendFormat("\t\t\t[EnumMember(Value = \"{0}\")]", enumValueName);
                    sb.AppendLine();
                }

                sb.AppendFormat("\t\t\t{0},", ToCamelCase(enumValueName.Replace("-", "_")));
                sb.AppendLine();
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, enumName, sb.ToString());
        }

        private static void WriteSupportedBy(StringBuilder sb, ProtocolItem type)
        {
            WriteSupportedBy(sb, type.SupportedBy);
        }

        private static void WriteSupportedBy(StringBuilder sb, IEnumerable<string> supportedBy)
        {
            foreach (var browser in supportedBy)
            {
                sb.AppendLine($"\t[SupportedBy(\"{browser}\")]");
            }
        }

        private static void WriteToFile(DirectoryInfo domainDirectoryInfo, string fileName, string fileContents)
        {
            var fullPath = Path.Combine(domainDirectoryInfo.FullName, fileName + ".cs");
            if (File.Exists(fullPath)) File.Delete(fullPath);
            File.WriteAllText(fullPath, fileContents);
        }

        private static DirectoryInfo CreateDomainFolder(DirectoryInfo parentDirectory, string domainName)
        {
            return parentDirectory.CreateSubdirectory(domainName);
        }
    }
}