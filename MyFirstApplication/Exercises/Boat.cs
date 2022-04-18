namespace MyFirstApplication;

/*
 This is the Boat class for use in Exercise 10 and 12.
 */

/*
 Exercise 10
 Create a class based on your Boat object. Include your attributes as auto
 properties. Create 3 constructors. The first constructor should have parameters
 equal to your properties. Assign each parameter to your properties. The second
 constructor should have 2 parameters. Using the :this() keyword, you will pass
 your information to the first constructor. This includes the 2 parameters and
 default values. For the last constructor, you will create the default
 constructor. Using the :this() keyword, you will pass 2 default valuesin that
 will pass to the 2nd constructor. Also include in the class, your method for Boat.
 Include your attributes as Expression Body Definition Properties.
 */

/*
 Exercise 12
 In your Boat class, add the virtual keyword to your method created in Lesson 10.
 Create a second version of the same method and add a parameter. Include a 
 Console WriteLine method in the new method that uses the parameter. This parameter
 needs to be based on one of your properties.
 */
internal class Boat
{
    private int _draftDepth;
    private int _keelLength;
    private string _hullMaterial;

    public int DraftDepth
    {
        get => _draftDepth;
        set => _draftDepth = value;
    }

    public int KeelLength
    {
        get => _keelLength;
        set => _keelLength = value;
    }

    public string HullMaterial
    {
        get => _hullMaterial;
        set => _hullMaterial = value;
    }
    public Boat(int draftDepth, int keelLength, string hullMaterial)
    {
        DraftDepth = draftDepth;
        KeelLength = keelLength;
        HullMaterial = hullMaterial;
    }

    public Boat(int draftDepth, int keelLength)
        : this(draftDepth, keelLength, "Fiberglass")
    { }

    public Boat()
        : this(5, 25)
    { }

    public virtual void SetSail()
    {
        Console.WriteLine("The boat is setting sail.");
    }

    public void SetSail(string hullMaterial)
    {
        Console.WriteLine($"The boat\'s hull is made from {hullMaterial}.");
    }
}
