using GameDemoProject.Abstract;
using KPSServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {

        public bool CheckPerson(Person person)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }

        
    }
}
