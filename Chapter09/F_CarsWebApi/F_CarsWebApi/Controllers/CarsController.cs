using F_CarsWebApi.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace F_CarsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        /// <summary>
        /// This represents the global application model that would
        /// normally be stored in a database etc
        /// </summary>
        private static List<Car> Cars = new List<Car> { };

        string _carsAsXml = "<cars><car>Nissan Micra</car><car>FordFocus</car></cars>";

        [HttpGet("start")]
        [HttpGet("ignition")]
        [HttpGet("/start-car")]
        public IEnumerable<string> ListCars()
        {
            return new string[]
            {
                "Nissan Micra",
                "FordFocus",
            };
        }

        [HttpGet("null")]
        public IActionResult Null()
        {
            return Ok(null);
        }

        [HttpGet("content")]
        public string ListCarsAsContent()
        {
            return _carsAsXml;
        }

        [HttpGet("xml")]
        public IActionResult ListCarsAsXml()
        {
            return Content(_carsAsXml, "text/xml");
        }

        [HttpGet("json")]
        public IActionResult ListCarsAsJson()
        {
            return Json(new string[]
            {
                "Nissan Micra",
                "FordFocus",
            });
        }

        [HttpPost]
        public IActionResult Add(Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Cars.Add(car);
            return Ok();
        }
    }
}
