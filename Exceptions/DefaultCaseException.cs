using System;
using System.Runtime.Serialization;

namespace Nahrungsverwaltung.Forms
{
    [Serializable]
    internal class DefaultCaseException : Exception
    {
        public DefaultCaseException()
        {
        }

        public DefaultCaseException(string message) : base(message)
        {
        }

        public DefaultCaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DefaultCaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}