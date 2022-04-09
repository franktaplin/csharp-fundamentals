namespace MyFirstApplication;

/*
 This is the class that is to be used with Exercise 6. The exercise will cover
 Constructors & Methods 
 */
internal class Exercise6
{
    /*
     1. Write a constructor for your exercise file that takes 2 parameters.
     The first parameter should have an int type and a variable name of showSize.
     The second parameter should have a string type and a variable name of shoeType.
     Create private class variables for these types and use and underscore 
     when defining them. Inside the constructor associate the class variables
     with the constructor parameters.

     2. Write the properties for the class variables defined in exercise 1.
     Ensure they are labeled as public and are spelled using a capital letter.

     3. Write a delegate that takes a string parameter. This delegate should
     be named TryOn. Write a method that takes a string argument and void return
     type. In the method body include a Console WriteLine statement that will
     print the message. Test your delegate in Program.cs to ensure everything
     works properly. Using a mult-line comment on your Exercise6.cs file,
     provide the information you used to test the delegate.
    */

    // delegate for part 3
    public delegate void TryOn(string shoeMessage);

    // private class variables for part 1
    private int _showSize;
    private string _shoeType;

    // properties of variables for part 2
    // properties of _showSize
    public int ShowSize
    {
        get { return _showSize; }
        set { _showSize = value; }
    }

    // properties of _shoeType
    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }

    
    // Constructor for part 1
    public Exercise6(int size, string type)
    {
        _showSize = size;
        _shoeType = type;
    }

    // Method for part 3
    public void ShoeSizeTest(string shoeMessage)
    {
        Console.WriteLine(shoeMessage);
    }

    /*
    Here is what I used to test my delegate:

    Exercise6 myExercise6 = new Exercise6(9, "Hiking Boot");
    Exercise6.TryOn myShoe = myExercise6.ShoeSizeTest;
    myShoe($"I tried on a size {myExercise6.ShowSize} {myExercise6.ShoeType}.");

    The message that printed was "I tried on a size 9 Hiking Boot."
    */
}
