using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Interfaces.Servides
{
    public interface IClienteService
    {
        /// <summary>
        /// Este método adiciona um novo cliente
        /// 
        /// Para adicionar um novo cliente, é obrigário adicionar os campos, Nome e Data de nascimento
        /// </summary>
        /// <param name="cliente"></param>
        void Adicionar(ClienteModel cliente);

        void Atualizar(ClienteModel cliente);
        void Excluir(int id);
        ClienteModel Obter(ClienteModel cliente);
        IEnumerable<ClienteModel> Listar(ClienteModel cliente);
    }
}
