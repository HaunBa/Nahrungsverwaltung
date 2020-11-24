using System;
using System.Runtime.Serialization;

namespace Nahrungsverwaltung.Forms
{
    [Serializable]
    internal class NotWorkingException : Exception
    {
        public NotWorkingException()
        {
        }

        public NotWorkingException(string message) : base(message)
        {
        }

        public NotWorkingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotWorkingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}