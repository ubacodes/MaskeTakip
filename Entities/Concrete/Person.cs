using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person
    {
        //Class yapılarının default erişilebilirlik düzeyi internal iken değişken yapılarının default erişilebilirlik düzeyi
        //private dır.
        public string FirstName { get; set; }     //field
        public string LastName { get; set; }
        public int DateOfBirthYear { get; set; }
        public long NationalIdentity { get; set; }
    }
}
