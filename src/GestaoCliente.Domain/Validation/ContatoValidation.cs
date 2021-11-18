using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Validation
{
    public static class ContatoValidation
    {
        public static void Validar(this ContatoModel contato)
        {
            List<string> erros = new List<string>();

            if(string.IsNullOrEmpty(contato.Email))
            {
                erros.Add("Email");
            }
            if(erros.Any())
            {
                throw new Exception($"Informe os campos obrigatórios:{Environment.NewLine}{string.Join(',', erros)}");
            }
        }
        public static void ValidarAtualizar(this ContatoModel contato)
        {
            List<string> erros = new List<string>();

            if (contato.Id == default)
            {
                erros.Add("Id");
            }

            if (string.IsNullOrEmpty(contato.Email))
            {
                erros.Add("Email");
            }

            if (erros.Any())
            {
                throw new Exception($"Informe os campos obrigatórios:{Environment.NewLine}{string.Join(',', erros)}");
            }
        }

    }
}
