using System.ComponentModel.DataAnnotations;

namespace SchulzUndWunderbaum_Backend.Models.DrugWars
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Place { get; set; }
    }
}
