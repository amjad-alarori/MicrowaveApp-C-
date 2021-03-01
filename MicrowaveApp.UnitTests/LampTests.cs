using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicrowaveApp.UnitTests
{
    [TestClass]
    public class LampTests
    {
        [TestMethod]
        public void TestConstructAndCheckForNull()
        {
            //Make an object Lamp
            Lamp lamp = new Lamp();
            Assert.IsTrue(lamp.StateMachine != null);
        }

        [TestMethod]
        public void TestLampDefaultState()
        {
            //Make an object Lamp
            Lamp lamp = new Lamp();
            Assert.IsTrue(lamp.StateMachine.IsInState(LampStates.Off));
        }

        [TestMethod]
        public void TestLampOnTrigger()
        {
            //Make an object Lamp
            Lamp lamp = new Lamp();
            //Fire lamp state to "on" by firing the "turnon" trigger
            lamp.StateMachine.Fire(LampTriggers.TurnOn);
            //Check if / Expect the lamp state is "on"
            Assert.IsTrue(lamp.StateMachine.IsInState(LampStates.On));
        }

        [TestMethod]
        public void TestLampOffOffTrigger()
        {
            //Make an object Lamp
            Lamp lamp = new Lamp();
            //Make an exception so that an invalid operation can be made, then change the state to off
            Assert.ThrowsException<System.InvalidOperationException>(() => lamp.StateMachine.Fire(LampTriggers.TurnOff));
        }

        [TestMethod]
        public void TestLampOffOnTrigger()
        {
            //Make an object Lamp
            Lamp lamp = new Lamp();
            //Fire lamp state to "on" by firing the "turnon" trigger
            lamp.StateMachine.Fire(LampTriggers.TurnOn);
            //Make an exception so that an invalid operation can be made, then change the state to on
            Assert.ThrowsException<System.InvalidOperationException>(() => lamp.StateMachine.Fire(LampTriggers.TurnOn));
        }

        [TestMethod]
        public void TestLampOnOffTrigger()
        {
            //Make an object Lamp
            Lamp lamp = new Lamp();
            //Fire the lamp state to on
            lamp.StateMachine.Fire(LampTriggers.TurnOn);
            //Fire the lampstate to off
            lamp.StateMachine.Fire(LampTriggers.TurnOff);
            //Check if / Expect the lamp state to be "off"
            Assert.IsTrue(lamp.StateMachine.IsInState(LampStates.Off));
        }
    }
}