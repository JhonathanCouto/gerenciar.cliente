using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Interfaces.Repository
{
    public interface IEnderecoRepository
    {
        /// <summary>
        /// Estes são os metodos do Endereço que serão usados na camada Repository
        /// </summary>
        /// <param name="endereco"></param>
        void Adicionar(EnderecoModel endereco);
        void Atualizar(EnderecoModel endereco);
        void Excluir(int id);
        EnderecoModel Obter(EnderecoModel endereco);
        IEnumerable<EnderecoModel> Listar(EnderecoModel endereco);
    }
}
