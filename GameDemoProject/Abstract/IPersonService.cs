using GameDemoProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Abstract
{
    interface IPersonService
    {
        void Save(Person person);
        void Delete(Person person);
        void Update(Person person);
        void Condition(Person person);
        
    }
}
