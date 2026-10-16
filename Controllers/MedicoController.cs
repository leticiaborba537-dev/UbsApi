using Microsoft.AspNetCore.Mvc;
using UbsApi.Models;
using UbsApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UbsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {

        MedicoService medicoFuncao = new MedicoService();

        // GET: api/<AgendamentoController>
        [HttpGet]

        public IActionResult GetListarMedicos()
        {
            List<MedicoModel> listaMedicoController = medicoFuncao.ListarMedicos();
            return Ok(listaMedicoController);
        }

        // GET api/<AgendamentoController>/5
        [HttpGet("{crm}")]
        
        public IActionResult GetMedico(string crm)
        {
            MedicoModel medicoEncontrado = medicoFuncao.BuscarMedico(crm);
            if (medicoEncontrado != null)
            {
                return Ok(medicoEncontrado);
            }
            return BadRequest();
        }
       

        // POST api/<AgendamentoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AgendamentoController>/5
        //[HttpPut("{id}")]
        //public string Put(int id, [FromBody] string value)
        //{
        //    MedicoService medicoFuncao = new MedicoService();
        //    if (medicoFuncao.CadastrarMedico())
        //    {
        //        return "Cadastro Realizado com sucesso!";
        //    }
        //    return "Cadastro não Realizado!";
        //}

        // DELETE api/<AgendamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
