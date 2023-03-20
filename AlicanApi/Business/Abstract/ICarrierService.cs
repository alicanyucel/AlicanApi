using AlicanApi.Models;
using System.Numerics;

namespace AlicanApi.Business.Abstract
{
    public interface ICarrierService
    {
        IList<Carrier> GetCarriers();
    }
}
