using Microsoft.VisualStudio.TestTools.UnitTesting;
using AerialOOP;

namespace FlyingThingsTest
{
    [TestClass]
    public class DroneTest
    {
        Drone drone;

        public DroneTest()
        {
            drone = new Drone();
        }

        [TestMethod]
        public void TestAbout()
        {
            //arrange
            int currentAltitude = drone.CurrentAltitude;
            int maxAltitude = drone.MaxAltitude;
            Engine engine = drone.Engine;
            string testString = "This " + this.drone + " has a max altitude of " + maxAltitude
                + " ft. \nIts current altitude is " + currentAltitude + "ft."
                + "\n" + engine.About();

            //Act
            string droneAbout = drone.About();

            //Assert
            Assert.AreEqual(droneAbout, testString);
        }


        [TestMethod]
        public void TestStartEngine()
        {
            //arrange
            bool isStarted = false;

            //Act
            drone.StartEngine();
            isStarted = drone.Engine.IsStarted;

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
            drone.StopEngine();
            EngineIsNotStarted = drone.TakeOff();

            drone.StartEngine();
            EngineIsStarted = drone.TakeOff();
            isFlying = drone.IsFlying;

            //Assert
            Assert.AreEqual(EngineIsNotStarted, this.drone + " can't fly, its engine is not started");
            Assert.AreEqual(EngineIsStarted, this.drone + " is flying");
            Assert.AreEqual(isFlying, true);
        }

        [TestMethod]
        public void TestFlyUp()
        {
            //arrange
            int currentAltitude = drone.CurrentAltitude;
            int upDefaultAmount;
            int upSpecifiedAmount;

            //Act
            drone.IsFlying = true;
            drone.FlyUp();
            upDefaultAmount= drone.CurrentAltitude;

            drone.FlyUp(400);
            upSpecifiedAmount = drone.CurrentAltitude;

            //Assert
            Assert.AreEqual(currentAltitude, 0);
            Assert.AreEqual(upDefaultAmount, currentAltitude);
            Assert.AreEqual(upSpecifiedAmount, currentAltitude + 400);
        }

        [TestMethod]
        public void TestFlyDown()
        {
            //arrange
            int currentAltitude = drone.CurrentAltitude = 500;
            int downDefaultAmount;
            int downSpecifiedAmount;

            //Act
            drone.IsFlying = true;
            drone.FlyDown();
            downDefaultAmount = drone.CurrentAltitude;

            drone.FlyDown(400);
            downSpecifiedAmount = drone.CurrentAltitude;

            //Assert
            Assert.AreEqual(currentAltitude, 500);
            Assert.AreEqual(downDefaultAmount, currentAltitude);
            Assert.AreEqual(downSpecifiedAmount, currentAltitude - 400);
        }

        [TestMethod]
        public void TestStopEngine()
        {
            //Arrange
            bool engineIsOn=drone.Engine.IsStarted;
            bool isFlying = drone.IsFlying = true;

            //Act
            drone.StartEngine();
            engineIsOn = drone.Engine.IsStarted;

            drone.StopEngine();
            engineIsOn = drone.Engine.IsStarted;
            isFlying = drone.IsFlying;

            //Assert
            Assert.AreEqual(engineIsOn, false);
            Assert.AreEqual(isFlying, false);
        }
    }
}
