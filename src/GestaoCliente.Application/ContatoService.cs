using GestaoCliente.Domain;
using GestaoCliente.Domain.Interfaces.Repository;
using GestaoCliente.Domain.Interfaces.Services;
using GestaoCliente.Domain.Validation;
using GestaoCliente.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Application
{
    /// <summary>
    /// esta classe é responsavel pelas regras  de negocio do objeto contato
    /// </summary>

    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        
        public void Adicionar(ContatoModel contato)
        {
            contato.Validar();

            _contatoRepository.Adicionar(contato);
        }

        public void Atualizar(ContatoModel contato)
        {
            contato.ValidarAtualizar();
            _contatoRepository.Atualizar(contato);
        }

        public void Excluir(int id)
        {
            _contatoRepository.Excluir(id);
        }

        public IEnumerable<ContatoModel> Listar(ContatoModel contato)
        {
            return _contatoRepository.Listar(contato);
        }

        public IEnumerable<ContatoModel> ObterPorCliente(ContatoModel contato)
        {
            return _contatoRepository.ObterPorCliente(contato);
        }

        public ContatoModel Obter(ContatoModel contato)
        {
            return _contatoRepository.Obter(contato);
        }
    }
}
