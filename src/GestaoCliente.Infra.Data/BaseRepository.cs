using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GestaoCliente.Infra.Data
{
    public abstract class BaseRepository
    {
        private const string stringSQL = "Data Source = .\\SQLEXPRESS;Initial Catalog=DbGestaoCliente;Integrated Security=True;";

        private IDbConnection dbConnection => new SqlConnection(stringSQL);

        protected void AdicionarOuAtualizar(string sql, object model)
        {
            dbConnection.ExecuteScalar(sql, model);
        }

        protected IEnumerable<T> Listar<T>(string sql, object model) where T : class
        {
            return dbConnection.Query<T>(sql, model);
        }

        protected T Obter<T>(string sql, object model) where T : class
        {
            return dbConnection.QueryFirstOrDefault<T>(sql, model);
        }
    }
}
