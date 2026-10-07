using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IEventRepository
{
    Task<IEnumerable<Event>> GetAllAsync();
 
    Task<Event?> GetByIdAsync(Guid id, bool trackChanges = false);
    Task<Event?> GetByTicketTypeAsync(String ticketType);

    Task<Event> GetPublishedAsync(String Status);
    Task<Event> PublishAsync(Event entity);
    Task<bool> UpdateAsync(Event entity);
    Task<bool> CancelAsync(Guid id);
    
}