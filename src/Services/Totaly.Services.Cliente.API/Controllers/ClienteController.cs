using Microsoft.AspNetCore.Mvc;
using Totaly.BuldingBlocks.Core.Mediator;
using Totaly.Services.Clientes.API.Application.Commands;
using Totaly.WebApi.Core.Controllers;

namespace Totaly.Services.Clientes.API.Controllers
{
    public class ClienteController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;
        public ClienteController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }
        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var result = await _mediatorHandler.EnviarComando(new RegistrarClienteCommand(Guid.NewGuid(), "Anderson", "somdesp@gmail.com", "45171865043"));
            return CustomResponse(result);
        }
    }
}
