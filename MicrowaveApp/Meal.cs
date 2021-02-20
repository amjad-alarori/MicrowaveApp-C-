using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Stateless;
using Stateless.Graph;

namespace MicrowaveApp
{
    public class Meal
    {
        public string Name { get; set; }
        public int GoodTimeToCook { get; set; }
        public string ImagePath { get; set; }
        private int CookingMargin = 4;
        private int _cookTime = 0;
        public StateMachine<meal_State, meal_Triggers> StateMachine;
        /// <summary>
        /// Default Meal constructor
        /// </summary>
        /// <param name="Fname">Name of food</param>
        public Meal(string Fname)
        {
            Name = Fname;
            //Make new statemachine object and set default state
            StateMachine = new StateMachine<meal_State, meal_Triggers>(meal_State.Raw);
            //When state raw(default) states that are permitted are .Burn and .Finished

            // Als state .Raw is, mag je de state naar Finished zetten via de .Finish trigger
            StateMachine.Configure(meal_State.Raw)
                .Permit(meal_Triggers.Finish, meal_State.Finished);
            // Default is raw, raw => finished, finished => burned
            StateMachine.Configure(meal_State.Finished)
                .Permit(meal_Triggers.Burn, meal_State.Burned);
        }
        //Set states
        //todo look up what enum is
        public enum meal_State
        {
            Finished,
            Raw,
            Burned
        }
        //Raw is the default state
        public enum meal_Triggers
        {
            //Trigger finish is for our state Finished
            Finish,
            //Trigger burned is for our state Burned
            Burn
        }
        
        /// <summary>
        /// Increase internal _cookTime by one every second (Tick) and check if meal is cooked or burned
        /// </summary>
        public void Tick()
        {
            _cookTime++; // CookTime += 1

            // Finished
            if (_cookTime == (GoodTimeToCook - CookingMargin))
            {
                StateMachine.Fire(meal_Triggers.Finish);
            }
           
            // Burned
            if (_cookTime == (GoodTimeToCook + CookingMargin))
            {
                StateMachine.Fire(meal_Triggers.Burn);
            }
        }
       
    }
}
