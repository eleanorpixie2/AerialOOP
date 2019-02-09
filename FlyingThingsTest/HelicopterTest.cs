using Microsoft.VisualStudio.TestTools.UnitTesting;
using AerialOOP;

namespace FlyingThingsTest
{
    [TestClass]
    public class HelicopterTest
    {
        Helicopter heli;

        public HelicopterTest()
        {
            heli = new Helicopter();
        }

        [TestMethod]
        public void TestAbout()
        {
            //arrange
            int currentAltitude = heli.CurrentAltitude;
            int maxAltitude = heli.MaxAltitude;
            Engine engine = heli.Engine;
            string testString = "This " + this.heli + " has a max altitude of " + maxAltitude
                + " ft. \nIts current altitude is " + currentAltitude + "ft."
                + "\n" + engine.About();

            //Act
            string heliAbout = heli.About();

            //Assert
            Assert.AreEqual(heliAbout, testString);
        }


        [TestMethod]
        public void TestStartEngine()
        {
            //arrange
            bool isStarted = false;

            //Act
            heli.StartEngine();
            isStarted = heli.Engine.IsStarted;

            //Assert
            Assert.AreEqual(isStarted, true);
        }

        [TestMethod]
        public void TestTakeOff()
        {
            //arrange
            string EngineIsStarted = "";
            bool isFlying = false;
            string EngineIsNotStarted = "";

            //Act
            heli.StopEngine();
            EngineIsNotStarted = heli.TakeOff();

            heli.StartEngine();
            EngineIsStarted = heli.TakeOff();
            isFlying = heli.IsFlying;

            //Assert
            Assert.AreEqual(EngineIsNotStarted, this.heli + " can't fly, its engine is not started");
            Assert.AreEqual(EngineIsStarted, this.heli + " is flying");
            Assert.AreEqual(isFlying, true);
        }

        [TestMethod]
        public void TestFlyUp()
        {
            //arrange
            int currentAltitude = heli.CurrentAltitude;
            int upDefaultAmount;
            int upSpecifiedAmount;

            //Act
            heli.IsFlying = true;
            heli.FlyUp();
            upDefaultAmount= heli.CurrentAltitude;

            heli.FlyUp(5000);
            upSpecifiedAmount = heli.CurrentAltitude;

            //Assert
            Assert.AreEqual(currentAltitude, 0);
            Assert.AreEqual(upDefaultAmount, currentAltitude + 1000);
            Assert.AreEqual(upSpecifiedAmount, currentAltitude + 6000);
        }

        [TestMethod]
        public void TestFlyDown()
        {
            //arrange
            int currentAltitude = heli.CurrentAltitude = 7000;
            int downDefaultAmount;
            int downSpecifiedAmount;

            //Act
            heli.IsFlying = true;
            heli.FlyDown();
            downDefaultAmount = heli.CurrentAltitude;

            heli.FlyDown(5000);
            downSpecifiedAmount = heli.CurrentAltitude;

            //Assert
            Assert.AreEqual(currentAltitude, 7000);
            Assert.AreEqual(downDefaultAmount, currentAltitude - 1000);
            Assert.AreEqual(downSpecifiedAmount, currentAltitude - 6000);
        }

        [TestMethod]
        public void TestStopEngine()
        {
            //Arrange
            bool engineIsOn=heli.Engine.IsStarted;
            bool isFlying = heli.IsFlying = true;

            //Act
            heli.StartEngine();
            engineIsOn = heli.Engine.IsStarted;

            heli.StopEngine();
            engineIsOn = heli.Engine.IsStarted;
            isFlying = heli.IsFlying;

            //Assert
            Assert.AreEqual(engineIsOn, false);
            Assert.AreEqual(isFlying, false);
        }
    }
}
