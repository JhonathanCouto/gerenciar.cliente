using GestaoCliente.Domain;
using GestaoCliente.Domain.Interfaces.Servides;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoCliente.Admin.Controllers
{
    [Route("cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [Route("listar")]
        public IActionResult Listar(string nome = null, string email = null)
        {
            IEnumerable<ClienteModel> clientes = _clienteService.Listar(new Domain.ClienteModel
            {
                Nome = nome
            });

            return View(clientes);
        }

        [Route("detalhe")]
        public IActionResult Detalhe(int id)
        {
            ClienteModel cliente = _clienteService.Obter(new ClienteModel { Id = id });
            return View(cliente);
        }

        [Route("criar")]
        public IActionResult Criar()
        {
            return View(new ClienteModel());
        }

        [HttpPost, Route("criar")]
        public IActionResult Criar(ClienteModel model)
        {
            _clienteService.Adicionar(model);
            return RedirectToAction("listar");
        }

        [Route("atualizar")]
        public IActionResult Atualizar(int id)
        {
            ClienteModel cliente = _clienteService.Obter(new ClienteModel { Id = id });
            return View(cliente);
        }

        [HttpPost, Route("atualizar")]
        public IActionResult Atualizar(ClienteModel model)
        {
            _clienteService.Atualizar(model);

            ClienteModel cliente = _clienteService.Obter(new ClienteModel { Id = model.Id });
            return View(cliente);
        }

        [Route("delete")]
        public IActionResult Delete(int id)
        {
            _clienteService.Excluir(id);

            return RedirectToAction("listar");
        }
    }
}
