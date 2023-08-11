namespace Airport.Passenger;

public class HoldLuggage : ILuggage
{
    public int WeightInGrams { get; init; }
}

public class CarryOnLuggage : ILuggage
{
    public int WeightInGrams { get; init; }
}

public interface ILuggage
{
    public int WeightInGrams { get; init; }
}