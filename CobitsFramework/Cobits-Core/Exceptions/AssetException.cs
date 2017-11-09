using System;
using System.Runtime.Serialization;

namespace Cobits.Core.Exceptions
{
    [Serializable]
    public class AssetException : Exception
    {
        public AssetException()
        {

        }


        public AssetException(string message) : base(message)
        {
            
        }

        public AssetException(string messageFormat, params object[] args)
            : base(string.Format(messageFormat, args))
        {
        }


        protected AssetException(SerializationInfo
            info, StreamingContext context)
            : base(info, context)
        {
        }

        public AssetException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
}
