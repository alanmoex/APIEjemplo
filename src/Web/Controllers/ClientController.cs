using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            return Ok(_clientService.GetAll());
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_clientService.GetById(id));
        }

        [HttpPost("[action]")]
        public IActionResult Add([FromBody] Client client)
        {
            _clientService.Add(client);
            return Ok();
        }

        [HttpPut("[action]/{id}")]
        public IActionResult Update(int id, [FromBody] Client client)
        {
            _clientService.Update(id, client);
            return Ok();
        }

        [HttpDelete("[action]")]
        public IActionResult Delete(int id)
        {
            _clientService.Delete(id);
            return Ok();
        }
    }
}
