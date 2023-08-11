namespace Airport.Passenger;

public record BusinessPassenger : IPassenger
{
    public TicketType TicketType { get; init; } = TicketType.Business;

    public IList<ILuggage> Baggage { get; init; } = new List<ILuggage>();
};