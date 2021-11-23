using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Validation
{
    public static class ClienteValidation
    {
        /// <summary>
        /// Os metodos presentes nessa classe são as validações do Cliente
        /// </summary>
        /// <param name="cliente"></param>
        public static void Validar(this ClienteModel cliente)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(cliente.Nome))
            {
                erros.Add("Nome");
            }

            if (cliente.DataNascimento == default)
            {
                erros.Add("Data de nascimento");
            }

            if (erros.Any())
            {
                throw new Exception($"Informe os campos obrigatórios:{Environment.NewLine}{string.Join(',', erros)}");
            }

        }
        public static void ValidarAtualizar(this ClienteModel cliente)
        {
            List<string> erros = new List<string>();

            if (cliente.Id == default)
            {
                erros.Add("Id");
            }

            if (string.IsNullOrEmpty(cliente.Nome))
            {
                erros.Add("Nome");
            }

            if (cliente.DataNascimento == default)
            {
                erros.Add("Data de nascimento");
            }

            if (erros.Any())
            {
                throw new Exception($"Informe os campos obrigatórios:{Environment.NewLine}{string.Join(',', erros)}");
            }

        }
    }
}
