namespace Airport.Passenger;

public record PremiumEconomyPassenger : IPassenger
{
    public TicketType TicketType { get; init; } = TicketType.PremiumEconomy;

    public IList<ILuggage> Baggage { get; init; } = new List<ILuggage>();
}