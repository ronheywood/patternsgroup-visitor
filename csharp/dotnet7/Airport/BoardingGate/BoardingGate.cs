using Airport.Passenger;

namespace Airport.BoardingGate;

public class BoardingGate
{
    private readonly Flight _flight;
    
    public BoardingGate(Flight flight)
    {
        _flight = flight;
    }

    public void AddPassenger(IPassenger passenger)
    {
        _passengers.Add(passenger);
    }

    private readonly IList<IPassenger> _passengers = new List<IPassenger>();
    private BoardingStatus _gateStatus = BoardingStatus.Closed;

    public void BoardPassengers()
    {
        foreach (var passenger in _passengers)
        {
            switch (_gateStatus)
            {
                case BoardingStatus.Priority:
                    if(passenger is FirstClassPassenger or BusinessPassenger)
                        _flight.Passengers.Add(passenger);
                    break;
                case BoardingStatus.PremiumEconomy:
                    if(passenger is PremiumEconomyPassenger)
                        _flight.Passengers.Add(passenger);
                    break;
                case BoardingStatus.Open:
                    _flight.Passengers.Add(passenger);
                    break;
                case BoardingStatus.Closed:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        AnnounceBoardingForNextClassOfPassenger();
    }

    private void AnnounceBoardingForNextClassOfPassenger()
    {
        if (_gateStatus != BoardingStatus.Open) _gateStatus--;
    }

    public void AllowBoarding() => _gateStatus = BoardingStatus.Priority;
}

internal enum BoardingStatus
{
    Priority = 3,
    PremiumEconomy = 2,
    Open = 1,
    Closed = 0
}