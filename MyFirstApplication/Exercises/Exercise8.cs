namespace MyFirstApplication;

/*
 This is the class that is used in Exercise 8. The exercise will cover
 Constants and Statics. 
*/

internal class Exercise8
{
    /*
     1. Write a constant at the class level. The constant should be Foot
     with a value of 12 to represent the number of inches in a foot. Write a
     method that takes 1 int parameter and a void return type. This method
     will convert feet to inches. The formula that you would use will be
     the parameter * Foot. Your parameter will represent the number of feet
     to convert to inches. Using a ConsoleWriteLine statement, print the results.
     Test your method using the number 3 to see if you get 36.
    */
    public const int Foot = 12;

    public void FeetToInches(int inputFeet)
    {
        int inches = inputFeet * Foot;
        string footOrFeet = "";
        if (inputFeet == 1)
        {
            footOrFeet = "foot";
        }
        else
        {
            footOrFeet = "feet";
        }
        
        Console.WriteLine($"{inputFeet} {footOrFeet} equals {inches} inches.");
    }

    /*
     2. Write a static method that takes 2 int parameters and a void return type.
     This method will be used to calculate the length and width of a rectangle/square.
     This formula is length x width. The first parameter should represent the length
     and the second parameter should be the width. Using a Console WriteLine 
     statement, print the results. Test your method and add what you used to 
     test as a comment either before the method or after.
    */
    public static void AreaOfRectangle(int length, int width)
    {
        int area = length * width;
        string rectangleType = "";
        if (length == width)
        {
            rectangleType = "square";
        }
        else
        {
            rectangleType = "rectangle";
        }

        Console.WriteLine($"A {rectangleType} with length {length} and " +
            $"width {width} has an area of {area}.");
    }

    /*
     To get the square result I used: Exercise8.AreaOfRectangle(4, 4); 
     To get the recatngle result I used: Exercise8.AreaOfRectangle(5, 3);
    */
}
