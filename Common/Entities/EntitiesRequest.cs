using System;
using System.Data;

namespace Common.Entities
{
 public class EntitiesRequest
    {
        public int idSolicitante { get; set; }
        public int idAutorizador { get; set; }
        public int idVisto_bueno { get; set; }
        public int idCeCo { get; set; }
        public int idUso { get; set; }
        public int idUbicacion { get; set; }
        public int idTipo_salida { get; set; }
        public string entrega { get; set; }
        public string recibe { get; set; }
        public string vale_almacen { get; set; }
        public string dir_proveedor { get; set; }
        public string estatus_autorizacion { get; set; }
        public string estatus_visto_bueno { get; set; }
        public string estatus_salida { get; set; }
        public int estado { get; set; }
        public  DateTime fecha { get; set; }
        public DataTable detalles { get; set; }
        public string archivo { get; set; }
    }
}
