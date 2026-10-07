namespace Domain.Entities;

public enum TicketTypeId
{
    
}
public class OrderLine
{
    //Id, OrderId, TicketTypeId, Quantity, UnitPrice 
    public Guid Id {get; private set;}
    public Guid OrderId {get; private set;}

    public int Quantity {get; private set;}
    public double UnitPrice{get; private set;}

}