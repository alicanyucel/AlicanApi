using AlicanApi.Business.Abstract;
using AlicanApi.DataAccess.Abstract;
using AlicanApi.Models;

namespace AlicanApi.Business.Concrete
{
    public class StoreManager:IStoreService
    {
        private readonly IStoreDal _storeDal;
        public StoreManager(IStoreDal storeDal)
        {
            _storeDal = storeDal;
        }

        public IList<Store> GetStores()
        {
            return _storeDal.GetAll();
        }
    }
}
