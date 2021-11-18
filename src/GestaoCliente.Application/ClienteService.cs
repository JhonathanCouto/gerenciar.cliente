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
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

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
