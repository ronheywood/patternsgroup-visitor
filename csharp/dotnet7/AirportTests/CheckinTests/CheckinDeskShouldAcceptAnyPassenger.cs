using Airport.Checkin;
using Airport.Passenger;

namespace AirportTests.CheckinTests;

/// <summary>
/// An economy passenger may still be processed at the first class desk,
/// when the first class queue is empty
/// </summary>
[TestFixture(CheckinDeskType.Economy)]
[TestFixture(CheckinDeskType.Priority)]
[TestFixture(CheckinDeskType.Premium)]
public class CheckinDeskShouldAcceptAnyPassenger
{
    private readonly CheckinDeskType _checkinDeskType;
    private readonly EconomyPassenger _economyPassenger = new();
    private readonly PremiumEconomyPassenger _premiumEconomyPassenger = new();
    private readonly BusinessPassenger _businessPassenger = new();
    private readonly FirstClassPassenger _firstClassPassenger = new();
    
    public CheckinDeskShouldAcceptAnyPassenger(CheckinDeskType checkinDeskType)
    {
        _checkinDeskType = checkinDeskType;
    }
    
    [SetUp]
    public void SetUp()
    {
        var checkInDesk = new CheckinDesk(_checkinDeskType);
        checkInDesk.AddToQueue(_economyPassenger);
        checkInDesk.AddToQueue(_premiumEconomyPassenger);
        checkInDesk.AddToQueue(_businessPassenger);
        checkInDesk.AddToQueue(_firstClassPassenger);
        checkInDesk.CheckIn();
    }
    
    [Test]
    public void Send_economy_passengers_to_shared_departure_lounge()
    {
        var departureLounge = DepartureLounge.SharedLounge;
        CollectionAssert.Contains(departureLounge.Passengers, _economyPassenger);
    }
    
    [Test]
    public void Send_premium_economy_passengers_to_shared_departure_lounge()
    {
        var departureLounge = DepartureLounge.SharedLounge;
        CollectionAssert.Contains(departureLounge.Passengers, _premiumEconomyPassenger);
    }
    
    [Test]
    public void Send_business_passengers_to_premium_departure_lounge()
    {   
        var premiumLounge = DepartureLounge.PremiumLounge;
        CollectionAssert.Contains(premiumLounge.Passengers, _businessPassenger);
    }
    
    [Test]
    public void Send_first_class_passengers_to_premium_departure_lounge()
    {   
        var premiumLounge = DepartureLounge.PremiumLounge;
        CollectionAssert.Contains(premiumLounge.Passengers, _firstClassPassenger);
    }
}