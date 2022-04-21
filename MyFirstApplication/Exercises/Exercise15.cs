namespace MyFirstApplication;

/*
 This is the class used in Exercise 15. This exercise covers Enums and Tuples.
 */

/*
 1. Above the class, write an enum called Favorite Movies. Add your own favorite
 movies to the enum. Write a method that has a string return type and an enum
 parameter. This enum parameter will be your favorite movie enum. Write a switch
 expression that takes the enum and prints out a string return. Use string
 interpolation in your return message that includes the name of the movie chosen.
 */

public enum FavoriteMovies { Aliens, TheEmpireStrikesBack,
    SchindlersList, GodzillaKingoftheMonsters, BluesBrothers}

internal class Exercise15
{
    public string FavoriteMovieSwitch(FavoriteMovies movie)
    {
        string favorites = movie switch
        {
            FavoriteMovies.Aliens => $"One of my favorite movies is {FavoriteMovies.Aliens}.",
            FavoriteMovies.SchindlersList => $"One of my favorite movies is {FavoriteMovies.SchindlersList}.",
            FavoriteMovies.GodzillaKingoftheMonsters => $"One of my favorite movies is {FavoriteMovies.GodzillaKingoftheMonsters}.",
            FavoriteMovies.BluesBrothers => $"One of my favortie movies is {FavoriteMovies.BluesBrothers}.",
            _ => $"My favorite movie is {FavoriteMovies.TheEmpireStrikesBack}."
        };
        return favorites;
    }
    /*
     2. Write a method that takes an enum parameter. This enum will be your favorite
     movie enum. The method will have a tuple return type(int num, string movie).
     Using an explicit int cast on one of your enum, assign the value to an int
     variable. Create second variable of type string. Assign the same enum value you
     used and use the ToString() at the end of it. Return both variables as a
     tuple.See example below for clarity.
     a. Int value = (int)Enum.Value;
     b.string something = Enum.Value.ToString();
    */

    public (int num, string movie) FavoriteMovieTuple(FavoriteMovies favoriteMovies)
    {
        int num = (int)favoriteMovies;
        string movie = favoriteMovies.ToString();

        return (num, movie);
    }
}
