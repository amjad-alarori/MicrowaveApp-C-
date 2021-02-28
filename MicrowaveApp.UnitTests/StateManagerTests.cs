using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace MicrowaveApp.UnitTests
{
    [TestClass]
    public class StateManagerTests
    {
        [TestMethod]
        public void MethodTest()
        {
            Timer timer = new Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Assert.IsTrue(true);
        }

        /*
         * Configure Microwave.StateMachine, when the state is in MicrowaveStates.Stopped, that the only trigger allowed to run is
         * MicrowaveTriggers.Start (if DoorStates.Closed).
         * When the Microwave.StateMachine changes to MicrowaveStates.Stopped state.
         * OnEntry is called internally. We use this to turn the lamp off and stop the timer
         */
        [TestMethod]
        public void TestTriggerstart()
        {
            Timer timer = new Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            //stateManager.Microwave.StateMachine.Configure(MicrowaveStates.Paused);
            //var start = StateManager.Microwave.StateMachine.IsInState((MicrowaveStates)MicrowaveTriggers.Start);
            //MicrowaveTriggers.Start;
            //Assert.IsTrue(true);
            Assert.AreEqual(MicrowaveTriggers.Start, MicrowaveStates.Running);
        }

        [TestMethod]
        public void TestTriggerStop()
        {
            Timer timer = new Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            stateManager.Microwave.StateMachine.Configure(MicrowaveStates.Paused);
            Assert.IsFalse(true);
        }

        /*[TestMethod] Tests unapproved
        public void TestRunningState()
        {
            Timer timer = new Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Assert.IsFalse(stateManager.Microwave.StateMachine.IsInState(MicrowaveStates.Running));
        }

        [TestMethod]
        public void TestDoorOpen()
        {
            Timer timer = new Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Assert.IsFalse(stateManager.Door.StateMachine.IsInState(DoorStates.Open));
        }

        [TestMethod]
        public void TestDoorCLosed()
        {
            Timer timer = new Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Assert.IsTrue(stateManager.Door.StateMachine.IsInState(DoorStates.Closed));
        }*/
    }
}