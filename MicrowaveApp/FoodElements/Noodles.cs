namespace MicrowaveApp.FoodElements
{
    /// <summary>
    /// Noodles class, extends Meal and can be selected from "Select meal" dropdown
    /// </summary>
    public class Noodles : Meal
    {
        public Noodles()
        {
            Name = "Noodles";
            GoodTimeToCook = 25;
            ImagePath = "FoodElements/Img/Noodles.png";
        }
    }
}
