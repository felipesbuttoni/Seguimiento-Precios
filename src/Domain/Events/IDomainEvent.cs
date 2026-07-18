namespace SeguimientoPreciosWebApp.Domain.Events;

public interface IDomainEvent
{
    DateTime OcurredOn => DateTime.UtcNow;
}