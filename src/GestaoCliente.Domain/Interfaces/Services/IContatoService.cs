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
        /// Este método adiciona um novo contato
        /// 
        /// Para adicionar um novo contato, é obrigário adicionar os campos, Email e telefone
        /// </summary>
        /// <param name="contato"></param>
        void Adicionar(ContatoModel contato);
        void Atualizar(ContatoModel contato);
        void Excluir(int id);
        ContatoModel Obter(ContatoModel contato);
        IEnumerable<ContatoModel> Listar(ContatoModel contato);


    }
}
