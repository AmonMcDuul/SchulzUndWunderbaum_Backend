using SchulzUndWunderbaum_Backend.Models.DrugWars;

namespace SchulzUndWunderbaum_Backend.DAL
{
    public static class DrugWarsInitializer
    {
        public static void Initialize(DrugWarsContext context)
        {
            // Look for any students.
            if (context.Player.Any())
            {
                return;   // DB has been seeded
            }

            var players = new List<Player>
            {
            new Player{Name="Carson", GameMode=30, CreationDate=DateTime.Now},
            new Player{Name="Jan-Willem", GameMode=30, CreationDate=DateTime.Now},
            };


            var highScores = new List<HighScore>
            {
            new HighScore{Score=45652, CreationDate=DateTime.Now},
            new HighScore{Score=7654, CreationDate=DateTime.Now},

            };
            context.HighScores.AddRange(highScores);
            context.SaveChanges();
        }
    }
}