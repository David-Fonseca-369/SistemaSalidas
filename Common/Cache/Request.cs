
using System;
using System.Data;

namespace Common.Cache
{
    public class Request
    {
        public static int idsSolicitud { get; set; }
        public static int idSolicitante { get; set; }
        public static int idAutorizador { get; set; }
        public static int idVisto_bueno { get; set; }
        public static int idCeCo { get; set; }
        public static int idUso { get; set; }
        public static int idUbicacion { get; set; }
        public static int idTipo_salida { get; set; }
        public static string entrega { get; set; }
        public static string recibe { get; set; }
        public static string vale_almacen { get; set; }
        public static string dir_proveedor { get; set; }
        public static string estatus_autorizaci0on { get; set; }
        public static string estatus_visto_bueno { get; set; }
        public static string estatus_salida { get; set; }
        public static int estado { get; set; }
        public static DateTime fecha { get; set; }
        public DataTable detalles { get; set; }
        public static string archivo { get; set; }

        public static int checkFrmRequest = 0;
    }
}
