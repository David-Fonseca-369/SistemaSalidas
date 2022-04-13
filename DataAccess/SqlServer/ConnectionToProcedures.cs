using System;
using System.Data.SqlClient;

namespace DataAccess.SqlServer
{
    class ConnectionToProcedures
    {
        private static ConnectionToProcedures Con = null;

        private ConnectionToProcedures()
        {

        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                //Cadena.ConnectionString = "Data Source = AT1LDFONSECA; Initial Catalog = SalidaDeMaterial; Persist Security Info = True; User ID = sa; Password = ltceelc50709"; //Credenciales
              // Cadena.ConnectionString = "Server = FONSECA\\SQLEXPRESS; DataBase = SalidaDeMaterial; integrated security = true"; //Casa
               Cadena.ConnectionString = "Server = AT1LDFONSECA\\SQLEXPRESS ; DataBase = SalidaDeMaterial; integrated security = true"; //Emmpresa
            }
            catch (Exception ex)
            {

                Cadena = null;
                throw ex;

            }
            return Cadena;

        }
        public static ConnectionToProcedures getInstancia()
        {
            if (Con == null)
            {
                Con = new ConnectionToProcedures();

            }
            return Con;

        }

    }
}
