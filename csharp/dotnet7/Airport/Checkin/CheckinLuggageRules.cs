using Airport.Passenger;

namespace Airport.Checkin;

internal class CheckinLuggageRules
{
    public static bool PassengerHoldLuggageWeightExceeded(IPassenger passenger)
    {
        return passenger.Baggage.OfType<HoldLuggage>().Sum(b => b.WeightInGrams) > MaximumLuggageForPassenger(passenger);
    }
    
    private static int MaximumLuggageForPassenger(IPassenger passenger)
    {
        return passenger switch
        {
            FirstClassPassenger => 50000,
            BusinessPassenger => 50000,
            PremiumEconomyPassenger => 30000,
            EconomyPassenger => 20000,
            _ => 20000
        };
    }
}