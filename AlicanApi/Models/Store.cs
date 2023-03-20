using AlicanApi.Models.Abstract;
using AlicanApi.Repositories;

namespace AlicanApi.Models
{
    public class Store:EntityBase,IEntity
    {

       
        public double lat { get; set; }
        public double lng { get; set; }
    }
}
