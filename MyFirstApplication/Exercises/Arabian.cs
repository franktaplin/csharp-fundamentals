namespace MyFirstApplication;

/*
 This is the Arabian Horse class that is used in Exercise 11. This class
is a child class of Horse from Exercise 10.
 */

/*
 Create a child class based on your Horse object. Include one child attribute
as an auto property. Create 3 constructors. The first constructor should have
4 parameters with 3 of them from Horse and your child property. Using the
keyword :base(), you will put the four horse parameters in the parenthesis.
In the body of the constructor you will assign your child parameter to your
property. The second constructor should have 2 parameters, 2 based on the horse
and 1 from your child. Using the :this() keyword, you will pass 2 of the parent
attributes and your child attribute information to the first constructor.
Include default values to represent the 2 remaining horse parameters. For the 
last constructor, you will create the default constructor. Using the :this() 
keyword, you will pass 2 default values in that will pass to the 2nd 
constructor. Also include in the class, your method for your child class.
*/
internal class Arabian : Horse
{
    public int ManeLength { get; set; }
    private int _tailLength;

    public int TailLength
    {
        get { return _tailLength; }
        set { _tailLength = value; }
    }

    public Arabian(int weight, int height, string sex, int maneLength)
        :base(weight, height, sex)
    {
        ManeLength = maneLength;
    }

    public Arabian(int weight, int height)
        :this(weight, height, "Female", 24)
    { }

    public Arabian()
        :this(71, 660)
    { }

    public string Trot()
    {
        return "The Arabian Horse is trotting.";
    }
}
