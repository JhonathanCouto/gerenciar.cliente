using GestaoCliente.Domain;
using GestaoCliente.Domain.Interfaces.Services;
using GestaoCliente.Domain.Interfaces.Servides;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GestaoCliente.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class ClienteController : BaseAPIController
    {
        private readonly IClienteService _clienteService;
        private readonly IContatoService _contatoService;
        private readonly IEnderecoService _enderecoService;

        public ClienteController(IClienteService clienteService, IContatoService contatoService, IEnderecoService enderecoService)
        {
            _clienteService = clienteService;
            _contatoService = contatoService;
            _enderecoService = enderecoService;
        }

        [HttpPost, Route("cliente")]
        public object Post(ClienteModel model)
        {
            try
            {
                _clienteService.Adicionar(model);
                return Sucesso("Registro salvo com sucesso.", (int)HttpStatusCode.Created);
            }
            catch (Exception exception)
            {
                return Erro(exception.Message, (int)HttpStatusCode.NotFound);
            }
        }

        [HttpPut, Route("cliente")]
        public object Put(ClienteModel model)
        {
            try
            {
                _clienteService.Atualizar(model);
                return Sucesso("Registro atualizado com sucesso.", (int)HttpStatusCode.OK);
            }
            catch (Exception exception)
            {
                return Erro(exception.Message, (int)HttpStatusCode.NotFound);
            }
        }

        [HttpDelete, Route("cliente/{id}")]
        public object Delete(int id)
        {
            try
            {
                _clienteService.Excluir(id);
                return Sucesso("Registro excluido com sucesso.", (int)HttpStatusCode.OK);
            }
            catch (Exception exception)
            {
                return Erro(exception.Message, (int)HttpStatusCode.NotFound);
            }
        }

        [HttpGet, Route("cliente")]
        public dynamic Listar()
        {
            ClienteModel model = new ClienteModel
            {
                Nome = HttpContext.Request.Query["nome"],
            };
            return Sucesso(null, (int)HttpStatusCode.OK, _clienteService.Listar(model));
        }

        [HttpGet, Route("cliente/{id}")]
        public dynamic Obter(int id)
        {
            ClienteModel model = new ClienteModel
            {
                Id = id,
            };
            return Sucesso(null, (int)HttpStatusCode.OK, _clienteService.Obter(model));
        }

        [HttpGet, Route("cliente/{id}/completo")]
        public dynamic ObterCompleto(int id)
        {
            ClienteModel model = new ClienteModel
            {
                Id = id,
            };

            dynamic resultado = new
            {
                Cliente = _clienteService.Obter(model),
                Endereco = _enderecoService.ObterPorCliente(new EnderecoModel { ClienteId = id }),
                Contato = _contatoService.ObterPorCliente(new ContatoModel { ClienteId = id })
            };

            return Sucesso(null, (int)HttpStatusCode.OK, resultado);
        }
    }
}
