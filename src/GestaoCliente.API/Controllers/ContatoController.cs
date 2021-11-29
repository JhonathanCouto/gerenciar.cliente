using GestaoCliente.Domain;
using GestaoCliente.Domain.Interfaces.Services;
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
    public class ContatoController : BaseAPIController
    {
        private readonly IContatoService _contatoService;

        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        [HttpPost, Route("contato")]
        public object Post(ContatoModel model)
        {
            try
            {
                _contatoService.Adicionar(model);
                return Sucesso("Registro salvo com sucesso.", (int)HttpStatusCode.Created);
            }
            catch (Exception exception)
            {

                return Erro(exception.Message, (int)HttpStatusCode.NotFound);
            }
        }

        [HttpPut, Route("contato")]
        public object Put(ContatoModel model)
        {
            try
            {
                _contatoService.Atualizar(model);
                return Sucesso("Registro atualizado com sucesso.", (int)HttpStatusCode.OK);
            }
            catch (Exception exception)
            {

                return Erro(exception.Message, (int)HttpStatusCode.NotFound);
            }
        }

        [HttpDelete, Route("contato/{id}")]
        public object Delete(int id)
        {
            try
            {
                _contatoService.Excluir(id);
                return Sucesso("Registro excluido com sucesso.", (int)HttpStatusCode.OK);
            }
            catch (Exception exception)
            {
                return Erro(exception.Message, (int)HttpStatusCode.NotFound);
            }
        }

        [HttpGet, Route("contato")]
        public dynamic Listar()
        {
            ContatoModel model = new ContatoModel
            {
                Telefone = HttpContext.Request.Query["telefone"],
                Email = HttpContext.Request.Query["email"],
            };
            return Sucesso(null, (int)HttpStatusCode.OK, _contatoService.Listar(model));
        }

        [HttpGet, Route("contato/{id}")]
        public dynamic Obter(int id)
        {
            ContatoModel model = new ContatoModel
            {
                Id = id,
            };
            return Sucesso(null, (int)HttpStatusCode.OK, _contatoService.Obter(model));
        }
    }
}
