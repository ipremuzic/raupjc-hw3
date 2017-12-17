using System;

namespace Zad1.Exceptions
{
    public class DuplicateTodoItemException : Exception
    {
        public DuplicateTodoItemException(String message) : base(message)
        {
            
        }
    }
}
