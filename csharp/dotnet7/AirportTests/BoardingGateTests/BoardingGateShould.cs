using Airport;
using Airport.Passenger;
using Airport.BoardingGate;

namespace AirportTests.BoardingGateTests;

public class BoardingGateShould
{
    [Test]
    public void Not_allow_boarding_until_the_flight_is_ready()
    {
        Flight flight = new();
        BoardingGate gate = new(flight);
        gate.AddPassenger(new FirstClassPassenger());
        gate.BoardPassengers();
        Assert.That(flight.Passengers, Is.Empty);
    }

    [Test]
    public void Allow_boarding_first_class_passengers_first()
    {
        Flight flight = new();
        BoardingGate gate = new(flight);
        var firstClassPassenger = new FirstClassPassenger();
        gate.AddPassenger(firstClassPassenger);
        gate.AllowBoarding();
        gate.BoardPassengers();
        CollectionAssert.Contains(flight.Passengers, firstClassPassenger);
    }

    [Test]
    public void Not_allow_boarding_economy_passengers_while_priority_class_passengers_are_boarding()
    {
        Flight flight = new();
        BoardingGate gate = new(flight);
        var firstClassPassenger = new FirstClassPassenger();
        var economyPassenger = new EconomyPassenger();
        var businessPassenger = new BusinessPassenger();
        
        gate.AddPassenger(economyPassenger);
        gate.AddPassenger(firstClassPassenger);
        gate.AddPassenger(new EconomyPassenger());
        gate.AddPassenger(businessPassenger);
        
        gate.AllowBoarding();
        gate.BoardPassengers();
        Assert.Multiple(() =>
        {
            CollectionAssert.Contains(flight.Passengers, firstClassPassenger, "First Class passenger can board");
            CollectionAssert.Contains(flight.Passengers, businessPassenger, "Business passenger can board");
            CollectionAssert.DoesNotContain(flight.Passengers, economyPassenger);
        });
    }

    [Test]
    public void Not_allow_boarding_premium_economy_passengers_while_priority_class_passengers_are_boarding()
    {
        Flight flight = new();
        BoardingGate gate = new(flight);
        var firstClassPassenger = new FirstClassPassenger();
        var premiumEconomyPassenger = new PremiumEconomyPassenger();
        var businessPassenger = new BusinessPassenger();
        var economyPassenger = new EconomyPassenger();
        
        gate.AddPassenger(premiumEconomyPassenger);
        gate.AddPassenger(firstClassPassenger);
        gate.AddPassenger(economyPassenger);
        gate.AddPassenger(businessPassenger);
        
        gate.AllowBoarding();
        gate.BoardPassengers();
        Assert.Multiple(() =>
        {
            CollectionAssert.Contains(flight.Passengers, firstClassPassenger, "First Class passenger can board");
            CollectionAssert.Contains(flight.Passengers, businessPassenger, "Business passenger can board");
            CollectionAssert.DoesNotContain(flight.Passengers, premiumEconomyPassenger);
            CollectionAssert.DoesNotContain(flight.Passengers, economyPassenger);
        });
    }
    
    [Test]
    public void Allow_boarding_premium_economy_passengers_after_priority_class_passengers_are_boarded()
    {
        Flight flight = new();
        BoardingGate gate = new(flight);
        var firstClassPassenger = new FirstClassPassenger();
        var premiumEconomyPassenger = new PremiumEconomyPassenger();
        var businessPassenger = new BusinessPassenger();
        var economyPassenger = new EconomyPassenger();
        
        gate.AddPassenger(premiumEconomyPassenger);
        gate.AddPassenger(firstClassPassenger);
        gate.AddPassenger(economyPassenger);
        gate.AddPassenger(businessPassenger);
        
        gate.AllowBoarding();
        //First Class
        gate.BoardPassengers();
        Assert.Multiple(() =>
        {
            CollectionAssert.DoesNotContain(flight.Passengers, premiumEconomyPassenger);
            CollectionAssert.DoesNotContain(flight.Passengers, economyPassenger);
        });
        //Premium
        gate.BoardPassengers();
        
        Assert.Multiple(() =>
        {
            CollectionAssert.Contains(flight.Passengers, premiumEconomyPassenger);
            CollectionAssert.DoesNotContain(flight.Passengers, economyPassenger, "Economy passenger should not be allowed to board yet");
        });
    }

    [Test]
    public void Allow_economy_passengers_to_board_after_other_passengers()
    {
        
        Flight flight = new();
        BoardingGate gate = new(flight);
        var firstClassPassenger1 = new FirstClassPassenger();
        var economyPassenger = new EconomyPassenger();
        var businessPassenger = new BusinessPassenger();
        var premiumEconomyPassenger = new PremiumEconomyPassenger();
        
        gate.AddPassenger(economyPassenger);
        gate.AddPassenger(firstClassPassenger1);
        gate.AddPassenger(premiumEconomyPassenger);
        gate.AddPassenger(businessPassenger);
        
        gate.AllowBoarding();
        //First Class and business class
        gate.BoardPassengers();
        //Premium Economy
        gate.BoardPassengers();
        
        Assert.That(flight.Passengers.OfType<EconomyPassenger>().Any, Is.False, "Economy passengers are not allowed to board yet");
        
        //Anyone can board
        gate.BoardPassengers();
        
        CollectionAssert.Contains(flight.Passengers, economyPassenger);
    }
}