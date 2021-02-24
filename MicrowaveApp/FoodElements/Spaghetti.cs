using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrowaveApp.Food
{
    public class Spaghetti : Meal
    {
        public Spaghetti() : base("Spaghetti")
        {
            GoodTimeToCook = 15;
            ImagePath = "FoodElements/Img/spageth.png";
        }
    }
}
