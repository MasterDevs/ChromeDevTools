using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebPerf.Chrome.Messages
{
    public class Error
    {
        public int Code { get; set; }
        public string message { get; set; }
    }

    class ErrorResponse : IdResponse
    {
        public Error Error { get; set; }
        public int Id { get; set; }
    }




}
