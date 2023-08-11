namespace Airport.Passenger;

public record FirstClassPassenger : IPassenger
{
    public TicketType TicketType { get; init; } = TicketType.FirstClass;

    public IList<ILuggage> Baggage { get; init; } = new List<ILuggage>();
};