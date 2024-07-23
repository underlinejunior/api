using Microsoft.AspNetCore.Mvc;
using Exo.WebApi.Repositories;


namespace Exo.WebApi.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class ProjetosController: ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public IActionResult Listar(){
            return Ok(_projetoRepository.Listar());
        }
    }
}