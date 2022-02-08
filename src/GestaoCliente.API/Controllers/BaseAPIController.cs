using GestaoCliente.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoCliente.API.Controllers
{
    [ApiController]
    public class BaseAPIController : ControllerBase
    {
        protected object Sucesso(string mensagem, int codigo, object data = null)
        {
            return Ok(new ResultadoModel
            {
                CodigoErro = codigo,
                Sucesso = true,
                Mensagem = mensagem,
                Data = data
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        /// <param name="codigo"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected object Erro(string mensagem, int codigo, object data = null)
        {
            return NotFound(new ResultadoModel
            {
                CodigoErro = codigo,
                Sucesso = false,
                Mensagem = mensagem,
                Data = data
            });
        }
    }
}
