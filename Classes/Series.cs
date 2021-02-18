namespace dio_series
{
    public class Series:BaseEntity
    {
        private Genre Genre { get; set; }

        private string Title { get; set; }

        private string Description { get; set; }
        private int Year { get; set; }

        private bool IsDeleted { get; set; }

        public Series(int id, Genre genre, string title, string description, int year){
            this.Id=id;
            this.Genre=genre;
            this.Title=title;
            this.Description=description;
            this.Year=year;
            this.IsDeleted=false;
        }

        public override string ToString()
        {
            return $"Genre: {this.Genre}\nTitle: {this.Title}\nDescription: {this.Description}\nYear: {this.Year}"; 
        }

        public string returnTitle(){
            return this.Title;
        }

        public int returnId(){
            return this.Id;
        }

        public bool returnDeleted(){
            return this.IsDeleted;
        }

        public void Delete(){
           this.IsDeleted=!this.IsDeleted;
        }
    }

}