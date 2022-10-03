using System.ComponentModel.DataAnnotations;

namespace SchulzUndWunderbaum_Backend.Models.DrugWars
{
    public class HighScore
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Player? Player { get; set; }
    }
}
