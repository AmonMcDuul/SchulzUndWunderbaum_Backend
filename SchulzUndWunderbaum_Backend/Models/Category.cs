namespace SchulzUndWunderbaum_Backend.Models
{
    public class Category
    {
        public long Id { get; set; }
        public string? Name { get; set; }

        public Category(string name)
        {
            this.Name = name;
        }
    }
}
