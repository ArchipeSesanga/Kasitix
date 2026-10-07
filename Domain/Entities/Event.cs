namespace Domain.Entities;

public enum Status
{
    Draft,
    Published,
    Cancelled
}
public class Event
{
    //Id, Name, Venue, StartsAt, Status
//(Draft/Published/Cancelled), TicketTypes

public Guid Id  { get; private set; }
public string Name  { get; private set; } = "";
public string Venue  { get; private set; } = "";
public DateTime StartsAt  { get; private set; }


    
}
