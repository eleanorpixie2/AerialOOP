using Microsoft.VisualStudio.TestTools.UnitTesting;
using AerialOOP;

namespace FlyingThingsTest
{
    [TestClass]
    public class ToyPlaneTest
    {
        ToyPlane plane;

        public ToyPlaneTest()
        {
            plane = new ToyPlane();
        }
        
        [TestMethod]
        public void AboutTest()
        {
            //arrange
            int maxAltitude = plane.MaxAltitude;
            int currentAltitude = plane.CurrentAltitude;
            Engine engine = plane.Engine;
            string aboutToy;

            //Act
            aboutToy = plane.About();

            //Assert
            Assert.AreEqual(aboutToy, "This " + this.plane + " has a max altitude of " + maxAltitude
                + " ft. \nIts current altitude is " + currentAltitude + "ft."
                + "\n" + engine.About()
                + "\n" + plane.GetWindUpString());
        }

        [TestMethod]
        public void GetWindUpStringTest()
        {
            //arrange
            string notWoundUp;
            string woundUp;

            //Act
            notWoundUp = plane.GetWindUpString();

            plane.IsWoundUp = true;
            woundUp = plane.GetWindUpString();

            //Assert
            Assert.AreEqual(notWoundUp, this.plane + " is not wound up.");
            Assert.AreEqual(woundUp, this.plane + " is wound up.");
        }

        [TestMethod]
        public void TestStartEngine()
        {
            //arrange
            bool isStartedAndWound;
            bool isStartedAndNotWound;

            //act 
            plane.StartEngine();
            isStartedAndNotWound = plane.Engine.IsStarted;

            plane.IsWoundUp = true;
            plane.StartEngine();
            isStartedAndWound = plane.Engine.IsStarted;

            //Assert
            Assert.AreEqual(isStartedAndWound, true);
            Assert.AreEqual(isStartedAndNotWound, false);
        }

        [TestMethod]
        public void TestWindUp()
        {
            //arrange
            bool isWoundUp;

            //act
            plane.WindUp();
            isWoundUp = plane.IsWoundUp;

            //Assert
            Assert.AreEqual(isWoundUp, true);
        }

        [TestMethod]
        public void TestWindDown()
        {
            //arrange
            bool isUnwound;

            //act
            plane.IsWoundUp = true;
            plane.UnWind();
            isUnwound = plane.IsWoundUp;

            //Assert
            Assert.AreEqual(isUnwound, false);
        }

        [TestMethod]
        public void TestTakeOff()
        {
            //arrange
            string notRunningNotWound;
            string notRunningWound;
            string runningWound;
            bool isFlyingAttempt1;
            bool isFlyingAttempt2;
            bool isFlyingAttempt3;

            //Act
            plane.IsWoundUp = false;
            plane.Engine.IsStarted = false;
            notRunningNotWound = plane.TakeOff();
            isFlyingAttempt1 = plane.IsFlying;

            plane.IsWoundUp = true;
            plane.Engine.IsStarted = false;
            notRunningWound = plane.TakeOff();
            isFlyingAttempt2 = plane.IsFlying;

            plane.IsWoundUp = true;
            plane.Engine.IsStarted = true;
            runningWound = plane.TakeOff();
            isFlyingAttempt3 = plane.IsFlying;

            //Assert
            Assert.AreEqual(notRunningNotWound, this.plane + " can't fly, it has not been wound up");
            Assert.AreEqual(notRunningWound, this.plane + " can't fly, its engine is not started");
            Assert.AreEqual(runningWound, this.plane + " is flying");
            Assert.AreEqual(isFlyingAttempt1, false);
            Assert.AreEqual(isFlyingAttempt2, false);
            Assert.AreEqual(isFlyingAttempt3, true);

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
            upDefaultAmount = plane.CurrentAltitude;

            plane.FlyUp(50);
            upSpecifiedAmount = plane.CurrentAltitude;

            //Assert
            Assert.AreEqual(currentAltitude, 0);
            Assert.AreEqual(upDefaultAmount, currentAltitude);
            Assert.AreEqual(upSpecifiedAmount, currentAltitude + 50);
        }

        [TestMethod]
        public void TestFlyDown()
        {
            //arrange
            int currentAltitude = plane.CurrentAltitude = 50;
            int downDefaultAmount;
            int downSpecifiedAmount;

            //Act
            plane.IsFlying = true;
            plane.FlyDown();
            downDefaultAmount = plane.CurrentAltitude;

            plane.FlyDown(20);
            downSpecifiedAmount = plane.CurrentAltitude;

            //Assert
            Assert.AreEqual(currentAltitude, 50);
            Assert.AreEqual(downDefaultAmount, currentAltitude);
            Assert.AreEqual(downSpecifiedAmount, currentAltitude - 20);
        }

        [TestMethod]
        public void TestStopEngine()
        {
            //Arrange
            bool engineIsOn = plane.Engine.IsStarted;
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
