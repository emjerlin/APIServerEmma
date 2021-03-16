using System;
using Microsoft.AspNetCore.Mvc;

namespace APIServer.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController:ControllerBase
    {
        
        [HttpGet]
        public ActionResult Get() {
            return Ok("Hej");
        }
    }
}
