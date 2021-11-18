using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Interfaces.Services
{
    public interface IEnderecoService
    {
        void Adicionar(EnderecoModel endereco);
        void Atualizar(EnderecoModel endereco);
        void Excluir(int id);
        EnderecoModel Obter(EnderecoModel endereco);
        IEnumerable<EnderecoModel> Listar(EnderecoModel endereco);
    }
}
