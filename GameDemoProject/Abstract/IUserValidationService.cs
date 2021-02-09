using GameDemoProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Abstract
{
    interface IUserValidationService
    {
        bool CheckPerson(Person person);
    }
}
