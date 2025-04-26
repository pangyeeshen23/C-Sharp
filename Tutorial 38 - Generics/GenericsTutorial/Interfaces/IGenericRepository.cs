using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTutorial.Interfaces
{
    interface IGenericRepository<T>
    {
        public void Add(T entity)
        {

        }

        public void Remove(T entity)
        {

        }
    }
}
