namespace MyFirstApplication;

/*
 This is the Long Boat class that is used in Exercise 11. This class
is a child class of Boat from Exercise 10.
 */

/*
 Create a child class based on your Boat object. Include one child attribute
as an auto property. Create 3 constructors. The first constructor should have
4 parameters with 3 of them from Baot and your child property. Using the
keyword :base(), you will put the four boat parameters in the parenthesis.
In the body of the constructor you will assign your child parameter to your
property. The second constructor should have 2 parameters, 2 based on the boat
and 1 from your child. Using the :this() keyword, you will pass 2 of the parent
attributes and your child attribute information to the first constructor.
Include default values to represent the 2 remaining boat parameters. For the 
last constructor, you will create the default constructor. Using the :this() 
keyword, you will pass 2 default values in that will pass to the 2nd 
constructor. Also include in the class, your method for your child class.
Include 1 child attribute as Expression Body Definition Properties.
*/
internal class LongBoat : Boat
{
    private int _numberOfOars;

    public int NumberOfOars
    {
        get => _numberOfOars;
        set => _numberOfOars = value;
    }

    public LongBoat(int draftDepth, int keelLength, string hullMaterial, int numberOfOars)
        :base(draftDepth, keelLength, hullMaterial)
    {
        NumberOfOars = numberOfOars;
    }

    public LongBoat(int draftDepth, int keelLength)
        :this(draftDepth, keelLength, "Wood", 10)
    { }

    public LongBoat()
        :this(10, 50)
    { }

    public string Row()
    {
        return "The Long Boat has stowed the sail and is now rowing.";
    }
}
