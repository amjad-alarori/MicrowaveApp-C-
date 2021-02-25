namespace MicrowaveApp.FoodElements
{
    /// <summary>
    /// Spaghetti class, extends Meal and can be selected from "Select meal" dropdown
    /// </summary>
    public class Spaghetti : Meal
    {
        public Spaghetti()
        {
            Name = "Spaghetti";
            GoodTimeToCook = 15;
            ImagePath = "FoodElements/Img/Spaghetti.png";
        }
    }
}