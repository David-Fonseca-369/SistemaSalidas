using System.Data.SqlClient;

namespace DataAccess.SqlServer
{
public abstract class ConnectionToSql

    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            //connectionString = "Data Source = AT1LDFONSECA; Initial Catalog = SalidaDeMaterial; Persist Security Info = True; User ID = sa; Password = ltceelc50709";
           // connectionString = "Server = FONSECA\\SQLEXPRESS; DataBase = SalidaDeMaterial; integrated security = true";
            connectionString = "Server = AT1LDFONSECA\\SQLEXPRESS ; DataBase = SalidaDeMaterial; integrated security = true"; //Emmpresa
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
