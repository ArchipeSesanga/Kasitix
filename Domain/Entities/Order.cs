namespace Domain.Entities;
public class Order
{
    //Id, EventId, BuyerEmail, IdempotencyKey, Status
    //(Confirmed/Cancelled), CreatedAt, Lines

    public Guid Id {get; private set;}
    public Guid EventId {get; private set;}
    public string Email {get; private set;}

    public string IdempotencyKey  {get; private set;}

    
    
}