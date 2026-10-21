namespace FieldOps.Domain.WorkOrders.Enum;

public enum WorkOrderStatus
{
    Draft = 1,
    AwaitingResources = 2,
    Blocked = 3,
    Ready = 4,
    StartPending = 5,
    InProgress = 6,
    CompletionPending = 7,
    CompletionBlocked = 8,
    Completed = 9,
    Billed = 10,
    Closed = 11,
    Cancelled = 12
}
