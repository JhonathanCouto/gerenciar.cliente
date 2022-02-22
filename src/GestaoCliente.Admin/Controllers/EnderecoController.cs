using GestaoCliente.Domain;
using GestaoCliente.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoCliente.Admin.Controllers
{
    [Route("endereco")]
    public class EnderecoController : Controller
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [Route("listar")]
        public IActionResult Listar(int clienteId, string logradouro = null, string numero = null,
                                    string complemento = null, string cep = null, string estado = null,
                                    string cidade = null, string bairro = null)
        {
            IEnumerable<EnderecoModel> enderecos = _enderecoService.Listar(new Domain.EnderecoModel
            {
                ClienteId = clienteId,
                Logradouro = logradouro,
                Numero = numero,
                Complemento = complemento,
                Cep = cep,
                Estado = estado,
                Cidade = cidade,
                Bairro = bairro
            });
            return View(enderecos);
        }

        [Route("detalhe")]
        public IActionResult Detalhe(int id)
        {
            EnderecoModel endereco = _enderecoService.Obter(new EnderecoModel { Id = id });
            return View(endereco);
        }

        [Route("criar")]
        public IActionResult Criar(int clienteId)
        {
            return View(new EnderecoModel { ClienteId = clienteId });
        }

        [HttpPost, Route("criar")]
        public IActionResult Criar(EnderecoModel model)
        {
            _enderecoService.Adicionar(model);
            return RedirectToAction("listar", "endereco", new { clienteId = model.ClienteId });
        }

        [Route("atualizar")]
        public IActionResult Atualizar(int id)
        {
            EnderecoModel endereco = _enderecoService.Obter(new EnderecoModel { Id = id });
            return View(endereco);
        }

        [HttpPost, Route("atualizar")]
        public IActionResult Atualizar(EnderecoModel model)
        {
            _enderecoService.Atualizar(model);
            EnderecoModel endereco = _enderecoService.Obter(new EnderecoModel { Id = model.Id });
            return View(endereco);
        }

        [Route("delete")]
        public IActionResult Delete(int id, int clientId)
        {
            _enderecoService.Excluir(id);
            return RedirectToAction("listar", "endereco", new { clienteId = clientId });
        }
    }
}
