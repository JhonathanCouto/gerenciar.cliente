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
    public class EnderecoController : BaseAPIController
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost, Route("endereco")]
        public object Post(EnderecoModel model)
        {
            try
            {
                _enderecoService.Adicionar(model);
                return Sucesso("Registro salvo com sucesso.", (int)HttpStatusCode.Created);
            }
            catch (Exception exception)
            {
                return Erro(exception.Message, (int)HttpStatusCode.NotFound);
            }
        }

        [HttpPut, Route("endereco")]
        public object Put(EnderecoModel model)
        {
            try
            {
                _enderecoService.Atualizar(model);
                return Sucesso("Registro atualizado com sucesso.", (int)HttpStatusCode.OK);
            }
            catch (Exception exception)
            {
                return Erro(exception.Message, (int)HttpStatusCode.NotFound);
            }
        }

        [HttpDelete, Route("endereco/{id}")]
        public object Delete(int id)
        {
            try
            {
                _enderecoService.Excluir(id);
                return Sucesso("Registro excluido com sucesso.", (int)HttpStatusCode.OK);
            }
            catch (Exception exception)
            {
                return Erro(exception.Message, (int)HttpStatusCode.NotFound);
            }
        }

        [HttpGet, Route("endereco")]
        public dynamic Listar()
        {
            EnderecoModel model = new EnderecoModel
            {
                Logradouro = HttpContext.Request.Query["logradouro"],
                Cep = HttpContext.Request.Query["cep"],
                Estado = HttpContext.Request.Query["estado"],
            };
            return Sucesso(null, (int)HttpStatusCode.OK, _enderecoService.Listar(model));
        }

        [HttpGet, Route("endereco/{id}")]
        public dynamic Obter(int id)
        {
            EnderecoModel model = new EnderecoModel
            {
                Id = id,
            };
            return Sucesso(null, (int)HttpStatusCode.OK, _enderecoService.Obter(model));
        }
    }


}
