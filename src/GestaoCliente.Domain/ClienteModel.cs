using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain
{
    public class ClienteModel
    {
        /// <summary>
        /// Estes são os campos da entidade Cliente
        /// </summary>
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
    }
}
