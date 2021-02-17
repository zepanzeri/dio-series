namespace dio_series
{
    public class Series:BaseEntity
    {
        private Genre Genre { get; set; }

        private string Title { get; set; }

        private string Description { get; set; }
        private int Year { get; set; }
    }
}