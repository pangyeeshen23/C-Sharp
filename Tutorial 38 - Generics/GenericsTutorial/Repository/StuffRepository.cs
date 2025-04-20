using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsTutorial.Interfaces;

namespace GenericsTutorial.Repository
{
    class StuffRepository : IRepository<Stuff>
    {
        public void Add(Stuff entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Stuff entity)
        {
            throw new NotImplementedException();
        }
    }

    class Stuff : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
