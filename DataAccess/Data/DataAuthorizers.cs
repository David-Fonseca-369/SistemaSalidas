using System;
using System.Data;
using System.Data.SqlClient;
using DataAccess.SqlServer;

namespace DataAccess.Data
{
 public class DataAuthorizers
    {
        public DataTable ListAuthorizersTI()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("Autorizador_ti_listar", sqlCon);
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

        public DataTable ListAuthorizersMaterialForFacility()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("autorizador_material_instalaciones_listar", sqlCon);
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

        public DataTable ListAuthorizersCLQProductionMaterial()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("autorizador_material_produccion_clq", sqlCon);
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

        public DataTable ListAuthorizersSampleDeliveryByParcel()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("autorizador_muestras_paqueteria", sqlCon);
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
        public DataTable ListAuthorizersSecurity()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("autorizador_seguridad_listar", sqlCon);
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

        public DataTable ListAuthorizersRH()
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("autorizador_rh_listar", sqlCon);
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
    }

}
