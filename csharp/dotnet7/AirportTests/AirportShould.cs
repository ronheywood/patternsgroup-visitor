using Airport;
using Airport.Checkin;
using Airport.Passenger;

namespace AirportTests;

public class AirportShould
{
    private Airport.Airport _airport = null!;
    
    private CheckinDesk _economyCheckInDesk = null!;
    private CheckinDesk _premiumEconomyCheckInDesk = null!;
    private CheckinDesk _priorityCheckInDesk = null!;
    private readonly EconomyPassenger _economyPassenger = new();
    private readonly PremiumEconomyPassenger _premiumEconomyPassenger = new();
    private readonly BusinessPassenger _businessClassPassenger = new();
    private readonly FirstClassPassenger _firstClassPassenger = new();
    
    [SetUp]
    public void SetUp()
    {
        _economyCheckInDesk = new CheckinDesk(CheckinDeskType.Economy);
        _premiumEconomyCheckInDesk = new CheckinDesk(CheckinDeskType.Premium);
        _priorityCheckInDesk = new CheckinDesk(CheckinDeskType.Priority);
        IEnumerable<CheckinDesk> airlineCheckingDesks = new List<CheckinDesk> { _economyCheckInDesk, _premiumEconomyCheckInDesk, _priorityCheckInDesk };
        _airport = new Airport.Airport(airlineCheckingDesks);
    }
    
    [Test]
    public void DirectPassengersToEconomyCheckinQueue()
    {
        _airport.AddPassenger(_economyPassenger);
        Assert.Multiple(() =>
        {
            Assert.That(_priorityCheckInDesk.PassengerQueue, Is.Empty);
            Assert.That(_premiumEconomyCheckInDesk.PassengerQueue, Is.Empty);
            CollectionAssert.Contains(_economyCheckInDesk.PassengerQueue, _economyPassenger);
        });
    }

    [Test]
    public void DirectPassengersToPremiumEconomyCheckinQueue()
    {
        _airport.AddPassenger(_premiumEconomyPassenger);
        Assert.Multiple(() =>
        {
            Assert.That(_economyCheckInDesk.PassengerQueue, Is.Empty);
            Assert.That(_priorityCheckInDesk.PassengerQueue, Is.Empty);
            CollectionAssert.Contains(_premiumEconomyCheckInDesk.PassengerQueue, _premiumEconomyPassenger);
        });
    }

    [Test]
    public void DirectPassengersToExpressCheckinQueue()
    {
        _airport.AddPassenger(_businessClassPassenger);
        _airport.AddPassenger(_firstClassPassenger);
        Assert.Multiple(() =>
        {
            Assert.That(_economyCheckInDesk.PassengerQueue, Is.Empty);
            Assert.That(_premiumEconomyCheckInDesk.PassengerQueue, Is.Empty);
            CollectionAssert.Contains(_priorityCheckInDesk.PassengerQueue, _businessClassPassenger);
            CollectionAssert.Contains(_priorityCheckInDesk.PassengerQueue, _firstClassPassenger);
        });
    }
}