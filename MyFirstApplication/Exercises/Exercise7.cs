namespace MyFirstApplication;

/*
 These are the struct and record that are used in Exercise 7. The exercise will cover
 Structs and Records 
*/
internal struct Employee
{
    /*
    1. Change the type from class to struct. Change the name of the struct 
    from Exercise7 to Employee. The file name should not be changed.
    Create 2 struct variables. The first one will be of type int and be
    named _id. The second variable should be of type string and be named _name.
    Create a constructor that takes 2 arguments, with the first being an int
    and the second a string. The struct variables should be assigned to the
    constructor parameters. Create properties for these 2 variables. 
    */
    private int _id;
    private string _name;

    public int EmployeeId
    {
        get { return _id; }
        set { _id = value; }
    }
    public string EmployeeName
    {
        get { return _name; }
        set { _name = value; }
    }
    public Employee(int id, string name)
    {
        _id = id;
        _name = name;
    }
}

/*
2. Create a Record based on your Boat object from the Object Oriented
Programming lesson. In your record body, include the boat method that
you defined. This record can be in the same file as exercise 1. Just put
the code under it as seen in the lecture. Test your record to ensure
it is working correctly.
*/

// Voided out because object Boat is used in later lesson.

// public record Boat(int keel, int depth, int length)
// {
    // public void SetSail()
    // {
        // Console.WriteLine("The boat is setting sail");
    // }
// }

    
