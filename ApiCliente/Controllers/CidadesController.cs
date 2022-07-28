using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testeentity.Models;
using testeentity.Models.Entities.Cidades;
using testeentity.Repositories;

namespace testeentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadesController : ControllerBase
    {
        private readonly ICidadesRepository repos;
        public CidadesController(ICidadesRepository _repos)
        {
            repos = _repos;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cidade_db = repos.ReadAll();
            return Ok(cidade_db);
        }

        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute] CidadeId cidade)
        {
            var cidade_db = repos.Read(cidade.Id);
            return Ok(cidade_db);
        }

        [HttpPost]
        public IActionResult Post(PostCidade cidade)
        {
            if (repos.Create(cidade))
                return Ok();

            return BadRequest();
        }
        
        [HttpPut]
        public IActionResult Put(PutCidade cidade)
        {
            if (repos.Update(cidade))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] CidadeId cidade)
        {
            if (repos.Delete(cidade.Id))
                return Ok();

            return BadRequest();
        }

    }
}
