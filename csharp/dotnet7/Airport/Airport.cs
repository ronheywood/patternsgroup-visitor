using Airport.Checkin;
using Airport.Passenger;

namespace Airport;

public class Airport
{
    private readonly IEnumerable<CheckinDesk> _checkInDesks;

    public Airport(IEnumerable<CheckinDesk> checkInDesks)
    {
        _checkInDesks = checkInDesks;
    }

    public void AddPassenger(IPassenger passenger)
    {
        switch (passenger)
        {
            case PremiumEconomyPassenger:
                GoToPremiumDesk(passenger);
                break;
            case BusinessPassenger or FirstClassPassenger:
                GoToPriorityDesk(passenger);
                break;
            default:
                GoToOpenDesk(passenger);
                break;
        }
    }

    private void GoToOpenDesk(IPassenger passenger) =>
        _checkInDesks.First(desk => desk.DeskType == CheckinDeskType.Economy).AddToQueue(passenger);

    private void GoToPriorityDesk(IPassenger passenger) =>
        _checkInDesks.First(desk => desk.DeskType == CheckinDeskType.Priority).AddToQueue(passenger);

    private void GoToPremiumDesk(IPassenger passenger) =>
        _checkInDesks.First(desk => desk.DeskType == CheckinDeskType.Premium).AddToQueue(passenger);
}