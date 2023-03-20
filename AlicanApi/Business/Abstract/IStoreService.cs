using AlicanApi.Models;
using System.Numerics;

namespace AlicanApi.Business.Abstract
{
    public interface IStoreService
    {
        IList<Store> GetStores();
    }
}
