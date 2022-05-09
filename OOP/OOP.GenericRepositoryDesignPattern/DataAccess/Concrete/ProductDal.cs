using OOP.GenericRepositoryDesignPattern.DataAccess.Abstract;
using OOP.GenericRepositoryDesignPattern.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.GenericRepositoryDesignPattern.DataAccess.Concrete
{
    public class ProductDal : BaseRepository<Product>, IProductDal
    {
        // Ortak methodlar BaseRepository ile birlikte geldi.
        // Product'a özel methodları buradan tanımlayabiliriz. (Önce IProductDal'da tanımlama yapılır.)
    }
}
