using System;
using System.Data;
using System.Data.SqlClient;
using DataAccess.SqlServer;


namespace DataAccess.Data
{
     public class DataArea
    {
        public DataTable ListArea()
        {


            SqlDataReader resultado;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = ConnectionToProcedures.getInstancia().CrearConexion();
                SqlCommand comand = new SqlCommand("area_listar", sqlCon);
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
