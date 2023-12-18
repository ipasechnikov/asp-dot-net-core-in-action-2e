using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace C_BasicWebApiProject.Controllers
{
    [ApiController]
    public class FruitController : Controller
    {
        private readonly List<string> _fruit = new()
        {
            "Pear",
            "Lemon",
            "Peach"
        };

        [HttpGet("fruit")]
        public IEnumerable<string> Index()
        {
            return _fruit;
        }

        [HttpGet("fruit/{id}")]
        public ActionResult<string> View(int id)
        {
            if (id >= 0 && id <= _fruit.Count)
            {
                return _fruit[id];
            }

            return NotFound();
        }
    }
}
