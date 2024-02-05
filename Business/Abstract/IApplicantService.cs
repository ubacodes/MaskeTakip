using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        /// <summary>
        /// Bu method: PttManager üzerinden gönderilen person nesnesinin maskeyi alabilmesi için onaylama işlemini yapacak.
        /// </summary>
        /// <param name="person"></param>
        public void ApplyForMask(Person person);

        /// <summary>
        /// Bu method: Veritabanı üzerindeki person listesini getirecek.
        /// </summary>
        /// <returns></returns>
        public List<Person> GetList();

        /// <summary>
        /// Bu method: PttManager'ı içerisinden gönderilen person nesnesinin bir vatandaş olup olmadığının kontrolünü sağlayacak.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool CheckPerson(Person person);
    }
}
