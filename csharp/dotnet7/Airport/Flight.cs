using Airport.Passenger;

namespace Airport;

public record Flight
{
    public IList<IPassenger> Passengers
    {
        get; init;
    } = new List<IPassenger>();
}