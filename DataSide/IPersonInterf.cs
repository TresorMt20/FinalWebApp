using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSide
{
  public  interface IPersonInterf
    {
        IEnumerable<Person> GetAll();

        void Add(Person Newperson);
    }
}
