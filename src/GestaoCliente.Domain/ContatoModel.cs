using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain
{
    public class ContatoModel
    {
        /// <summary>
        /// Estes são os campos da entidade Contato
        /// </summary>
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
