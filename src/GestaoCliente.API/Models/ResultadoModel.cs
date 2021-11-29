using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoCliente.API.Models
{
    public class ResultadoModel
    {
        public int CodigoErro { get; set; }
        public string Mensagem { get; set; }
        public bool Sucesso { get; set; }
        public object Data { get; set; }
    }
}
