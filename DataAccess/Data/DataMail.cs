using System;
using System.Data;
using System.Data.SqlClient;
using DataAccess.SqlServer;
using Common.Cache;


namespace DataAccess.Data
{
    public class DataMail
    {
        public DataTable traerCorreo(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("traerCorreo", sqlCon);
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

        public string actualizar(MailData obj)
        {

            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("actualizar_correo", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@idCorreo", SqlDbType.Int).Value = obj.IdCorreo;
                command.Parameters.Add("@senderMail", SqlDbType.VarChar).Value = obj.SenderMail;
                command.Parameters.Add("@correo_password", SqlDbType.VarChar).Value = obj.Password;
                command.Parameters.Add("@correo_host", SqlDbType.VarChar).Value = obj.Host;
                command.Parameters.Add("@correo_port", SqlDbType.VarChar).Value = obj.Port;
                command.Parameters.Add("@correo_ssl", SqlDbType.VarChar).Value = obj.Ssl;
                sqlCon.Open();
                rpta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro.";

                    
            }
            catch(Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();

            }
            return rpta;
        }

    }
}
