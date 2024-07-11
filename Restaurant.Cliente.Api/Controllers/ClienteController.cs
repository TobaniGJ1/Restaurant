using Microsoft.AspNetCore.Mvc;
using Restaurant.Cliente.Persistance.Interfaces;
using Restaurant.Cliente.Persistance.Models.Cliente;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Cliente.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }
        // GET: api/<ClienteController>
        [HttpGet("GetCourses")]
        public IActionResult Get()
        {
            var result = this.clienteService.GetClientes();
            if (!result.Success)

                return BadRequest(result);

            else
                return Ok(result);
        }

        // GET api/<ClienteController>/5
        [HttpGet("GetClienteById")]
        public IActionResult Get(int id)
        {
            var result = this.clienteService.GetCliente(id);
            if (!result.Success)
                return BadRequest(result);
            else return Ok(result);

        }

        // POST api/<ClienteController>
        [HttpPost("SaveCliente")]
        public IActionResult Post([FromBody] ClienteSaveModel clienteSave)
        {
            var result = this.clienteService.SaveClientes(clienteSave);
            if (!result.Success)
                return BadRequest(result);
            else return Ok(result);

        }

        // PUT api/<ClienteController>/5
        [HttpPost("UpdateCliente")]
        public IActionResult Put(ClienteUpdateModel clienteUpdate)
        {
            var result = this.clienteService.UpdateClientes(clienteUpdate);
            if (!result.Success)
                return BadRequest(result);
            else return Ok(result);

        }
        // DELETE api/<ClienteController>/5
        [HttpDelete("RemoveCliente")]
        public ActionResult Delete(ClienteRemoveModel clienteRemove)
        {
            var result = this.clienteService.RemoveClientes(clienteRemove);
            if (!result.Success)
                return BadRequest(result);

            else
                return Ok(result);
              
        }
    }
}
