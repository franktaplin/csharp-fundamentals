namespace MyFirstApplication;

/*
 This is the class that is to used with Exercise 2. The exercise will cover strings and
 learning to use the keywords asociated with them.
 */
public class Exercise2
{

    /*
    1. Write a method that takes a string argument and returns a void type. Using string
    concatenation and string methods write a Console Writeln statement for each of them.
    Inside the string concatenation will be the name of each string method. Use the 
    string " EXERCISE two Lab " to test the method.
    a. Trim()
    b. ToLower()
    c. Contains("tow")
    d. Length()
    e. Indexof('C') 
     */
    public void StringConcatenationExercise(string concatenationValue)
    {
        string myString = concatenationValue;
        Console.WriteLine("Trim() = " + myString.Trim());
        Console.WriteLine("ToLower() = " + myString.ToLower());
        Console.WriteLine("Contains(\"tow\") = " + myString.Contains("tow"));
        Console.WriteLine("Length() = " + myString.Length);
        Console.WriteLine("Indexof('C') = " + myString.IndexOf('C'));
    }

    /*
     2. Write a method with no arguments and a void return type. Using Unicode assign 
     Unicode value of the Pilcrow Sign to a variable. Use Console Writeline to print
     the variable. The variable should be of the type that takes 1 character.
     */
    public void UnicodeExample()
    {
        char pilcrowSign = '\u00B6';
        Console.WriteLine(pilcrowSign);
    }

    /*
     3. Write a method with no argumanets and a void return. Use 1 string variable and
     1 Console WriteLine. Use escape sequences to achieve this result:
     Output:
     Jack and Jill
     went up the hill
     to fetch a pail of water.
     Jack fell down and broke his crown
     and Jill came tumbling after.
     */
    public void EscapeSequenceExample()
    {
        string myEscapeSequence = ("Jack and Jill \nwent up the hill \nto fetch a pail of water. \nJack fell down and broke his crown \nand Jill came tumbling after.");
        Console.WriteLine(myEscapeSequence);
    }

    /*
     4. Write a method with no arguments and a string return type. Use Interpolation
    to accomplish this. Create variables for the following data. Return a string that 
    includes the variables in a sentence.
    a. Name
    b. Favorite movie
    c. Favorite movie snack
    d. Favorite movie drink
     */
    public string InterpolationMovieExample()
    {
        string myName = "Frank Taplin";
        string myFavoriteMovie = "The Empire Strikes Back";
        string MyFavoriteMovieSnack = "popcorn";
        string myFavoriteMovieDrink = "Dr. Pepper";

        return $"My name is {myName} and my favorite movie is {myFavoriteMovie}. \nWhen I go to a movie my favorite snack is {MyFavoriteMovieSnack} and my favorite drink is {myFavoriteMovieDrink}.";
    }
}

