using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        IApplicantService _applicantService;

        //Constructor method
        public PttManager(
            IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public string CheckMask(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPersons(Person person)
        {
            throw new NotImplementedException();
        }

        public void GiveMask(Person person)
        {            
            
            if ( _applicantService.CheckPerson(person) ) 
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");
        }
    }
}
