using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain
{
    public class ContatoModel
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
