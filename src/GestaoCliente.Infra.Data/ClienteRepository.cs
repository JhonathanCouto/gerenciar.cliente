using Dapper;
using GestaoCliente.Domain;
using GestaoCliente.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCliente.Infra.Data
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {
        public void Adicionar(ClienteModel cliente)
        {
            string sql = @"Insert into Cliente (
                                    Nome,
                                    DataNascimento,
                                    Genero
                                ) values (
                                    @Nome,
                                    @DataNascimento,
                                    @Genero
                                );";
            base.AdicionarOuAtualizar(sql, cliente);
        }

        public void Atualizar(ClienteModel cliente)
        {
            string sql = @"Update Cliente set
                                    Nome = @Nome,
                                    DataNascimento = @DataNascimento,
                                    Genero = @Genero
                                Where Id = @Id;";
            base.AdicionarOuAtualizar(sql, cliente);
        }

        public ClienteModel Obter(ClienteModel cliente)
        {
            string sql = @"Select * from Cliente where Id = @Id;";
            return base.Obter<ClienteModel>(sql, cliente);
        }

        public IEnumerable<ClienteModel> Listar(ClienteModel cliente)
        {
            string sql = @"select * from Cliente;";
            return base.Listar<ClienteModel>(sql, cliente);
        }

        public void Excluir(int id)
        {
            string sql = @"delete from Cliente where Id = @Id;";
            base.AdicionarOuAtualizar(sql, new Dictionary<string, object> { { "@Id", id } });
        }
    }
}
