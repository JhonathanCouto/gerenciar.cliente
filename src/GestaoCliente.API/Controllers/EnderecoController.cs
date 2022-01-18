using GestaoCliente.API.Models;
using GestaoCliente.Domain;
using GestaoCliente.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
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

        [HttpGet, Route("endereco/{cep}/pesquisar")]
        public dynamic Pesquisar(string cep)
        {
            cep = string.IsNullOrWhiteSpace(cep) ? cep.Replace("-", "") : cep;

            RestClient client = new RestClient($"https://viacep.com.br/ws/{cep}/json");
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            CepModel model = JsonConvert.DeserializeObject<CepModel>(response.Content);

            return Sucesso(null, (int)HttpStatusCode.OK, model);
        }

        [HttpGet, Route("endereco/{cep}/pesquisar-xml")]
        public dynamic PesquisarZml(string cep)
        {
            cep = string.IsNullOrWhiteSpace(cep) ? cep.Replace("-", "") : cep;

            RestClient client = new RestClient($"https://viacep.com.br/ws/{cep}/xml");
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            xmlcep xmlCep = new xmlcep();

            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(xmlcep));
            using (StringReader sr = new StringReader(response.Content))
            {
                xmlCep = (xmlcep)ser.Deserialize(sr);
            }

            return Sucesso(null, (int)HttpStatusCode.OK, xmlCep);
        }
    }


}
