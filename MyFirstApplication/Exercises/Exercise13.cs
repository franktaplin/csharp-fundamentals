namespace MyFirstApplication;

/*
 These are the interface and classes that are used with Exercise 13.
They cover Abstraction and interfaces.
 */


/*
 1. In your Exercise13.cs file, change your class to an Interface and
 name it IMovement. This interface will have 1 property. The property will
 an int and called Speed. It will have a get and init.
 */
public interface Imovement
{
    int Speed { get; init; }
}

/*
 2. Under the interface you will create an Abstract class called WaterBirds.
 This abstract class will implement the IMovement interface. The interface
 property should be implemented in the Abstract class as an abstract property.
 Create two abstract methods for the abstract class that is related to WaterBirds.
 Create a constructor that will take an int parameter and be assigned
 to the Speed property.
 */
public abstract class WaterBirds : Imovement
{
    public abstract int Speed { get; init; }

    public WaterBirds(int speed)
    {
        Speed = speed;
    }

    public abstract void FlightSpeed();
    public abstract string BirdName();

}


/*
 3. Under the Abstract class Waterbirds, create a derived class that will extend
 the WaterBird class. Implement the abstract methods and property.
 Use Console Writeline statements in your methods that provide information
 related to the methods. One of them should use an Interpolation string and
 consume the Speed property. Create a constructor that will take an int parameter
 and use the :base() to pass that int value back to the base Abstract class.
*/
public class WaterBirdsDerived : WaterBirds
{
    public override int Speed { get; init; }
    public string birdType { get; init; } = "Great Blue Heron";

    public WaterBirdsDerived(int speed)
        :base(speed)
    { }

    public override void FlightSpeed()
    {
        Console.WriteLine($"The {birdType} flies at {Speed} mph.");
    }

    public override string BirdName()
    {
        return $"That is a {birdType}.";
    }
}