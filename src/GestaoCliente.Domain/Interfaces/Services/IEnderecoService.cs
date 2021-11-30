using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Interfaces.Services
{
    public interface IEnderecoService
    {
        /// <summary>
        /// Este metodo adiciona um novo endereço,
        /// 
        /// Para adicionar um novo endereço, é obrigatório informar os campos Cep, logradouro e estado
        /// </summary>
        /// <param name="endereco"></param>
        void Adicionar(EnderecoModel endereco);
        void Atualizar(EnderecoModel endereco);
        void Excluir(int id);
        EnderecoModel Obter(EnderecoModel endereco);
        IEnumerable<EnderecoModel> Listar(EnderecoModel endereco);
        IEnumerable<EnderecoModel> ObterPorCliente(EnderecoModel endereco);
    }
}
