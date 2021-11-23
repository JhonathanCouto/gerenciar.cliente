using GestaoCliente.Application;
using GestaoCliente.Domain;
using GestaoCliente.Domain.Interfaces.Servides;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoCliente.WebAPI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            IEnumerable<ClienteModel> clientes = _clienteService.Listar(new ClienteModel { });
            return View(clientes);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(ClienteModel cliente)
        {
            _clienteService.Adicionar(cliente);
            return View(cliente);
        }

        public IActionResult Edit(int id)
        {
            ClienteModel cliente = _clienteService.Obter(new ClienteModel { Id = id });
            return View(cliente);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(ClienteModel cliente)
        {
            _clienteService.Atualizar(cliente);
            return View(cliente);
        }

        public IActionResult Delete(int id)
        {
            _clienteService.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
