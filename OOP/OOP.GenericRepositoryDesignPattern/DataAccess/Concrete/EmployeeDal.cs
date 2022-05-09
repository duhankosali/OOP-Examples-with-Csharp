using OOP.GenericRepositoryDesignPattern.DataAccess.Abstract;
using OOP.GenericRepositoryDesignPattern.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.GenericRepositoryDesignPattern.DataAccess.Concrete
{
    public class EmployeeDal : BaseRepository<Employee>, IEmployeeDal
    {
        // Ortak methodlar BaseRepository ile birlikte geldi.
        // Employee'a özel methodları buradan tanımlayabiliriz. (Önce IEmployeeDal'da tanımlama yapılır.)
    }
}
