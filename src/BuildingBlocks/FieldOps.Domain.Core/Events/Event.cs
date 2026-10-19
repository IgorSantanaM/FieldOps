using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldOps.Domain.Core.Events
{
    public abstract record class Event<TId> : Message<TId>, INotification where TId : notnull
    {
        public DateTime TimeStamp { get; init; }

        protected Event(TId aggregateId) : base(aggregateId)
        {
            TimeStamp = DateTime.Now;
        }
    }
}
