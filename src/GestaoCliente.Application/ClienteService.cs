using GestaoCliente.Domain;
using GestaoCliente.Domain.Interfaces.Repository;
using GestaoCliente.Domain.Interfaces.Servides;
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
    /// esta classe é responsavel pelas regras  de negocio do objeto Cliente
    /// </summary>
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        /// <summary>
        /// Adicionar o cliente no bannco de dados 
        /// 
        /// Validar os campos obrigatórios, sendo:
        /// Nome: Aceito até 30 caracteres
        /// E-mail
        /// </summary>
        /// <param name="cliente"></param>
        public void Adicionar(ClienteModel cliente)
        {
            cliente.Validar();

            _clienteRepository.Adicionar(cliente);
        }

        public void Atualizar(ClienteModel cliente)
        {
            cliente.ValidarAtualizar();

            _clienteRepository.Atualizar(cliente);
        }

        public void Excluir(int id)
        {
            _clienteRepository.Excluir(id);
        }

        public IEnumerable<ClienteModel> Listar(ClienteModel cliente)
        {
            return _clienteRepository.Listar(cliente);
        }

        public ClienteModel Obter(ClienteModel cliente)
        {
            return _clienteRepository.Obter(cliente);
        }
    }
}
