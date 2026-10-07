using Domain.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class EventRepository : IEventRepository
{

     public Task<IEnumerable<Event>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

      public Task<Event?> GetByIdAsync(Guid id, bool trackChanges = false)
    {
        throw new NotImplementedException();
    }
     public Task<Event?> GetByTicketTypeAsync(String ticketType)
    {
        throw new NotImplementedException();
    }
    public Task<Event> PublishAsync(Event entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CancelAsync(Guid id)
    {
        throw new NotImplementedException();
    }



    public Task<bool> UpdateAsync(Event entity)
    {
        throw new NotImplementedException();
    }

    public Task<Event> GetPublishedAsync(string Status)
    {
        throw new NotImplementedException();
    }
}