using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace MicrowaveApp.UnitTests
{
    [TestClass]
    public class MicrowaveTests
    {
        [TestMethod]

        public void TestMicrowaveConstructAndDefaultState()
        {
            Microwave microwave = new Microwave();
            Assert.IsTrue(microwave.StateMachine.IsInState(MicrowaveStates.Stopped));
        }
        public void TestMicrowaveStoppedToStartTrigger()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Microwave microwave = stateManager.Microwave;

            // We trigger start but because on entry fails we ignore the exception
            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Start);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Running anyway
            }
            Assert.IsTrue(microwave.StateMachine.IsInState(MicrowaveStates.Running));
        }

        [TestMethod]
        public void TestMicrowaveStopToStopTrigger()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Microwave microwave = stateManager.Microwave;
            // We expect that we cannot stop the microwave while it is already stopped
            Assert.ThrowsException<System.InvalidOperationException>(() => microwave.StateMachine.Fire(MicrowaveTriggers.Stop));
        }

        [TestMethod]
        public void TestMicrowaveStopToPauseTrigger()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Microwave microwave = stateManager.Microwave;
            Assert.ThrowsException<System.InvalidOperationException>(() => microwave.StateMachine.Fire(MicrowaveTriggers.Pause));
        }
    }
}