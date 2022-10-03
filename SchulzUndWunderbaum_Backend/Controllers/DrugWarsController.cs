using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchulzUndWunderbaum_Backend.DAL;
using SchulzUndWunderbaum_Backend.Models.DrugWars;

namespace SchulzUndWunderbaum_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DrugWarsController : ControllerBase
    {
        private readonly DrugWarsContext _context;

        public DrugWarsController(DrugWarsContext context)
        {
            _context = context;
        }

        // GET: api/DrugWars
        [HttpGet("Player")]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayer()
        {
            return await _context.Players.ToListAsync();
        }

        // GET: api/DrugWars/5
        [HttpGet("Player/{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = await _context.Players.FindAsync(id);

            if (player == null)
            {
                return NotFound();
            }

            return player;
        }

        // PUT: api/DrugWars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("Player/{id}")]
        public async Task<IActionResult> PutPlayer(int id, Player player)
        {
            if (id != player.Id)
            {
                return BadRequest();
            }

            _context.Entry(player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DrugWars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("Player")]
        public async Task<ActionResult<Player>> PostPlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayer", new { id = player.Id }, player);
        }

        // DELETE: api/DrugWars/5
        [HttpDelete("Player/{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerExists(int id)
        {
            return _context.Players.Any(e => e.Id == id);
        }

        // GET: api/HighScores
        [HttpGet("HighScores")]
        public async Task<ActionResult<IEnumerable<HighScore>>> GetHighScores()
        {
            return await _context.HighScores.ToListAsync();
        }

        //// GET: api/HighScores/5
        //[HttpGet("api/DrugWars/HighScores/{id}")]
        //public async Task<ActionResult<HighScore>> GetHighScore(int id)
        //{
        //    var highScore = await _context.HighScores.FindAsync(id);

        //    if (highScore == null)
        //    {
        //        return NotFound();
        //    }

        //    return highScore;
        //}

        //// PUT: api/HighScores/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("api/DrugWars/HighScores/{id}")]
        //public async Task<IActionResult> PutHighScore(int id, HighScore highScore)
        //{
        //    if (id != highScore.ID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(highScore).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!HighScoreExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/HighScores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("HighScores")]
        public async Task<ActionResult<HighScore>> PostHighScore(HighScore highScore)
        {
            _context.HighScores.Add(highScore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHighScore", new { id = highScore.Id }, highScore);
        }

        //// DELETE: api/HighScores/5
        //[HttpDelete("api/DrugWars/HighScores/{id}")]
        //public async Task<IActionResult> DeleteHighScore(int id)
        //{
        //    var highScore = await _context.HighScores.FindAsync(id);
        //    if (highScore == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.HighScores.Remove(highScore);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool HighScoreExists(int id)
        {
            return _context.HighScores.Any(e => e.Id == id);
        }

        [HttpGet("Drugs")]
        public async Task<ActionResult<IEnumerable<Drug>>> GetDrugs()
        {
            return await _context.Drugs.ToListAsync();
        }

    }
}
