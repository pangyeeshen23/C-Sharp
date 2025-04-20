using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTutorial.Interfaces
{
    internal interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        void Remove(T entity);

    }
}
