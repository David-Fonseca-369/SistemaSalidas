using System.Data;
using DataAccess.Data;


namespace Domain
{
 public class DomainRol
    {
        public static DataTable ListRole()
        {
            DataRol data = new DataRol();
            return data.ListRole();
        }
    }
}
