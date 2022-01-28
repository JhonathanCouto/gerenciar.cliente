using GestaoCliente.Domain;
using GestaoCliente.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoCliente.Admin.Controllers
{
    [Route("contato")]
    public class ContatoController : Controller
    {
        private readonly IContatoService _contatoService;

        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        [Route("listar")]
        public IActionResult Listar(int clienteId, string telefone = null, string email = null)
        {
            IEnumerable<ContatoModel> contatos = _contatoService.Listar(new Domain.ContatoModel
            {
                ClienteId = clienteId,
                Telefone = telefone,
                Email = email
            });
            return View(contatos);
        }


        [Route("detalhe")]
        public IActionResult Detalhe(int id)
        {
            ContatoModel contato = _contatoService.Obter(new ContatoModel { Id = id });
            return View(contato);
        }

        [Route("criar")]
        public IActionResult Criar(int clienteId)
        {
            return View(new ContatoModel { ClienteId = clienteId });
        }

        [HttpPost, Route("criar")]
        public IActionResult Criar(ContatoModel model)
        {
            _contatoService.Adicionar(model);
            return RedirectToAction("listar", "cliente");
        }

        [Route("atualizar")]
        public IActionResult Atualizar(int id)
        {
            ContatoModel contato = _contatoService.Obter(new ContatoModel { Id = id });
            return View(contato);
        }

        [HttpPost, Route("atualizar")]
        public IActionResult Atualizar(ContatoModel model)
        {
            _contatoService.Atualizar(model);
            ContatoModel contato = _contatoService.Obter(new ContatoModel { Id = model.Id });
            return View(contato);
        }

        [Route("delete")]
        public IActionResult Delete(int id)
        {
            _contatoService.Excluir(id);
            return RedirectToAction("listar", "cliente");
        }
    }
}
