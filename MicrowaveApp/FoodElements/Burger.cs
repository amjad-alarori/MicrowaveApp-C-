using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrowaveApp.Food
{
    public class Burger : Meal
    {
        public Burger() : base("Burger")
        {
            GoodTimeToCook = 30;
            ImagePath = "FoodElements/Img/burger.png";
        }
    }
}
