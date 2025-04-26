using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsTutorial.Interfaces;

namespace GenericsTutorial.Repository
{
    internal class GenericRepository<T> : IGenericRepository<T>
    {
        public void Add(T entity)
        {
        }

        public void Remove(T entity)
        {

        }
    }
}
