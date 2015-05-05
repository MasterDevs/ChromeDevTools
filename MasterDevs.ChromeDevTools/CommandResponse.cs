using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface ICommandResponse
    {
        long Id { get; }

        string Method { get; }
    }
    public class CommandResponse : ICommandResponse
    {
        public long Id
        {
            get;
            set;
        }

        public string Method
        {
            get;
            set;
        }
    }

    public class CommandResponse<T> : CommandResponse
    {
        public T Result
        {
            get;
            private set;
        }
    }
}
