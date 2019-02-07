using Microsoft.VisualStudio.TestTools.UnitTesting;
using AerialOOP;

namespace FlyingThingsTest
{
    [TestClass]
    public class EngineTest
    {
        Engine engine;

        public EngineTest()
        {
            engine = new Engine();
        }

        [TestMethod]
        public void TestAbout()
        {
            //Arrange
            string startedAbout;
            string stoppedAbout;

            //Act
            stoppedAbout = engine.About();

            engine.IsStarted = true;
            startedAbout = engine.About();

            //Assert
            Assert.AreEqual(stoppedAbout, this.engine + " is not started");
            Assert.AreEqual(startedAbout, this.engine + " is started");

        }

        [TestMethod]
        public void TestStart()
        {
            //Arrange
            bool isStarted;

            //Act
            engine.Start();
            isStarted = engine.IsStarted;

            //Assert
            Assert.AreEqual(isStarted, true);
        }

        [TestMethod]
        public void TestStop()
        {
            //Arrange
            bool isStarted;

            //Act
            engine.IsStarted = true;
            engine.Stop();
            isStarted = engine.IsStarted;

            //Assert
            Assert.AreEqual(isStarted, false);
        }
    }
}
