using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicrowaveApp.UnitTests
{
    [TestClass]
    public class DoorTests
    {
        [TestMethod]
        public void TestConstructAndCheckForNull()
        {
            Door door = new Door();
            Assert.IsTrue(door.StateMachine != null);
        }
        
        [TestMethod]
        public void TestDoorOpenTrigger()
        {
            Door door = new Door();
            door.StateMachine.Fire(DoorTriggers.Open);
            Assert.IsTrue(door.StateMachine.IsInState(DoorStates.Open));
        }
        
        [TestMethod]
        public void TestDoorCloseCloseTrigger()
        {
            Door door = new Door();
            // Default state is closed.
            Assert.ThrowsException<System.InvalidOperationException>(() => door.StateMachine.Fire(DoorTriggers.Close));
        }
        
                
        [TestMethod]
        public void TestDoorOpenOpenTrigger()
        {
            Door door = new Door();
            door.StateMachine.Fire(DoorTriggers.Open);
            Assert.ThrowsException<System.InvalidOperationException>(() => door.StateMachine.Fire(DoorTriggers.Open));
        }
        
        [TestMethod]
        public void TestDoorOpenCloseTrigger()
        {
            Door door = new Door();
            door.StateMachine.Fire(DoorTriggers.Open);
            door.StateMachine.Fire(DoorTriggers.Close);
            Assert.IsTrue(door.StateMachine.IsInState(DoorStates.Closed));
        }
    }
}
