﻿using Dapper;
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
    public class EnderecoRepository : BaseRepository, IEnderecoRepository
    {
        public void Adicionar(EnderecoModel endereco)
        {
            string sql = @"Insert into Endereco (
                                    Logradouro,
                                    Numero,
                                    Complemento,
                                    Cep,
                                    Estado,
                                    Cidade,
                                    Bairro
                                ) values (
                                    @Logradouro,
                                    @Numero,
                                    @Complemento,
                                    @Cep,
                                    @Estado,
                                    @Cidade,
                                    @Bairro);";
            base.AdicionarOuAtualizar(sql, endereco);
        }

        public void Atualizar(EnderecoModel endereco)
        {
            string sql = @"Update Endereco set
                                    Logradouro = @Logradouro,
                                    Numero = @Numero,
                                    Complemento = @Complemento,
                                    Cep = @Cep,
                                    Estado = @Estado,
                                    Cidade @Cidade,
                                    Bairro = @Bairro;";
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

        public EnderecoModel Obter(EnderecoModel endereco)
        {
            string sql = @"select * from Endereco where Id = @Id;";
            return base.Obter<EnderecoModel>(sql, endereco);
        }

    }
}