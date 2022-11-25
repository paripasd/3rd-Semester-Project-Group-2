using WebApi.ModelLayer;

namespace WebApi.DataAccessLayer
{
    public interface ISaleDataAccess
    {
        public bool CreateSale(Sale sale);
        public Sale FindSaleFromGameKey(string gameKey);
        public IEnumerable<Sale> GetAllSales();
        public bool DeleteSale(Sale sale);
    }
}
