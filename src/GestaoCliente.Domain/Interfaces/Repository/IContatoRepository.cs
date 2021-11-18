using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Domain.Interfaces.Repository
{
    public interface IContatoRepository
    {
        void Adicionar(ContatoModel contato);
        void Atualizar(ContatoModel contato);
        void Excluir(int id);
        ContatoModel Obter(ContatoModel contato);
        IEnumerable<ContatoModel> Listar(ContatoModel contato);
    }
}
