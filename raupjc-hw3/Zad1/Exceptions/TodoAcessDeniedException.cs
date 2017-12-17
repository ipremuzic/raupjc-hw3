using System;

namespace Zad1.Exceptions
{ 
    public class TodoAcessDeniedException : Exception
    {
        public TodoAcessDeniedException(string message) : base(message)
        {

        }
    }
}