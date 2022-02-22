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
    /// <summary>
    /// Esta classe é responsavel pelos codigos base da camada de conexão ao banco de dados
    /// </summary>
    public abstract class BaseRepository 
    {
        //private const string stringSQL = "Data Source=.\\SQLEXPRESS;Initial Catalog=DbGestaoCliente;Integrated Security=True;";
        private const string stringSQL = "Data Source=sql5097.site4now.net;Initial Catalog=db_a82f91_aulanet;Persist Security Info=True;User ID=db_a82f91_aulanet_admin;Password=aulane10@;MultipleActiveResultSets=True;Connection Timeout=0;";

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
