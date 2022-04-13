using System;
using System.Data;
using DataAccess.Data;
using Common.Entities;
namespace Domain
{
  public class DomainRequest
    {
        
        public static DataTable ListRequestUserApplicant(int valor, string valor_autorizacion, string valor_visto_bueno, string valor_texto)
        {
            DataRequest data = new DataRequest();
            return data.ListRequestUserApplicant(valor, valor_autorizacion, valor_visto_bueno, valor_texto);
        }
        public static DataTable ListRequestSurveillance(string valor_solicitud,string valor_texto)
        {
            DataRequest data = new DataRequest();
            return data.ListRequestSurveillance(valor_solicitud, valor_texto);
        }
        public static DataTable ListRequestUserAuthorizer(int valor, string valor_autorizacion, string valor_visto_bueno, string valor_texto)
        {
            DataRequest data = new DataRequest();
            return data.ListRequestUserAuthorizer(valor, valor_autorizacion, valor_visto_bueno, valor_texto);
        }
        public static DataTable ListRequestUserFinance(int valor, string valor_visto_bueno, string valor_texto)
        {
            DataRequest data = new DataRequest();
            return data.ListRequestUserFinance(valor, valor_visto_bueno, valor_texto);
        }

        public static DataTable QueryDateApplicant(int valor,DateTime fechaInicio, DateTime fechaFin)
        {
            DataRequest data = new DataRequest();
           return data.QueryDateApplicant(valor,fechaInicio, fechaFin);

        }
        public static DataTable QueryDateSurveillance(DateTime fechaInicio, DateTime fechaFin)
        {
            DataRequest data = new DataRequest();
            return data.QueryDateSurveillance(fechaInicio, fechaFin);

        }
        public static DataTable QueryDateAuthorizer(int valor, DateTime fechaInicio, DateTime fechaFin)
        {
            DataRequest data = new DataRequest();
            return data.QueryDateAuthorizer(valor, fechaInicio, fechaFin);
        }
        public static DataTable QueryDateFinance(int valor, DateTime fechaInicio, DateTime fechaFin)
        {
            DataRequest data = new DataRequest();
            return data.QueryDateFinance(valor, fechaInicio, fechaFin);
        }
        public static DataTable QueryDateFinanceGeneral(DateTime fechaInicio, DateTime fechaFin)
        {
            DataRequest data = new DataRequest();
            return data.QueryDateFinanceGeneral(fechaInicio, fechaFin);
        }

        public static DataTable QueryDateGeneral(DateTime fechaInicio, DateTime fechaFin)
        {
            DataRequest data = new DataRequest();
            return data.QueryDateGeneral(fechaInicio, fechaFin);
        }
        public static DataTable ListDetail(int valor)
        {
            DataRequest data = new DataRequest();
            return data.ListDetail(valor);
        }

        public static string Authorize(int id)
        {
            DataRequest data = new DataRequest();
            return data.Authorize(id);
        }
        public static string Confirm(int id, string valor)
        {
            DataRequest data = new DataRequest();
            return data.Confirm(id, valor);
        }
        public static string VoBo(int id)
        {
            DataRequest data = new DataRequest();
            return data.VoBo(id);
        }

        public static string Activate(int id)
        {
            DataRequest data = new DataRequest();
            return data.Activate(id);
        }
        public static string ToRefuse(int id)
        {
            DataRequest data = new DataRequest();
            return data.ToRefuse(id);
        }
        public static string ToCancel(int id)
        {
            DataRequest data = new DataRequest();
            return data.ToCancel(id);
        }
        public static string CancelGeneral(int id)
        {
            DataRequest data = new DataRequest();
            return data.CancelGeneral(id);
        }
        public static DataTable ListRequestUserFinanceGeneral(string valor_autorizacion, string valor_visto_bueno, string valor_texto, string valor_estado)
        {
            DataRequest data = new DataRequest();
            return data.ListRequestUserFinanceGeneral(valor_autorizacion, valor_visto_bueno, valor_texto, valor_estado);
        }
        public static DataTable ListRequestGeneralReport(string valor_autorizacion, string valor_visto_bueno, string valor_texto, string valor_estado, string estatus_salida, string tipo_salida)
        {
            DataRequest data = new DataRequest();
            return data.ListRequestGeneralReport(valor_autorizacion, valor_visto_bueno, valor_texto, valor_estado, estatus_salida, tipo_salida);
        }
    }
}
