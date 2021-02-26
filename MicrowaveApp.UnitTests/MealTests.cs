using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MicrowaveApp.UnitTests
{
    [TestClass]
    public class MealTests
    {

        [TestMethod]
        public void TestConstructAndCheckForNull()
        {
            Meal meal = new Meal();
            Assert.IsTrue(meal.StateMachine != null);
        }

        [TestMethod]
        public void TestFoodRaw()
        {
            //Make object meal
            Meal meal = new Meal();
            //Default == raw
            Assert.IsTrue(meal.StateMachine.IsInState(MealStates.Raw));

        }

        [TestMethod]
        public void TestRawToFinished()
        {
            //Make object meal
            Meal meal = new Meal();
            //Default == raw
            meal.StateMachine.Fire(MealTriggers.Finish);
            Assert.IsTrue(meal.StateMachine.IsInState(MealStates.Finished));
        }

        [TestMethod]
        public void TestRawToBurned()
        {
            Meal meal = new Meal();
            //Default == raw
            Assert.ThrowsException<System.InvalidOperationException>(() => meal.StateMachine.Fire(MealTriggers.Burn));
        }

        [TestMethod]
        public void TestFinishedToBurned()
        {
            Meal meal = new Meal();
            meal.StateMachine.Fire(MealTriggers.Finish);
            meal.StateMachine.Fire(MealTriggers.Burn);
            Assert.IsTrue(meal.StateMachine.IsInState(MealStates.Burned));
        }

        [TestMethod]
        public void TestBurnedToRaw()
        {
            Meal meal = new Meal();
            //default == raw
            Assert.ThrowsException<System.InvalidOperationException>(() => meal.StateMachine.Fire(MealTriggers.Burn));
        }

        [TestMethod]
        public void TestBurnedToFinished()
        {
            Meal meal = new Meal();
            //default == raw
            meal.StateMachine.Fire(MealTriggers.Finish);
            meal.StateMachine.Fire(MealTriggers.Burn);
            Assert.ThrowsException<System.InvalidOperationException>(() => meal.StateMachine.Fire(MealTriggers.Finish));
        }
    }
}