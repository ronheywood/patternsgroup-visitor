namespace Airport.Passenger;

public interface IPassenger
{
    protected TicketType TicketType { get; init; }
    public IList<ILuggage> Baggage { get; init; }
}