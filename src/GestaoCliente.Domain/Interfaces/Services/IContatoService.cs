using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Interfaces.Services
{
    public interface IContatoService
    {
        /// <summary>
        /// Este método adiciona um novo cliente
        /// 
        /// Para adicionar um novo cliente, é obrigário adicionar os campos, Nome e Data de nascimento
        /// </summary>
        /// <param name="contato"></param>
        void Adicionar(ContatoModel contato);
        void Atualizar(ContatoModel contato);
        void Excluir(int id);
        ContatoModel Obter(ContatoModel contato);
        IEnumerable<ContatoModel> Listar(ContatoModel contato);


    }
}
