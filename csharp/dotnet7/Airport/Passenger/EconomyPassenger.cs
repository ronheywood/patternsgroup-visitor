namespace Airport.Passenger;

public record EconomyPassenger : IPassenger
{
    public TicketType TicketType { get; init; } = TicketType.Economy;

    public IList<ILuggage> Baggage { get; init; } = new List<ILuggage>();
};