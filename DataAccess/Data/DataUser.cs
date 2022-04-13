using System;
using System.Data;
using System.Data.SqlClient;
using Common.Entities;
using DataAccess.SqlServer;

namespace DataAccess.Data
{
public class DataUser
    {
        public DataTable ListUsers()
        {

            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("usuario_listar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comand.ExecuteReader();
                table.Load(resultado);
                return table;

            }
            catch(Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();

            }

        }


        public string Exists(string valor)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("usuario_existe", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comand.Parameters.Add(parExiste);
                sqlCon.Open();
                comand.ExecuteNonQuery();
                rpta = Convert.ToString(parExiste.Value);

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rpta;

        }

        public string  Insert(User obj)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("usuario_insertar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.IdRol;
                comand.Parameters.Add("@idarea", SqlDbType.Int).Value = obj.IdArea;
                comand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                comand.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
                comand.Parameters.Add("@clave", SqlDbType.VarChar).Value = obj.Clave;
                comand.Parameters.Add("@estado", SqlDbType.VarChar).Value = obj.Estado;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";

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

        public DataTable  Search(string valor)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("usuario_buscar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlCon.Open();
                resultado = comand.ExecuteReader();
                table.Load(resultado);
                return table;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string Desactivate(int id)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("usuario_desactivar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";

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

        public string Activate(int id)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("usuario_activar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro.";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rpta;

        }

        public string Update (User obj)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("usuario_actualizar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.IdUsuario;
                comand.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.IdRol;
                comand.Parameters.Add("@idarea", SqlDbType.Int).Value = obj.IdArea;
                comand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                comand.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
                comand.Parameters.Add("@clave", SqlDbType.VarChar).Value = obj.Clave;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro.";


            }
            catch (Exception ex)
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
