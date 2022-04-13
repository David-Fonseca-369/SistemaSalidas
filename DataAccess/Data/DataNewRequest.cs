using System;
using System.Data;
using System.Data.SqlClient;
using Common.Entities;
using DataAccess.SqlServer;

namespace DataAccess.Data
{
   public class DataNewRequest
    {

        public DataTable ListMaterialFor()
        {


            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("matpara_listar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comand.ExecuteReader();
                table.Load(resultado);
                return table;

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

        public DataTable ListMaterialLocation()
        {


            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("matubiacion_listar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comand.ExecuteReader();
                table.Load(resultado);
                return table;

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

        public DataTable ListFinance()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("finanzas_listar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comand.ExecuteReader();
                table.Load(resultado);
                return table;
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

        public DataTable ListCeCo()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("ceco_listar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = comand.ExecuteReader();
                table.Load(resultado);
                return table;
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
        public DataTable SearchCeCo(string valor)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("ceco_buscar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlCon.Open();
                resultado = comand.ExecuteReader();
                table.Load(resultado);
                return table;

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

        public string InsertRequest(EntitiesRequest obj)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_insertar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idsolicitante", SqlDbType.Int).Value = obj.idSolicitante;
                comand.Parameters.Add("@idautorizador", SqlDbType.Int).Value = obj.idAutorizador;
                comand.Parameters.Add("@idvisto_bueno", SqlDbType.Int).Value = obj.idVisto_bueno;
                comand.Parameters.Add("@idceco", SqlDbType.Int).Value = obj.idCeCo;
                comand.Parameters.Add("@iduso", SqlDbType.Int).Value = obj.idUso;
                comand.Parameters.Add("@idubicacion", SqlDbType.Int).Value = obj.idUbicacion;
                comand.Parameters.Add("@idtipo_salida", SqlDbType.Int).Value = obj.idTipo_salida;
                comand.Parameters.Add("@entrega", SqlDbType.VarChar).Value = obj.entrega;
                comand.Parameters.Add("@recibe", SqlDbType.VarChar).Value = obj.recibe;
                comand.Parameters.Add("@vale_almacen", SqlDbType.VarChar).Value = obj.vale_almacen;
                comand.Parameters.Add("@dir_proveedor", SqlDbType.VarChar).Value = obj.dir_proveedor;
                comand.Parameters.Add("@archivo", SqlDbType.VarChar).Value = obj.archivo;
                comand.Parameters.Add("@detalle", SqlDbType.Structured).Value = obj.detalles;
                sqlCon.Open();
                comand.ExecuteNonQuery();
                rpta = "OK";

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
