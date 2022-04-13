using System;
using System.Data;
using System.Data.SqlClient;
using DataAccess.SqlServer;


namespace DataAccess.Data
{
  public class DRolLogin
    {
      public DataTable BuscarId(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("buscarId", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlCon.Open();
                resultado = command.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable DataAuthorizer(int idAutorizador)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("datos_autorizador", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@idautorizador", SqlDbType.Int).Value = idAutorizador;
                sqlCon.Open();
                resultado = command.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public DataTable BuscarArea(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("buscar_area", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlCon.Open();
                resultado = command.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }


    }
}
