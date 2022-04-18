namespace MyFirstApplication;

/*
 This class represents the horse class used in exercise 10 and exercise 12.
 */

/*
 Exercise 10
 Create a class based on your Horse object. Include your attributes as auto
 properties. Create 3 constructors. The first constructor should have
 parameters equal to your properties. Assign each parameter to your properties.
 The second constructor should have 2 parameters. Using the :this() keyword,
 you will pass your information to the first constructor. This includes the
 2 parameters and default values. For the last constructor, you will create
 the default constructor. Using the :this()keyword, you will pass 2 default
 values in that will pass to the 2nd constructor. Also include in the class,
 your method for Horse.
 */

/*
 Exercise 12
 In your Horse class, add the virtual keyword to your method created in Lesson 10.
 Create a second version of the same method and add a parameter. Include a
 Console WriteLine method in the new method that uses the parameter. This
 parameter needs to be based on one of your properties.
 */
internal class Horse
{
    public int Weight { get; set; }
    public int Height { get; set; }
    public string Sex { get; set; }

    public Horse (int weight, int height, string sex)
    {
        Weight = weight;
        Height = height;
        Sex = sex;
    }

    public Horse(int Weight, int Height)
        : this(Weight, Height, "Male")
    { }

    public Horse()
        : this(650, 70)
    { }

    public virtual void Gallop()
    {
        Console.WriteLine("The horse is galloping.");
    }

    public void Gallop(int weight)
    {
        Console.WriteLine($"The horse weighs {weight} pounds.");
    }
}
