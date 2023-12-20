using System.Collections.Generic;
using D_UsingApiControllerAttribute.Models;
using Microsoft.AspNetCore.Mvc;

namespace D_UsingApiControllerAttribute.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitController : Controller
    {
        List<string> _fruit = new List<string>
        {
            "Pear", "Lemon", "Peach"
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_fruit);
        }

        [HttpPost]
        public ActionResult Update(UpdateModel model)
        {
            if (model.Id < 0 || model.Id > _fruit.Count)
            {
                return NotFound();
            }

            _fruit[model.Id] = model.Name;
            return Ok();
        }
    }
}
