using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MicrowaveApp.FoodElements;

namespace MicrowaveApp.UnitTests
{
    [TestClass]
    
    public class TimerWrapperTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            TextBox textbox = new TextBox();
            Timer timer = new Timer();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textbox);
            Assert.IsTrue(true);
        }
        
        [TestMethod]
        public void Start()
        {
            TextBox textbox = new TextBox();
            Timer timer = new Timer();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textbox);
            timerWrapper.Start();
            Assert.IsTrue(timer.Enabled);
        }
        
        [TestMethod]
        public void Stop()
        {
            TextBox textbox = new TextBox();
            Timer timer = new Timer();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textbox);
            timerWrapper.Stop();
            Assert.IsTrue(timer.Enabled);
        }
        
        
        
        [TestMethod]
        public void StopStop()
        {
            TextBox textbox = new TextBox();
            Timer timer = new Timer();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textbox);
            timerWrapper.Start();
            timerWrapper.Stop();
            Assert.IsFalse(timer.Enabled);
        }
        
        
            
        [TestMethod]
        public void StopWithEvent()
        {
            TextBox textbox = new TextBox();
            Timer timer = new Timer();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textbox);
            timerWrapper.StopEvent += () =>
            {
                Assert.IsTrue(true);
            };
            timerWrapper.Stop();
        }

        [TestMethod]
        public void Tick()
        {
            TextBox textbox = new TextBox();
            Burger burger = new Burger();
            Timer timer = new Timer();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textbox);
            timerWrapper.Tick(burger);
            Assert.IsTrue(burger._cookTime == 1);
        }
    }
}