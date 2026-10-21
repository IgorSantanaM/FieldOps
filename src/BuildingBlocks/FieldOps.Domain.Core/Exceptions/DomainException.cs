using System;
using System.Collections.Generic;
using System.Text;

namespace FieldOps.Domain.Core.Exceptions
{
    public sealed class DomainException : Exception
    {
        public DomainException() : base() {}
        public DomainException(string message) : base(message) {}
    }
}
