using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class Type : ProtocolItem
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
                    return this.Items.Name + "[]";
                }
                else if(this.Kind != null && this.Kind != "object")
                {
                    return this.Kind;
                }
                else
                {
                    return this.Name;
                }
            }
        }
        public override bool Equals(object obj)
        {
            var other = obj as Type;

            if (other == null)
            {
                return false;
            }

            return base.Equals(obj)
                && string.Equals(this.Kind, other.Kind, StringComparison.OrdinalIgnoreCase)
                && this.Enum.SetEquals(other.Enum)
                && this.Properties.SetEquals(other.Properties)
                && Type.Equals(this.Items, other.Items)
                && this.MinItems == other.MinItems
                && this.MaxItems == other.MaxItems
                && string.Equals(this.TypeReference, other.TypeReference, StringComparison.OrdinalIgnoreCase);
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
    }
}
