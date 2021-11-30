using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Interfaces.Repository
{
    public interface IContatoRepository
    {
        /// <summary>
        /// Estes são os metodos do Contato que serão usados na camada Repository
        /// </summary>
        /// <param name="contato"></param>
        void Adicionar(ContatoModel contato);
        void Atualizar(ContatoModel contato);
        void Excluir(int id);
        ContatoModel Obter(ContatoModel contato);
        IEnumerable<ContatoModel> Listar(ContatoModel contato);
        IEnumerable<ContatoModel> ObterPorCliente(ContatoModel contato);
    }
}
