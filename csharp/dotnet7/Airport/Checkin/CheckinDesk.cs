using Airport.Passenger;
using AirportTests;

namespace Airport.Checkin;

public class CheckinDesk
{
    public CheckinDesk(CheckinDeskType deskType)
    {
        DeskType = deskType;
    }

    public IList<IPassenger> PassengerQueue { get; init; } = new List<IPassenger>();

    public CheckinDeskType DeskType { get; init; }

    public void AddToQueue(IPassenger passenger)
    {
        PassengerQueue.Add(passenger);
    }

    public void CheckIn()
    {
        foreach (var passenger in PassengerQueue)
        {
            if (CheckinLuggageRules.PassengerHoldLuggageWeightExceeded(passenger))
            {
                //Passenger is not checked in
                return;
            }

            if (passenger is BusinessPassenger or FirstClassPassenger)
            {
                DepartureLounge.PremiumLounge.Passengers.Add(passenger);
                continue;
            }

            DepartureLounge.SharedLounge.Passengers.Add(passenger);
        }
    }
}