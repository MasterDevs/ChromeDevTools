using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class Program
    {
        const string CommandAttribute = "Command";
        const string CommandResponseAttribute = "CommandResponse";
        const string EventAttribute = "Event";
        const string ProtocolNameClass = "ProtocolName";
        const string RootNamespace = "MasterDevs.ChromeDevTools.Protocol";
        const string CommandSubclass = "Command";
        const string CommandResponseSubclass = CommandSubclass + "Response";
        const string EventSubclass = "Event";
        private static Dictionary<string, Dictionary<string, string>> _DomainPropertyTypes = new Dictionary<string,Dictionary<string,string>>();
        private static Dictionary<string, List<string>> _DomainCommands = new Dictionary<string, List<string>>();
        private static Dictionary<string, List<string>> _DomainEvents = new Dictionary<string, List<string>>();
        private static Dictionary<string, string> _SimpleTypes = new Dictionary<string, string>();


        static void Main(string[] args)
        {
            var filePath = "protocol.json";
            JObject protocolObject = null;
            using(var fileStream = File.OpenText(filePath))
            using(var reader = new JsonTextReader(fileStream))
            {
                protocolObject = (JObject)JToken.ReadFrom(reader);
            }
            var outputFolder = "OutputProtocol";
            if(Directory.Exists(outputFolder))
            {
                Directory.Delete(outputFolder, true);
            }
            var outputDirectoryInfo = Directory.CreateDirectory(outputFolder);
            WriteProtocolClasses(protocolObject, outputDirectoryInfo);
        }

        private static void WriteProtocolClasses(JObject protocolObject, DirectoryInfo directory)
        {
            var domains = protocolObject["domains"] as JArray;
            foreach (var domain in domains)
            {
                AddPropertyTypes(domain["domain"].ToString(), domain["types"] as JArray);
            }
            foreach(var domain in domains)
            {
                var domainName = domain["domain"].ToString();
                var types = domain["types"] as JArray;
                var commands = domain["commands"] as JArray;
                var events = domain["events"] as JArray;
                _DomainCommands[domainName] = new List<string>();
                _DomainEvents[domainName] = new List<string>();
                WriteProtocolClasses(directory, domainName, types, commands, events);
            }
            WriteMethodConstants(directory);
        }

        private static void AddPropertyTypes(string domain, JArray types)
        {
            var domainDictionary = new Dictionary<string, string>();
            _DomainPropertyTypes[domain] = domainDictionary;
            foreach (var type in types ?? new JArray())
            {
                var propertyType = type["type"].ToString();
                var typeName = GetString(type["id"]);
                if (null != type["enum"] 
                    || null != type["properties"] 
                    || "object" == propertyType)
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

        private static void AddArrayPropertyType(Dictionary<string, string> domainDictionary, string domain, JToken type)
        {
            var items = type["items"];
            if (null == items) return;
            var itemsType = GeneratePropertyType(GetString(items["type"]));
            if (String.IsNullOrEmpty(itemsType))
            {
                itemsType = GetString(items["$ref"]);
            }
            domainDictionary[type["id"].ToString()] = domain + "." + itemsType + "[]";
        }

        private static void WriteProtocolClasses(DirectoryInfo directory, string domainName, JArray types, JArray commands, JArray events)
        {
            var domainDirectoryInfo = CreateDomainFolder(directory, domainName);
            foreach(var type in types ?? new JArray())
            {
                WriteType(domainDirectoryInfo, type as JObject);
            }
            foreach (var command in commands ?? new JArray())
            {
                WriteCommand(domainDirectoryInfo, command as JObject);
            }
            foreach (var evnt in events ?? new JArray())
            {
                WriteEvent(domainDirectoryInfo, evnt as JObject);
            }
        }
        
        private static void WriteMethodConstants(DirectoryInfo domainDirectoryInfo)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("using MasterDevs.ChromeDevTools;");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendFormat("namespace {0}", RootNamespace);
            sb.AppendLine();
            sb.AppendLine("{");
            sb.AppendFormat("\tpublic static class {0}", ProtocolNameClass);
            sb.AppendLine();
            sb.AppendLine("\t{");

            var domains = _DomainCommands.Keys.Union(_DomainEvents.Keys).Distinct();
            foreach(var domain in domains)
            {
                sb.AppendFormat("\t\tpublic static class {0}", domain);
                sb.AppendLine();
                sb.AppendLine("\t\t{");
                List<string> commands;
                if(_DomainCommands.TryGetValue(domain, out commands))
                {
                    foreach(var commandName in commands)
                    {
                        sb.AppendFormat("\t\t\tpublic const string {0} = \"{1}.{2}\";", ToCamelCase(commandName), domain, commandName);
                        sb.AppendLine();
                    }
                }
                List<string> events;
                if(_DomainEvents.TryGetValue(domain, out events))
                {
                    foreach(var eventName in events)
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

        private static void WriteEvent(DirectoryInfo domainDirectoryInfo, JObject evnt)
        {
            if (null == evnt) return;
            var eventName = evnt["name"].ToString();
            var description = GetString(evnt["description"]);
            var parameters = evnt["parameters"] as JArray;
            // ignoreing "handlers" ... i'm not sure what they are for yet
            _DomainEvents[domainDirectoryInfo.Name].Add(eventName);
            WriteEvent(domainDirectoryInfo, eventName, description, parameters);
        }

        private static void WriteEvent(DirectoryInfo domainDirectoryInfo, string eventName, string description, JArray parameters)
        {
            var className = ToCamelCase(eventName) + EventSubclass;
            var sb = new StringBuilder();
            sb.AppendFormat("using MasterDevs.ChromeDevTools;");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}", RootNamespace, domainDirectoryInfo.Name);
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
            sb.AppendFormat("\tpublic class {0}", className);
            sb.AppendLine();
            sb.AppendLine("\t{");
            foreach (var parameterProperty in parameters ?? new JArray())
            {
                WriteProperty(sb, domainDirectoryInfo.Name, className, parameterProperty as JObject);
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, className, sb.ToString());
        }

        private static void WriteCommand(DirectoryInfo domainDirectoryInfo, JObject command)
        {
            if (null == command) return;
            var commandName = command["name"].ToString();
            var description = GetString(command["description"]);
            var parameters = command["parameters"] as JArray;
            var returnObject = command["returns"] as JArray;
            _DomainCommands[domainDirectoryInfo.Name].Add(commandName);
            WriteCommand(domainDirectoryInfo, commandName, description, parameters);
            WriteCommandResponse(domainDirectoryInfo, commandName, description, returnObject);
        }

        private static string GetString(JToken jToken)
        {
            return null == jToken ? null : jToken.ToString();
        }

        private static void WriteCommandResponse(DirectoryInfo domainDirectoryInfo, string commandName, string description, JArray returnObject)
        {
            var className = ToCamelCase(commandName) + CommandResponseSubclass;
            var sb = new StringBuilder();
            sb.AppendLine("using MasterDevs.ChromeDevTools;");
            sb.AppendLine("using Newtonsoft.Json;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}", RootNamespace, domainDirectoryInfo.Name);
            sb.AppendLine();
            sb.AppendLine("{");
            if(!String.IsNullOrEmpty(description))
            { 
                sb.AppendLine("\t/// <summary>");
                sb.AppendFormat("\t/// {0}", description);
                sb.AppendLine();
                sb.AppendLine("\t/// </summary>");
            }
            sb.AppendFormat("\t[{0}({1}.{2}.{3})]", CommandResponseAttribute, ProtocolNameClass, domainDirectoryInfo.Name, ToCamelCase(commandName));
            sb.AppendLine();
            sb.AppendFormat("\tpublic class {0}", className);
            sb.AppendLine();
            sb.AppendLine("\t{");
            foreach (var returnObjectProperty in returnObject ?? new JArray())
            {
                WriteProperty(sb, domainDirectoryInfo.Name, className, returnObjectProperty as JObject);
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, className, sb.ToString());
        }

        private static void WriteCommand(DirectoryInfo domainDirectoryInfo, string commandName, string description, JArray parameters)
        {
            var className = ToCamelCase(commandName) + CommandSubclass;
            var sb = new StringBuilder();
            sb.AppendFormat("using MasterDevs.ChromeDevTools;");
            sb.AppendLine();
            sb.AppendLine("using Newtonsoft.Json;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}", RootNamespace, domainDirectoryInfo.Name);
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
            sb.AppendFormat("\tpublic class {0}", className);
            sb.AppendLine();
            sb.AppendLine("\t{");
            foreach (var parameterProperty in parameters ?? new JArray())
            {
                WriteProperty(sb, domainDirectoryInfo.Name, className, parameterProperty as JObject);
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, className, sb.ToString());
        }

        private static void WriteType(DirectoryInfo domainDirectoryInfo, JObject type)
        {
            if (null == type) return;
            if (null != type["enum"]) WriteTypeEnum(domainDirectoryInfo, type);
            if (null != type["properties"]) WriteTypeClass(domainDirectoryInfo, type);
            WriteTypeSimple(domainDirectoryInfo, type);
        }

        private static void WriteTypeSimple(DirectoryInfo domainDirectoryInfo, JObject type)
        {
            _SimpleTypes[type["id"].ToString()] = type["type"].ToString();
        }

        private static void WriteTypeClass(DirectoryInfo domainDirectoryInfo, JObject type)
        {
            if ("object" != type["type"].ToString()) return;
            var className = type["id"].ToString();
            var sb = new StringBuilder();
            sb.AppendFormat("using MasterDevs.ChromeDevTools;");
            sb.AppendLine();
            sb.AppendLine("using Newtonsoft.Json;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}", RootNamespace, domainDirectoryInfo.Name);
            sb.AppendLine();
            sb.AppendLine("{");
            sb.AppendLine("\t/// <summary>");
            sb.AppendFormat("\t/// {0}", type["description"]);
            sb.AppendLine();
            sb.AppendLine("\t/// </summary>");
            sb.AppendFormat("\tpublic class {0}", className);
            sb.AppendLine();
            sb.AppendLine("\t{");
            foreach (var propertyDescription in type["properties"] as JArray ?? new JArray())
            {
                WriteProperty(sb, domainDirectoryInfo.Name, className, propertyDescription as JObject);
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, className, sb.ToString());
        }

        private static void WriteProperty(StringBuilder sb, string domain, string className, JObject property)
        {
            var propertyName = GeneratePropertyName(property["name"].ToString());
            string propertyType = GetString(property["type"]);
            if(null != property["$ref"])
            {
                propertyType = GeneratePropertyTypeFromReference(domain, property["$ref"].ToString());
            }
            else if("array" == propertyType)
            {
                var arrayDescription = property["items"] as JObject;
                if(null != arrayDescription["$ref"])
                {
                    propertyType = GeneratePropertyTypeFromReference(domain, arrayDescription["$ref"].ToString()) + "[]";
                } 
                else
                {
                    var arrayType = GetString(arrayDescription["type"]);
                    if("object" == arrayType)
                    {
                        var internalClassName = ToCamelCase(propertyName) + "Array";
                        propertyType = internalClassName + "[]";
                        sb.AppendFormat("\t\tpublic class {0}", internalClassName);
                        sb.AppendLine();
                        sb.AppendLine("\t\t{");
                        foreach(var internalProperty in arrayDescription["properties"] as JArray ?? new JArray())
                        {
                            WriteProperty(sb, domain, internalClassName, internalProperty as JObject);
                        }
                        sb.AppendLine("\t\t}");
                        sb.AppendLine();
                    } 
                    else 
                    {
                        propertyType = GeneratePropertyType(GetString(arrayDescription["type"])) + "[]";
                    }
                }
            } 
            else
            {
                propertyType = GeneratePropertyType(propertyType.ToString());
            } 
            sb.AppendLine("\t\t/// <summary>");
            sb.AppendFormat("\t\t/// Gets or sets {0}", property["description"] ?? propertyName);
            sb.AppendLine();
            sb.AppendLine("\t\t/// </summary>");
            if(className == propertyName)
            {
                sb.AppendFormat("\t\t[JsonProperty(\"{0}\")]", property["name"]);
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
                if(_DomainPropertyTypes.TryGetValue(domain, out domainDictionary)
                    && domainDictionary.TryGetValue(propertyPaths[0], out inDomainType))
                {
                    if(inDomainType.StartsWith(domain + "."))
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
            switch(propertyType)
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

        private static void WriteTypeEnum(DirectoryInfo domainDirectoryInfo, JObject type)
        {
            var enumName = type["id"].ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("using MasterDevs.ChromeDevTools;");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendFormat("namespace {0}.{1}", RootNamespace, domainDirectoryInfo.Name);
            sb.AppendLine("{");
            sb.AppendLine("\t/// <summary>");
            sb.AppendFormat("\t/// {0}", type["description"]);
            sb.AppendLine();
            sb.AppendLine("\t/// </summary>");
            sb.AppendFormat("\tpublic enum {0}", enumName);
            sb.AppendLine();
            sb.AppendLine("\t{");
            foreach(var enumValueName in type["enum"] as JArray ?? new JArray())
            {
                sb.AppendFormat("\t\t\t{0},", ToCamelCase(enumValueName.ToString().Replace("-", "_")));
                sb.AppendLine();
            }
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            WriteToFile(domainDirectoryInfo, enumName, sb.ToString());
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
