using System.Data;
using DataAccess.Data;
using Common.Entities;

namespace Domain
{
   public class DomainNewRequest
    {
        public static DataTable ListMaterialFor()
        {
            DataNewRequest data = new DataNewRequest();
            return data.ListMaterialFor();
        }
        public static DataTable ListMaterialLocation()
        {
            DataNewRequest data = new DataNewRequest();
            return data.ListMaterialLocation();
        }

        public static DataTable ListFinance()
        {
            DataNewRequest data = new DataNewRequest();
            return data.ListFinance();
        }

        public static DataTable ListCeCo()
        {
            DataNewRequest data = new DataNewRequest();
            return data.ListCeCo();
        }

        public static DataTable SearchCeCo(string valor)
        {
            DataNewRequest data = new DataNewRequest();
            return data.SearchCeCo(valor);
        }
        public static string InsertRequest (int idSolicitante, int idAutorizador, int idVisto_Bueno, int idCeco, int idUso, int idUbicacion, int idTipo_Salida, string entrega, string recibe, string vale_Alamacen, string dir_Proveedor, string archivo, DataTable detalles)
        {
            DataNewRequest data = new DataNewRequest();
            EntitiesRequest obj = new EntitiesRequest();
            obj.idSolicitante = idSolicitante;
            obj.idAutorizador = idAutorizador;
            obj.idVisto_bueno = idVisto_Bueno;
            obj.idCeCo = idCeco;
            obj.idUso = idUso;
            obj.idUbicacion = idUbicacion;
            obj.idTipo_salida = idTipo_Salida;
            obj.entrega = entrega;
            obj.recibe = recibe;
            obj.vale_almacen = vale_Alamacen;
            obj.dir_proveedor = dir_Proveedor;
            obj.archivo = archivo;
            obj.detalles = detalles;
            return data.InsertRequest(obj);
        }


    }
}
