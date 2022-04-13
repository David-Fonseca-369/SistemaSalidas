using System.Data;
using DataAccess.Data;


namespace Domain
{
  public class DomainArea
    {
        public static DataTable ListArea()
        {
            DataArea data = new DataArea();
            return data.ListArea();
        }
    }
}
