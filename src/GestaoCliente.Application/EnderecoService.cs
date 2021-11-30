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
    /// esta classe é responsavel pelas regras  de negocio do objeto Endereço
    /// </summary>
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public void Adicionar(EnderecoModel endereco)
        {
            endereco.Validar();
            _enderecoRepository.Adicionar(endereco);
        }

        public void Atualizar(EnderecoModel endereco)
        {
            endereco.ValidarAtualizar();
            _enderecoRepository.Atualizar(endereco);
        }

        public void Excluir(int id)
        {
            _enderecoRepository.Excluir(id);
        }

        public IEnumerable<EnderecoModel> Listar(EnderecoModel endereco)
        {
            return _enderecoRepository.Listar(endereco);
        }

        public IEnumerable<EnderecoModel> ObterPorCliente(EnderecoModel endereco)
        {
            return _enderecoRepository.ObterPorCliente(endereco);
        }

        public EnderecoModel Obter(EnderecoModel endereco)
        {
            return _enderecoRepository.Obter(endereco);
        }
    }
}
