using OOP.GenericRepositoryDesignPattern.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.GenericRepositoryDesignPattern.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        // IEntityRepository'de bulunan methodlar otomatik olarak eklendi.
        // Ancak Product'a ek olarak yazmak istediğimiz methodları burada tanımlayabiliriz.
    }
}
