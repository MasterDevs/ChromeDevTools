using System;

namespace MasterDevs.ChromeDevTools
{
    public interface ICommandResponseWrapper<T>
    {
        long Id { get; }
        string Method { get; }
        bool IsError();
        T Result { get; }
        Error Error { get; }
    }

    public class CommandResponseWrapper<T> : ICommandResponseWrapper<T>
    {
        private readonly ICommandResponse _response;

        public CommandResponseWrapper(ICommandResponse response)
        {
            _response = response;
        }

        public long Id => _response.Id;
        public string Method => _response.Method;

        public bool IsError() => _response is IErrorResponse;

        public T Result
        {
            get
            {
                var commandResponse = _response as CommandResponse<T>;
                if (commandResponse != null)
                    return commandResponse.Result;
                throw new ResultNotAvailableException((IErrorResponse)_response, typeof(T));
            }
        }

        public Error Error => (_response as IErrorResponse)?.Error;
    }

    public class ResultNotAvailableException : Exception
    {
        public ResultNotAvailableException(IErrorResponse response, Type type) 
            : base($"Unhandled command error {{ Code: {response.Error.Code}, Message: {response.Error.Message} }} to command {response.Id} requesting {type}.")
        {
        }
    }
}