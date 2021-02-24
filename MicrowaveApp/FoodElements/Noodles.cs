using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrowaveApp.Food
{
    public class Noodles : Meal
    {
        public Noodles() : base("Noodles")
        {
            GoodTimeToCook = 25;
            ImagePath = "FoodElements/Img/noodles.png";
        }
    }
}
