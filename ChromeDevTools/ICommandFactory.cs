using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeDevTools
{
    public interface ICommandFactory
    {
        string GetMethod(long id);

        Command Create<T>();

        Command<T> Create<T>(T parameter);
    }
}
