namespace MovieDatabaseLab
{
    public static class MoviesList
    {
        public static List<Movie> Movies = InitializeMoviesList();

        public static List<Movie> InitializeMoviesList()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Alvin and the Chipmunks", "G", "Animated"));
            movies.Add(new Movie("StarTrek", "PG13", "SciFi"));
            movies.Add(new Movie("StarWars: Episode I", "R", "SciFi"));
            movies.Add(new Movie("Halloween", "R", "Horror"));
            movies.Add(new Movie("StarWars: Episode III", "R", "SciFi"));
            movies.Add(new Movie("Scream", "R", "Horror"));
            movies.Add(new Movie("Baby Momma", "R", "Drama"));
            movies.Add(new Movie("StarWars: Episode II", "R", "SciFi"));
            movies.Add(new Movie("Alvin and the Chipmunks:Shipwrecked", "G", "Animated"));
            movies.Add(new Movie("Sisterhood of the Travelling Pants", "PG13", "Drama"));

            return movies;
        }

        public static void DisplayMovieTable()
        {
            int longestMovieTitle = Movies.Max(x => x.Title.Length);

            Movies.OrderBy(x => x.Title)
                  .ToList()
                  .ForEach(x => Console.WriteLine(string.Format("{0, -" + longestMovieTitle + "} | {1, -4} | {2,-8}", x.Title, x.Rating, x.Category)));

            Console.WriteLine();
        }

        public static void DisplayMovieTableByCategory(string category)
        {
            int longestMovieTitle = Movies.Where(x => x.Category.ToLower() == category).Max(x => x.Title.Length);

            Movies.Where(x => x.Category.ToLower() == category)
                  .OrderBy(x => x.Title)
                  .ToList()
                  .ForEach(x => Console.WriteLine(string.Format("{0, -" + longestMovieTitle + "} | {1, -4} | {2,-8}", x.Title, x.Rating, x.Category)));

            Console.WriteLine();
        }
    }
}
