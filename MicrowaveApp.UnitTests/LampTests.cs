using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicrowaveApp.UnitTests
{
    [TestClass]
    public class LampTests
    {
        [TestMethod]
        public void TestConstructAndCheckForNull()
        {
            //een object maken van de lamp class
            Lamp lamp = new Lamp();
            Assert.IsTrue(lamp.StateMachine != null);
        }

        [TestMethod]
        public void TestLampDefaultState()
        {
            Lamp lamp = new Lamp();
            Assert.IsTrue(lamp.StateMachine.IsInState(LampStates.Off));
        }

        [TestMethod]
        public void TestLampOnTrigger()
        {
            //een object maken van de lamp class
            Lamp lamp = new Lamp();
            //De lamp state fire naar "on" doormiddel van de lamp trigger "turnon" te firen
            lamp.StateMachine.Fire(LampTriggers.TurnOn);
            //checken of de lamp state staat op "on"
            Assert.IsTrue(lamp.StateMachine.IsInState(LampStates.On));
        }

        [TestMethod]
        public void TestLampOffOffTrigger()
        {
            //een object maken van de lamp class
            Lamp lamp = new Lamp();
            //Vertellen dat er een exception gemaakt kan worden van een invalid operatie die gemaakt gaat worden, daarna de state veranderen naar turnoff
            Assert.ThrowsException<System.InvalidOperationException>(() => lamp.StateMachine.Fire(LampTriggers.TurnOff));
        }

        [TestMethod]
        public void TestLampOffOnTrigger()
        {
            //een object maken van de lamp class
            Lamp lamp = new Lamp();
            //De lamp state fire naar "on" doormiddel van de lamp trigger "turnon" te firen
            lamp.StateMachine.Fire(LampTriggers.TurnOn);
            //Vertellen dat er een exception gemaakt kan worden van een invalid operatie die gemaakt gaat worden, daarna de state veranderen naar turnon
            Assert.ThrowsException<System.InvalidOperationException>(() => lamp.StateMachine.Fire(LampTriggers.TurnOn));
        }

        [TestMethod]
        public void TestLampOnOffTrigger()
        {
            //een object maken van de lamp class
            Lamp lamp = new Lamp();
            //De lampstate firen naar on
            lamp.StateMachine.Fire(LampTriggers.TurnOn);
            //De lampstate firen naar off
            lamp.StateMachine.Fire(LampTriggers.TurnOff);
            //Checken of de lampstate staat op "off"
            Assert.IsTrue(lamp.StateMachine.IsInState(LampStates.Off));
        }
    }
}