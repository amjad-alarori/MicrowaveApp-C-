using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace MicrowaveApp.UnitTests
{
    [TestClass]
    public class StateManagerTests
    {
        [TestMethod]
        public void Testdefaultstate()
        {
            Timer timer = new Timer();
            TextBox textBox = new TextBox();
            TimerWrapper timerWrapper = new TimerWrapper(timer, textBox);
            StateManager stateManager = new StateManager(timerWrapper);
        }
    }
}