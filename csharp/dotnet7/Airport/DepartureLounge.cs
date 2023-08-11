using Airport.Passenger;

namespace AirportTests;

public abstract record DepartureLounge
{
    public IList<IPassenger> Passengers { get; init; } = new List<IPassenger>();

    private sealed record OpenLounge : DepartureLounge;

    private sealed record PrivateLounge : DepartureLounge;

    public static DepartureLounge SharedLounge { get; } = new OpenLounge();
    public static DepartureLounge PremiumLounge { get; } = new PrivateLounge();
}