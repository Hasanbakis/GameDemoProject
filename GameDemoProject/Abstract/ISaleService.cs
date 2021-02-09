
using GameDemoProject.Concrete;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Abstract
{
    interface ISaleService
    {
        void Sale(Person person, Game game, Campaign campign);
    }
}
