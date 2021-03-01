using System.Collections.Generic;
using Stateless;

namespace MicrowaveApp
{
    /// <summary>
    /// Define all states a meal can be in
    /// </summary>
    public enum MealStates
    {
        Finished,
        Raw,
        Burned
    }

    /// <summary>
    /// Define all states a lamp can be in
    /// </summary>
    public enum MealTriggers
    {
        Finish,
        Burn
    }

    public class Meal
    {
        protected string Name { get; set; }
        protected int GoodTimeToCook { get; set; }
        public string ImagePath { get; set; }

        private readonly int _cookingMargin = 4;

        public int _cookTime;

        private Dictionary<MealStates, string> dictionary = new Dictionary<MealStates, string>();

        private Dictionary<MealStates, string> dictionary = new Dictionary<MealStates, string>();

        // Construct new StateMachine with MealStates and MealTriggers. Also sets the StateMachine default state to MealStates.Raw (Raw)
        public StateMachine<MealStates, MealTriggers> StateMachine = new StateMachine<MealStates, MealTriggers>(MealStates.Raw);

        public Meal()
        {
            dictionary.Add(MealStates.Raw, "Raw 🤢");
            dictionary.Add(MealStates.Finished, "Finished 🙂");
            dictionary.Add(MealStates.Burned, "Burned ☢️");

            /*
            * Configure StateMachine, when the state is in MealState.Raw, that the only trigger allowed to run is MealState.Finish.
            * This trigger is also configured when called to set state to MealState.Finished
            */
            StateMachine.Configure(MealStates.Raw)
                .Permit(MealTriggers.Finish, MealStates.Finished);

            /*
            * Configure StateMachine, when the state is in MealState.Finished, that the only trigger allowed to run is MealState.Burn.
            * This trigger is also configured when called to set state to MealState.Burned
            */
            StateMachine.Configure(MealStates.Finished)
                .Permit(MealTriggers.Burn, MealStates.Burned);
        }

        /// <summary>
        /// Increase internal _cookTime by one (1) every second (Tick) and check if meal is cooked (MealStates.Finished) or burned (MealStates.Burned)
        /// </summary>
        public void Tick()
        {
            _cookTime++;

            // If _cookTime reaches the GoodTimeToCook with _cookingMargin it is finished
            if (_cookTime == (GoodTimeToCook - _cookingMargin))
            {
                StateMachine.Fire(MealTriggers.Finish);
            }

            // If _cookTime in on the last second within the margin it is burned
            if (_cookTime == (GoodTimeToCook + _cookingMargin))
            {
                StateMachine.Fire(MealTriggers.Burn);
            }
        }

        public string GetStateWithEmoji()
        {
            return dictionary[StateMachine.State];
        }

    }
}