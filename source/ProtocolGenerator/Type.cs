using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    public class Type : ProtocolItem
    {
        public Type()
        {
            this.Enum = new HashSet<string>();
            this.Properties = new HashSet<Property>();
        }

        [JsonProperty(PropertyName = "Id")]
        public override string Name
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "type")]
        public string Kind
        {
            get;
            set;
        }

        public HashSet<string> Enum
        {
            get;
            set;
        }

        public HashSet<Property> Properties
        {
            get;
            set;
        }

        public Type Items
        {
            get;
            set;
        }

        public int MinItems
        {
            get;
            set;
        }

        public int MaxItems
        {
            get;
            set;
        }

        [JsonProperty("$ref")]
        public string TypeReference
        {
            get;
            set;
        }

        public string TypeName
        {
            get
            {
                if (this.TypeReference != null)
                {
                    return this.TypeReference;
                }
                else if (this.Items != null)
                {
                    return this.Items.TypeName + "[]";
                }
                else if (this.Kind != null && this.Kind != "object")
                {
                    return this.Kind;
                }
                else
                {
                    return this.Name;
                }
            }
        }

        [JsonProperty("experimental")]
        public bool IsExperimental { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Type;

            if (other == null)
            {
                return false;
            }

            bool equals = base.Equals(obj);
            equals &= string.Equals(this.Kind, other.Kind, StringComparison.OrdinalIgnoreCase);
            equals &= this.Enum.SetEquals(other.Enum);
            equals &= this.Properties.SetEquals(other.Properties);
            equals &= Type.Equals(this.Items, other.Items);
            equals &= this.MinItems == other.MinItems;
            equals &= this.MaxItems == other.MaxItems;
            equals &= string.Equals(this.TypeReference, other.TypeReference, StringComparison.OrdinalIgnoreCase);

            return equals;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = base.GetHashCode();

                if (this.Kind != null)
                {
                    hash = hash * 23 + StringComparer.OrdinalIgnoreCase.GetHashCode(this.Kind);
                }

                hash = hash * 23 + this.Enum.GetCollectionHashCode();
                hash = hash * 23 + this.Properties.GetCollectionHashCode();

                if (this.Items != null)
                {
                    hash = hash * 23 + this.Items.GetHashCode();
                }

                hash = hash * 23 + this.MinItems.GetHashCode();
                hash = hash * 23 + this.MaxItems.GetHashCode();

                if (this.TypeReference != null)
                {
                    hash = hash * 23 + StringComparer.OrdinalIgnoreCase.GetHashCode(this.TypeReference);
                }

                return hash;
            }
        }

        public bool IsString()
        {
            return string.Equals(this.Kind, "string", StringComparison.OrdinalIgnoreCase);
        }

        public bool IsInteger()
        {
            return string.Equals(this.Kind, "integer", StringComparison.OrdinalIgnoreCase);
        }

        public bool IsEnum()
        {
            return this.Enum.Any();
        }

        public bool IsClass()
        {
            return this.Properties.Any();
        }

        public bool IsObject()
        {
            return string.Equals(this.Kind, "object", StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return this.TypeName;
        }
    }
}
