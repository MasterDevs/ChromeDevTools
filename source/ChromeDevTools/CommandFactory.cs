using System.Collections.Concurrent;
using System.Threading;

namespace MasterDevs.ChromeDevTools
{
    public class CommandFactory : ICommandFactory
    {
        private readonly ConcurrentDictionary<long, string> _methods = new ConcurrentDictionary<long, string>();
        private long _count = 0;

        public Command Create<T>()
        {
            var commandId = Interlocked.Increment(ref _count);
            var command = new Command<T>
            {
                Id = commandId
            };
            command.Method = command.GetMethod();
            _methods.AddOrUpdate(commandId, command.Method, (key, value) => command.Method);
            return command;
        }

        public Command<T> Create<T>(T parameter)
        {
            var commandId = Interlocked.Increment(ref _count);
            var command = new Command<T>
            {
                Id = commandId,
                Method = parameter.GetMethod(),
                Params = parameter
            };
            _methods.AddOrUpdate(commandId, command.Method, (key, value) => command.Method);
            return command;
        }

        public string GetMethod(long id)
        {
            string result;
            _methods.TryGetValue(id, out result);
            return result;
        }
    }
}