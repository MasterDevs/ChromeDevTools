using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface ICommand
    {
        long Id { get; }

        string Method { get; }
    }
    public class Command : ICommand
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

    public class Command<T> : Command
    {
        public T Params 
        { 
            get; 
            set; 
        }
    }
}
