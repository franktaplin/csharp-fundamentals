namespace MyFirstApplication;

/*
 This is the class that is to used with Exercise 5. The exercise will cover Expressions
 and Patterns.
 */
public class Exercise5
{
    /*
     1. Write a method that takes 2 int parameters and an int return type.
     Using the formula below from Ohm’s law, determine the voltage.
     The first method parameter will represent current and the second parameter
     will represent resistance. Using the Func<int, int, int> and a lambda expression,
     determine the voltage calculation and return the value.
     a. Voltage = Current x Resistance
    */
    public int OhmsLawExample(int current, int resistance)
    {
        Func<int, int, int> volt = (current, resistance) => current * resistance;
        return volt(current, resistance);
    }
        
    /*
     2. Write a method that will take 1 char parameter and a string return type.
     Using a switch expression and the table below, return the description.
     If the value does not match the grade, return the default message,
     “Not a valid grade”.
     Grade Description
     E     Excellent
     V     Very Good
     G     Good
     A     Average
     F     Fail
    */
    public string GradeResultExample(char grade)
    {
        string result = grade switch
        {
            'E' => "Excellent",
            'V' => "Very Good",
            'G' => "Very Good",
            'A' => "Average",
            'F' => "Fail",
            _ => "Not a valid grade"
        };
        return result;
    }

    /*
     3. Write a method that takes 1 argument and a void return type.
     Using a Relational Pattern and switch expression determine a size
     of popcorn based on the table below and using a Console WriteLine,
     print the popcorn size.
     Size               Size Value
     Less or equal 3    Microwave bag
     Less or equal 16   Movie sack
     Less or equal 32   Movie cup
     Less or equal 64   Movie tub
     Default            We don’t have that size
    */

    public void PopcornSizeExample(int size)
    {
        string popSize = size switch
        {
            <= 3 => "Microwave bag",
            <= 16 => "Movie sack",
            <= 32 => "Movie cup",
            <= 64 => "Movie tub",
            _ => "We don't have that size."
        };
        Console.WriteLine(popSize);
    }
}
