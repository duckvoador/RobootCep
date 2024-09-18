using Domains.Interfaces.Services;
using Domains.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _service;

        public EnderecoController(IEnderecoService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("list")]
        public async Task <IActionResult> Add(List<EnderecoModel> model)
        {
            await _service.Add(model);
            return Ok(new {Message = "Ceps Adicionado com Sucesso"});
        }

        [HttpGet]
        [Route("ObterCepParaTratamento")]
        public async Task<IActionResult> ObterCepParaTratamento(string robot0)
        {
            var cep = await _service.ObterCepParaTratamento(robot0);
            return Ok(cep);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var ceps = await _service.List();
            return Ok(ceps);
        }

        [HttpPut]
        [Route("AtualizarDados")]
        public async Task<IActionResult> AtualizarDados(EnderecoModel model)
        {
            await _service.AtualizarDados(model);
            return Ok(new { Message = "Ceps Atualizados com Sucesso" });
        }
    }

}
