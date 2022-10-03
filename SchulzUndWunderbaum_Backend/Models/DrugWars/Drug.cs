using System.ComponentModel.DataAnnotations;
namespace SchulzUndWunderbaum_Backend.Models.DrugWars
{
    public class Drug
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BasePrice { get; set; }
    }
}