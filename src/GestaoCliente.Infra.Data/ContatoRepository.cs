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
    /// <summary>
    /// Esta classe é responsavel pela conexão ao banco de dados
    /// </summary>
    public class ContatoRepository : BaseRepository, IContatoRepository
    {
        public void Adicionar(ContatoModel contato)
        {

            string sql = @"Insert into Contato (
                                    Telefone,
                                    Email,
                                    ClienteId
                                ) values (
                                    @Telefone,
                                    @Email,
                                    @ClienteId
                                );";
            base.AdicionarOuAtualizar(sql, contato);
        }

        public void Atualizar(ContatoModel contato)
        {
            string sql = @"Update Contato set
                                    Telefone = @Telefone,
                                    Email = @Email
                                Where Id = @Id;";
            base.AdicionarOuAtualizar(sql, contato);
        }

        public void Excluir(int id)
        {
            string sql = @"Delete from Contato where Id = @Id;";
            base.AdicionarOuAtualizar(sql, new KeyValuePair<string, object>("@Id", id));
        }

        public IEnumerable<ContatoModel> Listar(ContatoModel contato)
        {
            string sql = @"Select * from Contato;";
            return base.Listar<ContatoModel>(sql, contato);
        }

        public ContatoModel Obter(ContatoModel contato)
        {
            string sql = @"select * from Contato where Id = @Id;";
            return base.Obter<ContatoModel>(sql, contato);
        }

        public IEnumerable<ContatoModel> ObterPorCliente(ContatoModel contato)
        {
            string sql = @"select * from Contato where ClienteId = @ClienteId;";
            return base.Listar<ContatoModel>(sql, contato);
        }

    }
}
