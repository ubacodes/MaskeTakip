using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CitizenManager : IApplicantService
    {
        //Bu Manager sınıfını bazı yerlerde Service olarak da görebilirsiniz. Benzer işlemleri yaparlar.
        //Bu projemiz içerisinde en temel olarak bir Person için maske dağıtımı işleminin yürütülmesini sağlayacaktır.

        /* Manager için Senaryolar;
         * Kişiyi kaydetmek istiyorum
         * Sistemde şuana kadar kaç kişi maske aldı?
         * Maske almayan kaç kişi kaldı?
         * Adam kaç kere maske aldı? veya Daha önce maske almış mı?
         * gibi senaryoları yönettiğimiz sınıf Manager bunları tek tek işleme alan ise method deniyor.
         */


        public void ApplyForMask(Person person)     //Parametre içerisinde bir Person nesnesi olması bir encapsulation örneğidir.
        {
            
        }

        public List<Person> GetList()
        {

            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody
                (person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
