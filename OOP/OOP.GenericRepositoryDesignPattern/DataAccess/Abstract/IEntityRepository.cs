using OOP.GenericRepositoryDesignPattern.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.GenericRepositoryDesignPattern.DataAccess.Abstract
{
    public interface IEntityRepository<T>
        where T: class, IEntity, new() // T için zorunlu koyduğumuz şartlar --> class (referans tipli) olmalı, IEntity interface'den kalıtım alması gerekiyor, newlenebilir yapıda olması gerekiyor (parametresiz bir constructor olmalı).
    {
        // Temel CRUD işlemleri burada gerçekleştirilir.
        void Create(T entity);     // Create
        List<T> GetAll();            // Read
        T Get();
        void Update(T entity);     // Update
        void Delete(int entityId);     // Delete --> ID ye göre delete işlemi.      
    }
}
