namespace Domain.Entities;

public class TicketType
{
    //Id, EventId, Name, Price, Capacity, Sold, Version
    //(xmin)

    public Guid Id {get; private set;}
    public double Price {get; private set;}
    public int Capacity {get; private set;}
    public int Sold {get; private set;}

    public int Remaining()
    {
        var remaining = Capacity - Sold;
        return remaining;
    }

    public int Reserve()
    {
        //TODO: to be implemented
       return 0;
    }
    public int Release()
    {
        //TODO: to be implemented
        return 0;
        
    }
}