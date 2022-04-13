using System.Data;
using DataAccess.Data;


namespace Domain
{
     public class DomainDetailRequest
    {
        public static DataTable ListUnitOfMeasurement()
        {
            DataDetailRequest data = new DataDetailRequest();
            return data.ListUnitOfMeasurement();
        }
    }
}
