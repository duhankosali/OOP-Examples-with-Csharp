using OOP.GenericRepositoryDesignPattern.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.GenericRepositoryDesignPattern.DataAccess.Abstract
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
        // IEntityRepository'de bulunan methodlar otomatik olarak eklendi.
        // Ancak Employee'a ek olarak yazmak istediğimiz methodları burada tanımlayabiliriz.
    }
}
