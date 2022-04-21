namespace MyFirstApplication;
/*
 This is the class used in Exercise 16. It covers Collections.
 */

internal class Exercise16
{
    /*
     1. Write a method that has no parameters and a no return type.
     Create a List<T> of your Horse objects. When creating your list,
     utilize all the constructors you created with your Horse class.
     Using a foreach loop, print out the results of your collection
     using a Console WriteLine statement.
    */
    public void HorseList()
    {
        List<Horse> list = new List<Horse>();
        list.Add(new Horse());
        list.Add(new Horse(660, 75, "Male"));
        list.Add(new Horse(650, 70));

        foreach (Horse constructor in list)
        {
            Console.WriteLine(constructor.Height);
            Console.WriteLine(constructor.Weight);
            Console.WriteLine(constructor.Sex);
        }
    }

    /*
     2. Write a method that has no parameters and no return type. Using only
     the data you used when building your favorite movies from exercise 15,
     create a Dictionary collection that takes an int key and string value.
     When adding Dictionary elements, pick an int value as the key and use the
     favorite movies data as the string. Using a foreach loop, print out the
     results of your collection using a Console WriteLine statement.
    */
    public void FavoriteMovieDict()
    {
        Dictionary<int, string> movies = new Dictionary<int, string>();
        movies.Add(1, "The Empire Strikes Back");
        movies.Add(2, "Aliens");
        movies.Add(3, "Godzilla: King of the Monsters");
        movies.Add(4, "Blues Brothers");
        movies.Add(5, "Schindler\'s List");

        foreach (KeyValuePair<int, string> item in movies)
        {
            Console.WriteLine($"My  #{item.Key} movie is {item.Value}.");
        }
    }

}
