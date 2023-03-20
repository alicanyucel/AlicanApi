using AlicanApi.Business.Abstract;
using AlicanApi.Business.Concrete;
using AlicanApi.DataAccess.Abstract;
using AlicanApi.DataAccess.Concrete.EntityFrameWork;

namespace AlicanApi.Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddScoped<IStoreService, StoreManager>();
            serviceCollection.AddScoped<IStoreDal, EfStoreDal>();
            serviceCollection.AddScoped<ICarrierService, CarrierManager>();
            serviceCollection.AddScoped<ICarrierDal, EfCarrierDal>();
            
            return serviceCollection;

        }
    }
}