using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Interfaces.Repository
{
    public interface IClienteRepository
    {
        /// <summary>
        /// Estes são os metodos do Cliente que serão usados na camada Repository
        /// </summary>
        /// <param name="cliente"></param>
        void Adicionar(ClienteModel cliente);
        void Atualizar(ClienteModel cliente);
        void Excluir(int id);
        ClienteModel Obter(ClienteModel cliente);
        IEnumerable<ClienteModel> Listar(ClienteModel cliente);
    }
}
