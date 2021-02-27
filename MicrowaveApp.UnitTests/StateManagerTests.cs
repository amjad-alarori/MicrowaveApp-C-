using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace MicrowaveApp.UnitTests
{
    [TestClass]
    public class StateManagerTests
    {
        [TestMethod]
        public void TestStoppedState()
        {
            Timer timer = new Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Assert.IsTrue(stateManager.Microwave.StateMachine.IsInState(MicrowaveStates.Stopped));
        }

        [TestMethod]
        public void TestPausedState()
        {
            Timer timer = new Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Assert.IsFalse(stateManager.Microwave.StateMachine.IsInState(MicrowaveStates.Paused));
        }

        [TestMethod]
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
        }
    }
}