namespace MovieDatabaseLab
{
    public class Movie
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Category { get; set; }

        public Movie(string title, string rating, string category)
        {
            Title = title;
            Rating = rating;
            Category = category;
        }
    }
}
