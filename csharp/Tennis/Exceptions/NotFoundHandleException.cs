using System;

namespace Tennis.Exceptions
{
    public class NotFoundHandleException : Exception
    {
        public NotFoundHandleException(string message) : base(message)
        {
        }
    }
}