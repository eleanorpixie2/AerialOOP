using Microsoft.VisualStudio.TestTools.UnitTesting;
using AerialOOP;

namespace FlyingThingsTest
{
    [TestClass]
    public class AirplaneTest
    {
        Airplane plane;

        public AirplaneTest()
        {
            plane = new Airplane();
        }

        [TestMethod]
        public void TestAbout()
        {
            //arrange
            int currentAltitude = plane.CurrentAltitude;
            int maxAltitude = plane.MaxAltitude;
            Engine engine = plane.Engine;
            string testString = "This " + this.plane + " has a max altitude of " + maxAltitude
                + " ft. \nIts current altitude is " + currentAltitude + "ft."
                + "\n" + engine.About();

            //Act
            string planeAbout = plane.About();

            //Assert
            Assert.AreEqual(planeAbout, testString);
        }


        [TestMethod]
        public void TestStartEngine()
        {
            //arrange
            bool isStarted = false;

            //Act
            plane.StartEngine();
            isStarted = plane.Engine.IsStarted;

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
            plane.StopEngine();
            EngineIsNotStarted = plane.TakeOff();

            plane.StartEngine();
            EngineIsStarted = plane.TakeOff();
            isFlying = plane.IsFlying;

            //Assert
            Assert.AreEqual(EngineIsNotStarted, this.plane + " can't fly, its engine is not started");
            Assert.AreEqual(EngineIsStarted, this.plane + " is flying");
            Assert.AreEqual(isFlying, true);
        }

        [TestMethod]
        public void TestFlyUp()
        {
            //arrange
            int currentAltitude = plane.CurrentAltitude;
            int upDefaultAmount;
            int upSpecifiedAmount;

            //Act
            plane.IsFlying = true;
            plane.FlyUp();
            upDefaultAmount= plane.CurrentAltitude;

            plane.FlyUp(5000);
            upSpecifiedAmount = plane.CurrentAltitude;

            //Assert
            Assert.AreEqual(currentAltitude, 0);
            Assert.AreEqual(upDefaultAmount, currentAltitude + 1000);
            Assert.AreEqual(upSpecifiedAmount, currentAltitude + 6000);
        }

        [TestMethod]
        public void TestFlyDown()
        {
            //arrange
            int currentAltitude = plane.CurrentAltitude = 7000;
            int downDefaultAmount;
            int downSpecifiedAmount;

            //Act
            plane.IsFlying = true;
            plane.FlyDown();
            downDefaultAmount = plane.CurrentAltitude;

            plane.FlyDown(5000);
            downSpecifiedAmount = plane.CurrentAltitude;

            //Assert
            Assert.AreEqual(currentAltitude, 7000);
            Assert.AreEqual(downDefaultAmount, currentAltitude - 1000);
            Assert.AreEqual(downSpecifiedAmount, currentAltitude - 6000);
        }

        [TestMethod]
        public void TestStopEngine()
        {
            //Arrange
            bool engineIsOn=plane.Engine.IsStarted;
            bool isFlying = plane.IsFlying = true;

            //Act
            plane.StartEngine();
            engineIsOn = plane.Engine.IsStarted;

            plane.StopEngine();
            engineIsOn = plane.Engine.IsStarted;
            isFlying = plane.IsFlying;

            //Assert
            Assert.AreEqual(engineIsOn, false);
            Assert.AreEqual(isFlying, false);
        }
    }
}
