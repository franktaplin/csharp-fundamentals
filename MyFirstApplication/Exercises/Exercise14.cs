namespace MyFirstApplication;

/*
 This is the class used in Exercise 14. The exercise is about Arrays.
 */
internal class Exercise14
{
    /*
     1. Write a method with no parameters and no return type. Write a single
     dimensional string array of ice cream flavors. Using a foreach loop in
     your method, print out the results of your array using
     a Console WriteLine statement.
     */
    public void IceCreamArray()
    {
        string[] flavorArray = new string[5];
        flavorArray[0] = "Rocky Road";
        flavorArray[1] = "Chocolate Chip";
        flavorArray[2] = "Vanilla";
        flavorArray[3] = "Strawberry";
        flavorArray[4] = "Cookie Dough";

        foreach(string flavor in flavorArray)
        {
            Console.WriteLine($"{flavor} is a flavor of ice cream we have.");
        }
    }

    /*
     2. Write a method with no parameters and no return type. Write a 
     two-dimensional array using the int data type. Fill in each dimension
     with the KC Chiefs Regular season scores. The first dimension will be
     the home team, while the second dimension will be the away team. Using
     a foreach loop, print out the results of your array using a
     Console WriteLine statement.
     */
    public void ChiefsScoresArray()
    {
        int[,] chiefsScoresArray = { { 34, 20 }, { 20, 23 }, { 20, 34 }, { 25, 10 },
            { 32, 40 }, { 17, 26 }, { 16, 43 }, { 35, 9 }, { 33, 31 }, { 31, 35 },
            { 24, 27 }, { 22, 16 }, { 27, 33 }, { 29, 32 }, { 17, 14 }, { 21, 38 } };

        foreach (int score in chiefsScoresArray)
        {
            Console.WriteLine(score);
        }
    }
}
