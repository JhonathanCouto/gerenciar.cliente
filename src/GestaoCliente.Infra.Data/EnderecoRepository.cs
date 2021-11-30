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
    /// esta classe é responsavel pela conexão ao banco de dados
    /// </summary>
    public class EnderecoRepository : BaseRepository, IEnderecoRepository
    {
        /// <summary>
        /// Adicionar o endereço no banco de dados
        /// </summary>
        /// <param name="endereco"></param>
        public void Adicionar(EnderecoModel endereco)
        {
            string sql = @"Insert into Endereco (
                                    Logradouro,
                                    Numero,
                                    Complemento,
                                    Cep,
                                    Estado,
                                    Cidade,
                                    Bairro,
                                    ClienteId
                                ) values (
                                    @Logradouro,
                                    @Numero,
                                    @Complemento,
                                    @Cep,
                                    @Estado,
                                    @Cidade,
                                    @Bairro,
                                    @ClienteId);";
            base.AdicionarOuAtualizar(sql, endereco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endereco"></param>
        public void Atualizar(EnderecoModel endereco)
        {
            string sql = @"Update Endereco set
                                    Logradouro = @Logradouro,
                                    Numero = @Numero,
                                    Complemento = @Complemento,
                                    Cep = @Cep,
                                    Estado = @Estado,
                                    Cidade @Cidade,
                                    Bairro = @Bairro
                                where Id = @Id;";
            base.AdicionarOuAtualizar(sql, endereco);
        }

        public void Excluir(int id)
        {
            string sql = @"Delete from Endereco where Id = @Id;";
            base.AdicionarOuAtualizar(sql, new KeyValuePair<string, object>("@Id", id));
        }

        public IEnumerable<EnderecoModel> Listar(EnderecoModel endereco)
        {
            string sql = @"Select * from Endereco;";
            return base.Listar<EnderecoModel>(sql, endereco);
        }

        public IEnumerable<EnderecoModel> ObterPorCliente(EnderecoModel endereco)
        {
            string sql = @"select * from Endereco where ClienteId = @ClienteId;";
            return base.Listar<EnderecoModel>(sql, endereco);
        }

        public EnderecoModel Obter(EnderecoModel endereco)
        {
            string sql = @"select * from Endereco where Id = @Id;";
            return base.Obter<EnderecoModel>(sql, endereco);
        }

    }
}
