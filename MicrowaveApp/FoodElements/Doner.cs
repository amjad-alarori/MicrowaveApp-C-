using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrowaveApp.Food
{
    public class Doner : Meal
    {
        public Doner() : base("Doner")
        {
            GoodTimeToCook = 25;
            ImagePath = "FoodElements/Img/Doner.png";
        }
    }
}
