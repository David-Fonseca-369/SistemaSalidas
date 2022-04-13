using System.Data;
using DataAccess.Data;

namespace Domain
{
  public class DomainAuthorizers
    {
        public static DataTable ListAuthorizersTI()
        {
            DataAuthorizers data = new DataAuthorizers();
            return data.ListAuthorizersTI();
        }
        public static DataTable ListAuthorizersMaterialForFacility()
        {
            DataAuthorizers data = new DataAuthorizers();
            return data.ListAuthorizersMaterialForFacility();
        }

        public static DataTable ListAuthorizersCLQProductionMaterial()
        {
            DataAuthorizers data = new DataAuthorizers();
            return data.ListAuthorizersCLQProductionMaterial();
        }
        public static DataTable ListAuthorizersSampleDeliveryByParcel()
        {
            DataAuthorizers data = new DataAuthorizers();
            return data.ListAuthorizersSampleDeliveryByParcel();
        }
        public static DataTable ListAuthorizersSecurity()
        {
            DataAuthorizers data = new DataAuthorizers();
            return data.ListAuthorizersSecurity();
        }
        public static DataTable ListAuthorizersRH()
        {
            DataAuthorizers data = new DataAuthorizers();
            return data.ListAuthorizersRH();
        }
    }
}
