using AlicanApi.Business.Abstract;
using AlicanApi.DataAccess.Abstract;
using AlicanApi.Models;
using System.Numerics;

namespace AlicanApi.Business.Concrete
{
    public class CarrierManager : ICarrierService
    {
        private readonly ICarrierDal _carrierDal;
        public CarrierManager(ICarrierDal carrierDal)
        {
            _carrierDal = carrierDal;
        }

        public IList<Carrier> GetCarriers()
        {
            return _carrierDal.GetAll();
        } 
    }
}
