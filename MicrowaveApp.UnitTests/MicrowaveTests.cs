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
            Timer timer = new Timer();
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
        public void TestMicrowaveStoppedToStopTrigger()
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
        public void TestMicrowaveStoppedToPauseTrigger()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Microwave microwave = stateManager.Microwave;
            Assert.ThrowsException<System.InvalidOperationException>(() => microwave.StateMachine.Fire(MicrowaveTriggers.Pause));
        }

        [TestMethod]
        public void TestMicrowaveRunningToStartTrigger()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Microwave microwave = stateManager.Microwave;
            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Start);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Running anyway
            }

            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Start);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Running anyway
            }

            // We expect that we cannot start the microwave when already in running state
            Assert.ThrowsException<System.InvalidOperationException>(() => microwave.StateMachine.Fire(MicrowaveTriggers.Start));
        }

        [TestMethod]
        public void TestMicrowaveRunningToStopTrigger()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Microwave microwave = stateManager.Microwave;
            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Start);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Running anyway
            }
           
            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Stop);
            }
            catch (Exception )
            {
                // On entry failed. But state changed to Running anyway
            }
            Assert.IsTrue(microwave.StateMachine.IsInState(MicrowaveStates.Stopped)); 
        }

        [TestMethod]
        public void TestMicrowaveRunningToPauseTrigger()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Microwave microwave = stateManager.Microwave;
            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Start);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Running anyway
            }

            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Pause);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Running anyway
            }
            Assert.IsTrue(microwave.StateMachine.IsInState(MicrowaveStates.Paused));
        }

        [TestMethod]
        public void TestMicrowavePausedtoStartTrigger()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Microwave microwave = stateManager.Microwave;
            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Start);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Running anyway
            }

            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Pause);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Paused anyway
            }
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
        public void TestMicrowavePausedToStopTrigger()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Microwave microwave = stateManager.Microwave;
            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Start);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Running anyway
            }

            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Pause);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Paused anyway
            }
            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Stop);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Stopped anyway
            }
            Assert.IsTrue(microwave.StateMachine.IsInState(MicrowaveStates.Stopped));
        }

        [TestMethod]
        public void TestMicrowavePausedToPauseTrigger()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
            Microwave microwave = stateManager.Microwave;
            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Start);
            }
            catch (Exception)
            {
                // On entry failed. But state changed to Running anyway
            }

            try
            {
                microwave.StateMachine.Fire(MicrowaveTriggers.Pause);
            }

            catch (Exception)
            {
                // On entry Failed. But state changed to Paused anyway
            }
           
            Assert.ThrowsException<System.InvalidOperationException>(() => microwave.StateMachine.Fire(MicrowaveTriggers.Pause));
        }
    }
}