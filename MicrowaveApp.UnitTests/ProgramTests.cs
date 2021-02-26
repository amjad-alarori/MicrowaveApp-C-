using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicrowaveApp.UnitTests
{
    public class ProgramTests
    {
        /// <summary>
        /// Test the main entry point for the application.
        /// </summary>
        [TestMethod] public void TestMainEntry()
        {
            Program.Main();
            // if here, not broken
            Assert.IsTrue(true);
        }
    }
}