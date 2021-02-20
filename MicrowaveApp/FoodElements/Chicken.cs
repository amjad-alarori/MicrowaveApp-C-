using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrowaveApp.Food
{
    public class Chicken : Meal
    {
        public Chicken() : base("Chicken")
        {
            GoodTimeToCook = 30;
            ImagePath = "FoodElements/Img/Chicken.jpg";
        }
    }
}
