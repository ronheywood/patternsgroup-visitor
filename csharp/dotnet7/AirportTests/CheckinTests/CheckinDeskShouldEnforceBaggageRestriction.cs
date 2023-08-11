using Airport.Checkin;
using Airport.Passenger;

namespace AirportTests.CheckinTests;

public class CheckinDeskShouldEnforceBaggageRestriction
{
    private readonly CheckinDesk _checkinDesk = new(CheckinDeskType.Economy);

    [TestCaseSource(nameof(CheckinPassengers))]
    public void Restrict_passengers_to_checked_in_baggage_allowance_in_kilograms(IPassenger passenger, int expectedAllowance, DepartureLounge expectedDepartureLounge)
    {
        var luggageOverWeight = new HoldLuggage{WeightInGrams = expectedAllowance + 1};
        passenger.Baggage.Add(luggageOverWeight);

        _checkinDesk.AddToQueue(passenger);
        _checkinDesk.CheckIn();
        Assert.Multiple(() =>
        {
            CollectionAssert.DoesNotContain(expectedDepartureLounge.Passengers, passenger,$"Passenger with baggage weight {expectedAllowance +1} should not be checked in");
            
        });
    }

    [TestCaseSource(nameof(CheckinPassengers))]
    public void Allow_passengers_to_check_in_baggage_up_to_the_allowance(IPassenger passenger, int expectedAllowance, DepartureLounge expectedDepartureLounge)
    {
        int weight = TestContext.CurrentContext.Random.Next(0, expectedAllowance+1);
        
        var holdLuggage = new HoldLuggage{WeightInGrams = weight};
        passenger.Baggage.Add(holdLuggage);
        
        var desk = new CheckinDesk(CheckinDeskType.Economy);
        desk.AddToQueue(passenger);
        desk.CheckIn();
        
         CollectionAssert.Contains(expectedDepartureLounge.Passengers, passenger,$"Passenger with luggage weight of {weight} <= {expectedAllowance} should be checked in");
        
    }
    
    [TestCaseSource(nameof(CheckinPassengers))]
    public void Allow_passengers_to_carry_on_baggage_and_include_hold_baggage(IPassenger passenger, int expectedAllowance, DepartureLounge expectedDepartureLounge)
    {   
        int weight = TestContext.CurrentContext.Random.Next(1, expectedAllowance);
        var holdLuggage = new HoldLuggage{WeightInGrams = weight};
        passenger.Baggage.Add(holdLuggage);
        var carryOnBag = new CarryOnLuggage{WeightInGrams = expectedAllowance};
        passenger.Baggage.Add(carryOnBag);
        
        var desk = new CheckinDesk(CheckinDeskType.Economy);
        desk.AddToQueue(passenger);
        desk.CheckIn();
        
        CollectionAssert.Contains(expectedDepartureLounge.Passengers, passenger, $"Passenger with baggage {weight} below allowance {expectedAllowance} should go to the departure lounge");
    }

    private static IEnumerable<object[]> CheckinPassengers()
    {
        yield return new object[] {  new EconomyPassenger(), 20000, DepartureLounge.SharedLounge };
        yield return new object[] {  new PremiumEconomyPassenger(), 30000, DepartureLounge.SharedLounge };
        yield return new object[] {  new BusinessPassenger(), 50000, DepartureLounge.PremiumLounge };
        yield return new object[] {  new FirstClassPassenger(), 50000, DepartureLounge.PremiumLounge };
    }
}