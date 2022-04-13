using System;
using System.Data;
using System.Data.SqlClient;
using Common.Entities;
using DataAccess.SqlServer;

namespace DataAccess.Data
{
   public class DataRequest
    {
        
        public DataTable ListRequestUserApplicant(int valor, string valor_autorizacion, string valor_visto_bueno, string valor_texto)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_solicitante_listar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor", SqlDbType.Int).Value = valor;
                comand.Parameters.Add("@valor_autorizacion", SqlDbType.VarChar).Value = valor_autorizacion;
                comand.Parameters.Add("@valor_visto_bueno", SqlDbType.VarChar).Value = valor_visto_bueno;                
                comand.Parameters.Add("@valor_texto", SqlDbType.VarChar).Value = valor_texto;                
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

        public DataTable ListRequestSurveillance(string valor_solicitud, string valor_texto)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_vigilancia_listar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor_solicitud", SqlDbType.VarChar).Value = valor_solicitud;
                comand.Parameters.Add("@valor_texto", SqlDbType.VarChar).Value = valor_texto;
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
        public DataTable ListRequestUserAuthorizer(int valor, string valor_autorizacion, string valor_visto_bueno, string valor_texto)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_autorizador_listar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor", SqlDbType.Int).Value = valor;
                comand.Parameters.Add("@valor_autorizacion", SqlDbType.VarChar).Value = valor_autorizacion;
                comand.Parameters.Add("@valor_visto_bueno", SqlDbType.VarChar).Value = valor_visto_bueno;
                comand.Parameters.Add("@valor_texto", SqlDbType.VarChar).Value = valor_texto;
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
        public DataTable ListRequestUserFinance(int valor, string valor_visto_bueno, string valor_texto)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_finanzas_listar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor", SqlDbType.Int).Value = valor;
                comand.Parameters.Add("@valor_visto_bueno", SqlDbType.VarChar).Value = valor_visto_bueno;
                comand.Parameters.Add("@valor_texto", SqlDbType.VarChar).Value = valor_texto;
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

        public DataTable  QueryDateApplicant(int valor,DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_solicitante_consulta_fechas", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor", SqlDbType.Int).Value = valor;
                comand.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fechaInicio;
                comand.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fechaFin;
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

        public DataTable QueryDateSurveillance(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_vigilancia_consulta_fechas", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fechaInicio;
                comand.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fechaFin;
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

        public DataTable QueryDateAuthorizer(int valor, DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_autorizador_consulta_fechas", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor", SqlDbType.Int).Value = valor;
                comand.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fechaInicio;
                comand.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fechaFin;
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

        public DataTable QueryDateFinance(int valor, DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_finanzas_consulta_fechas", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor", SqlDbType.Int).Value = valor;
                comand.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fechaInicio;
                comand.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fechaFin;
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
        public DataTable QueryDateFinanceGeneral(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_finanzas_general_consulta_fechas", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fechaInicio;
                comand.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fechaFin;
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
        public DataTable QueryDateGeneral(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("reporte_general_solicitudes_fechas", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fechaInicio;
                comand.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fechaFin;
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

        public DataTable ListDetail(int valor)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_listar_detalle", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idsolicitud", SqlDbType.Int).Value = valor;
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

        public string Authorize(int id)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_autorizar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idsolicitud", SqlDbType.Int).Value = id;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo autorizar la solicitud.";

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

        public string Confirm(int id, string valor)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_confirmar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idsolicitud", SqlDbType.Int).Value = id;
                comand.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo confirmar la solicitud.";

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

        public string VoBo(int id)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_visto_bueno", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idsolicitud", SqlDbType.Int).Value = id;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo dar Vo. Bo. a la solicitud.";

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
        public string Activate(int id)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_activar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idsolicitud", SqlDbType.Int).Value = id;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar la solicitud.";

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

        public string ToRefuse(int id)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_rechazar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idsolicitud", SqlDbType.Int).Value = id;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo rechazar la solicitud.";

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
        public string ToCancel(int id)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_anular", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idsolicitud", SqlDbType.Int).Value = id;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo anular la solicitud.";

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

        public string CancelGeneral(int id)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_cancelar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@idsolicitud", SqlDbType.Int).Value = id;
                sqlCon.Open();
                rpta = comand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo cancelar la solicitud.";

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

        public DataTable ListRequestUserFinanceGeneral(string valor_autorizacion,string valor_visto_bueno, string valor_texto, string valor_estado)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("solicitud_finanzas_general_listar", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor_autorizacion", SqlDbType.VarChar).Value = valor_autorizacion;
                comand.Parameters.Add("@valor_visto_bueno", SqlDbType.VarChar).Value = valor_visto_bueno;
                comand.Parameters.Add("@valor_texto", SqlDbType.VarChar).Value = valor_texto;
                comand.Parameters.Add("@valor_estado", SqlDbType.VarChar).Value = valor_estado;

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

        public DataTable ListRequestGeneralReport(string valor_autorizacion, string valor_visto_bueno, string valor_texto, string valor_estado, string estatus_salida, string tipo_salida)
        {
            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("reporte_general_solicitudes", sqlCon);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("@valor_autorizacion", SqlDbType.VarChar).Value = valor_autorizacion;
                comand.Parameters.Add("@valor_visto_bueno", SqlDbType.VarChar).Value = valor_visto_bueno;
                comand.Parameters.Add("@valor_texto", SqlDbType.VarChar).Value = valor_texto;
                comand.Parameters.Add("@valor_estado", SqlDbType.VarChar).Value = valor_estado;
                comand.Parameters.Add("@estatus_salida", SqlDbType.VarChar).Value = estatus_salida;
                comand.Parameters.Add("@tipo_salida", SqlDbType.VarChar).Value = tipo_salida;


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
