﻿using System.Collections.Generic;
using D_UsingApiControllerAttribute.Models;
using Microsoft.AspNetCore.Mvc;

namespace D_UsingApiControllerAttribute.Controllers
{
    [Route("[controller]")]
    public class NoAttributeController : Controller
    {
        List<string> _fruit = new List<string>
        {
            "Pear", "Lemon", "Peach"
        };

        [HttpGet]
        public ActionResult Update()
        {
            return Ok(_fruit);
        }

        [HttpPost]
        public ActionResult Update([FromBody] UpdateModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ValidationProblemDetails(ModelState));
            }

            if (model.Id < 0 || model.Id > _fruit.Count)
            {
                return NotFound(new ProblemDetails()
                {
                    Status = 404,
                    Title = "Not Found",
                    Type = "https://tools.ietf.org/html/rfc7231#section-6.5.4",
                });
            }

            _fruit[model.Id] = model.Name;

            return Ok();
        }
    }
}
