using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Validation
{
    public static class EnderecoValidation
    {
        /// <summary>
        /// Os metodos desta classe são validações do Endereço
        /// </summary>
        /// <param name="endereco"></param>
        public static void Validar(this EnderecoModel endereco)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(endereco.Cep))
            {
                erros.Add("Cep");
            }
            if (string.IsNullOrEmpty(endereco.Numero))
            {
                erros.Add("Numero");
            }

            if (erros.Any())
            {
                throw new Exception($"Informe os campos obrigatórios:{Environment.NewLine}{string.Join(',', erros)}");
            }
        }

        public static void ValidarAtualizar(this EnderecoModel endereco)
        {
            List<string> erros = new List<string>();

            if(endereco.Id == default)
            {
                erros.Add("Id");
            }

            if(string.IsNullOrEmpty(endereco.Cep))
            {
                erros.Add("Cep");
            }
            if(string.IsNullOrEmpty(endereco.Numero))
            {
                erros.Add("Numero");
            }

            if(erros.Any())
            {
                throw new Exception($"Informe os campos obrigatórios:{Environment.NewLine}{string.Join(',', erros)}");
            }
        }
    }
}
