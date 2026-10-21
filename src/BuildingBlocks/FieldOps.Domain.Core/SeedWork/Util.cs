using FieldOps.Domain.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace FieldOps.Domain.Core.SeedWork
{
    public static class Util    
    {
        public static void ThrowIfNull([NotNull] object? argument, [CallerArgumentExpression("argument")] string? paramName = null)
        {
            if (argument is null)
                ThrowNull(paramName!);
        }

        public static void ThrowIfNullOrWhitespace([NotNull] string? argument, [CallerArgumentExpression("argument")] string? paramName = null)
        {
            if (string.IsNullOrWhiteSpace(argument))
                ThrowNull(paramName!);
        }

        [DoesNotReturn]
        private static void ThrowNull(string paramName)
            => throw new DomainException($"{paramName} cannot be null or empty");
            

    }
}
