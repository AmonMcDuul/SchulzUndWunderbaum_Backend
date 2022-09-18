using Microsoft.AspNetCore.Mvc;
using SchulzUndWunderbaum_Backend.Models;

namespace SchulzUndWunderbaum_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly ILogger<NotesController> _logger;

        public NotesController(ILogger<NotesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetNotes")]
        public IEnumerable<Note> Get()
        {
            List<Note> list = new List<Note>();
            //var categories = new Category("nieuweCat");
            list.Add(new Note(0, "Note111", "description1", DateTime.Now));
            list.Add(new Note(1, "TweedeNote", "description24242", DateTime.Now));
            list.Add(new Note(2, "SuperNote", "mkonji nji b v db bhsbdsh s", DateTime.Now));
            list.Add(new Note(3, "nootje", "poopelatiepo", DateTime.Now));

            return list;
        }
    }
}