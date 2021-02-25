namespace MicrowaveApp.FoodElements
{
    /// <summary>
    /// Burger class, extends Meal and can be selected from "Select meal" dropdown
    /// </summary>
    public class Burger : Meal
    {
        public Burger()
        {
            Name = "Burger";
            GoodTimeToCook = 30;
            ImagePath = "FoodElements/Img/Burger.png";
        }
    }
}