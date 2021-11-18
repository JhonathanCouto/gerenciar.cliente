using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Interfaces.Repository
{
    public interface IClienteRepository
    {
        void Adicionar(ClienteModel cliente);
        void Atualizar(ClienteModel cliente);
        void Excluir(int id);
        ClienteModel Obter(ClienteModel cliente);
        IEnumerable<ClienteModel> Listar(ClienteModel cliente);
    }
}
