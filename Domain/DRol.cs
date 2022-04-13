using DataAccess.Data;
using System.Data;

namespace Domain
{
     public class DRol
    {
        public static DataTable buscarId(string valor)
        {
            DRolLogin datos = new DRolLogin();
            return datos.BuscarId(valor);
        }
        public static DataTable DataAuthorizer(int idAutorizador)
        {
            DRolLogin datos = new DRolLogin();
            return datos.DataAuthorizer(idAutorizador);
        }

        public static DataTable buscarArea(string valor)
        {
            DRolLogin datos = new DRolLogin();
            return datos.BuscarArea(valor);
        }
    }
}
