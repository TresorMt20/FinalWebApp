using DataSide;
using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class ServicePerson : IPersonInterf
    {
        private ContextPersonDb _context;
        public ServicePerson(ContextPersonDb context)
        {
            _context = context;
        }

        public void Add(Person Newperson)
        {
            _context.Add(Newperson);
            _context.SaveChanges();
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.people;
        }
    }
}
