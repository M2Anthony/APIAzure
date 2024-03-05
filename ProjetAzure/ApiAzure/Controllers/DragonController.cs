using ApiAzure.Data;
using ApiAzure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DragonController : ControllerBase
    {
        private readonly FakeDragonDb _fakeDragonDb;

        public DragonController(FakeDragonDb fakeDragonDb)
        {
            _fakeDragonDb = fakeDragonDb;
        }


        [HttpPost]
        public IActionResult Post(Dragon dragonAAjouter)
        {
            return Ok(_fakeDragonDb.Ajouter(dragonAAjouter));
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_fakeDragonDb.ObtenirTous());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(_fakeDragonDb.ObtenirViaId(id));
        }

        [HttpPut("id")]
        public IActionResult Put(Dragon dragonAModifier, int id)
        {
            return Ok(_fakeDragonDb.Modifier(dragonAModifier));
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok(_fakeDragonDb.Supprimer(id));
        }
    }
}
