using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dto
{
    public class RequestMessage<T>
    {
        public string Message { get; set; }
        public string Status { get; set; }
        public T Content { get; set; }
    }
}