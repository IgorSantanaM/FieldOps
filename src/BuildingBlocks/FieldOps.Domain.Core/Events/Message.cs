namespace FieldOps.Domain.Core.Events
{
    public abstract record Message<TId> where TId : notnull
    {
        public string MessageType { get; set; }
        public TId AggregateId { get; set; }

        public Message(TId aggregateId)
        {
            AggregateId = aggregateId;
            MessageType = GetType().Name;
        }
    }
}
