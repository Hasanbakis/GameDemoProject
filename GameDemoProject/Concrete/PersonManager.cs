using GameDemoProject.Abstract;
using GameDemoProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Entities
{
     public class PersonManager : IPersonService
    {
        UserValidationManager _userValidationManager;
        public PersonManager(UserValidationManager userValidationManager)//Constructor
        {
            _userValidationManager = userValidationManager;

        }

        

        public void Condition(Person person)
        {
            if(_userValidationManager.CheckPerson(person))
            {
                Console.WriteLine("Kayıt işlemi yapıldı");

            }
            else
            {
                Console.WriteLine("Kayıt işlemi yapılamadı");

               
            }
          
        }

        public void Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public void Save(Person person)
        {
            throw new NotImplementedException();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
       

    }
}
