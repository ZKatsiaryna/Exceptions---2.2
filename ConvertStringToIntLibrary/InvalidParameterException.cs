using System;
using System.Runtime.Serialization;

namespace ConvertStringToIntLibrary
{
    [Serializable]
    public class InvalidNumberFormatException : Exception
    {
        public InvalidNumberFormatException()
        {
        }

        public InvalidNumberFormatException(string message) : base(message)
        {
        }

        public InvalidNumberFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidNumberFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}