using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System;
using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    public class Command : ProtocolItem
    {
        public Command()
        {
            this.Returns = new Collection<Property>();
            this.Handlers = new Collection<string>();
            this.Parameters = new Collection<Property>();
        }

        public Collection<Property> Returns
        {
            get;
            set;
        }

        public Property Error
        {
            get;
            set;
        }

        /// <remarks>
        /// This property is currently ignored.
        /// </remarks>
        public Collection<string> Handlers
        {
            get;
            set;
        }

        public Collection<Property> Parameters
        {
            get;
            set;
        }

        public bool async
        {
            get;
            set;
        }

        public string Redirect
        {
            get;
            set;
        }

        [JsonProperty("experimental")]
        public bool IsExperimental { get; set; }

        [JsonProperty("deprecated")]
        public bool IsDeprecated
        {
            get;
            set;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Command;

            if (other == null)
            {
                return false;
            }

            bool equals = base.Equals(obj);
            equals &= this.Returns.SequenceEqual(other.Returns);
            equals &= Property.Equals(this.Error, other.Error);
            equals &= this.Parameters.SequenceEqual(other.Parameters);
            return equals;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = base.GetHashCode();
                hash = hash * 23 + this.Redirect.GetHashCode();

                if (this.Error != null)
                {
                    hash = hash * 23 + this.Error.GetHashCode();
                }

                hash = hash * 23 + this.Parameters.GetCollectionHashCode();
                return hash;
            }
        }

        public override string ToString()
        {
            StringBuilder name = new StringBuilder();

            if (this.Returns.Count > 0)
            {
                name.Append("(");
                bool isFirst = true;

                foreach (var p in this.Returns)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        name.Append(", ");
                    }

                    name.Append(p.TypeName);
                    name.Append(" ");
                    name.Append(p.Name);
                }

                name.Append(") ");
            }
            else
            {
                name.Append("void ");
            }

            name.Append(this.Name);

            name.Append("(");

            bool isFirstParam = true;
            foreach (var p in this.Parameters)
            {
                if (isFirstParam)
                {
                    isFirstParam = false;
                }
                else
                {
                    name.Append(", ");
                }

                name.Append(p.TypeName);
                name.Append(" ");
                name.Append(p.Name);
            }

            name.Append(")");

            return name.ToString();
        }

        public Property GetParameter(string name)
        {
            return this.Parameters.SingleOrDefault(p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
