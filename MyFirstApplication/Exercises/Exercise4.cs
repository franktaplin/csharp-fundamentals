
namespace MyFirstApplication;

/*
 This is the class that is to used with Exercise 4. The exercise will cover Control Flow
 statements and how to use them.
 */
public class Exercise4
{
    /*
     1. Write a method that takes 2 string arguments and a void return type.
     Using an if-else statement, compare the two strings to each other.
     Using a Console WriteLine statement, print out the results of whether
     the strings are equal. Provide a comment inside the method that says
     what strings you used during testing.
    */
    public void IfElseExample(string string1, string string2)
    {
        Console.WriteLine($"Comparing {string1} and {string2}");
        if (string1 == string2)
        {
            Console.WriteLine("The two strings are equal.");
        }
        else
        {
            Console.WriteLine("The two strings are not equal.");
        }
        /*
         To test the if portion I used the strings "Have a nice day" and "Have a nice day".
         To test the else portion I used the strings "Have a nice day and "See ya"
        */
    }

    /*
     2. Write a method that will take 1 char argument and a string return type.
     Using a switch and the table below, return the description. If the value does
     not match the grade, return the default message, “Not a valid grade”.
     Grade Description
     E     Excellent
     V     Very Good
     G     Good
     A     Average
     F     Fail
    */

   
    public string SwitchExample(char grade)
    {
        switch(grade)
        {
            case 'E':
                return"Excellent";
            case 'V':
                return"Very Good";
            case 'G':
                return"Good";
            case 'A':
                return"Average";
            case 'F':
                return"Fail";
            default:
                return"Not a valid grade.";
        }
    }
    
    /*
     3. Write a method that takes no arguments and a void return type.
     Using an iteration statement, display all the numbers divisible by 3 from 0 to 30.
     Utilize a modulus to obtain your results.
    */
    public void IterationLoopExample()
    {
        int count = 0;
        while (count < 31)
        {
            if ((count % 3) == 0)
            {
                Console.WriteLine(count);
            }
            count++;
        }
    }
}