using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchulzUndWunderbaum_Backend.Models.DrugWars
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int GameMode { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
