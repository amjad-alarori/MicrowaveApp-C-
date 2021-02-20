using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrowaveApp.Food
{
    public class Meat : Meal
    {
        public Meat() : base("Meat")
        {
            GoodTimeToCook = 15;
            ImagePath = "FoodElements/Img/Meat.jpg";
        }
    }
}
