namespace SchulzUndWunderbaum_Backend.Models

{
    public class Note
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        //public Category? Categories { get; set; }
        public DateTime? Date { get; set; }

        public Note(long id, string name, string description, DateTime date)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            //this.Categories = categorie;
            this.Date = date;
        }
    }

}
