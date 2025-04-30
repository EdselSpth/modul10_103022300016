namespace modul10_103022300016
{
    public class Movie
    {
        // Getter Setter semua objek
        public string Title { get; set; }
        public string Director { get; set; }
        public string[] Stars { get; set; }
        public string Description { get; set; }

        // Constructor Movie
        public Movie(string title, string director, string[] stars, string description)
        {
            Title = title;
            Director = director;
            Stars = stars;
            Description = description;
        }

    }
}
