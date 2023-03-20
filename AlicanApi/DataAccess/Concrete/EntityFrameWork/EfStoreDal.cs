using AlicanApi.DataAccess.Abstract;
using AlicanApi.DataAccess.Context;
using AlicanApi.Models;
using AlicanApi.Repositories.HospitalWebApi.GenericRepositoryPattern;
using System.Numerics;

namespace AlicanApi.DataAccess.Concrete.EntityFrameWork
{
    public class EfStoreDal : EfEntityRepositoryBase<Store, DataContext>, IStoreDal
    {

    }
}
