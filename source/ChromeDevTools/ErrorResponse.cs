using System;

namespace MasterDevs.ChromeDevTools
{
    public interface IErrorResponse
    {
        Error Error { get; }

        long Id { get; }
    }

    public class Error
    {
        public int Code { get; set; }

        public string Message { get; set; }
    }

    public class ErrorResponse : IErrorResponse, ICommandResponse
    {
        public Error Error
        {
            get;
            set;
        }

        public long Id
        {
            get;
            set;
        }

        public string Method
        {
            get { throw new NotSupportedException(); }
        }
    }
}