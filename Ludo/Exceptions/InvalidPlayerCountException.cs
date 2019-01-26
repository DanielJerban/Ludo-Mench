using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Exceptions
{
    public class InvalidPlayerCountException : ApplicationException
    {
        public InvalidPlayerCountException()
        {
        }

        public InvalidPlayerCountException(string message) : base(message)
        {
        }

        public InvalidPlayerCountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPlayerCountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
