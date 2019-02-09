using Microsoft.VisualStudio.TestTools.UnitTesting;
using AerialOOP;
using System;
using System.Collections.Generic;

namespace FlyingThingsTest
{
    [TestClass]
    public class AirportTest
    {
        Airport port;

        public AirportTest()
        {
            port = new Airport(Guid.NewGuid().ToString());
        }

        [TestMethod]
        public void TestTakeOff()
        {
            //arrange
            //Empty airport
            string noVehicles;
            string notThere;

            //non-empty airport, no engines started
            string multiVehiclesNotStarted;
            string singleVehicleNotStarted;

            //non-empty airport, engines started
            string multiVehicles;
            string singleVehicle;

            //Aerial vehicle objects to put in airport
            Airplane plane = new Airplane();
            Drone drone = new Drone();
            Helicopter heli = new Helicopter();

            string multiNotStarted = "\n" + plane.GetType() + " can't fly, its engine is not started"
                                    +"\n"+ drone.GetType() + " can't fly, its engine is not started"
                                     + "\n" + heli.GetType() + " can't fly, its engine is not started";
            string multiStarted =  "\n" + drone.GetType() + " is flying"
                                     + "\n" + heli.GetType() + " is flying";

            //Act
            //nothing has been added to the airport
            noVehicles = port.AllTakeOff();
            notThere = port.TakeOff(plane);

            //Added vehicles to the airport
            port.Land(plane);
            port.Land(drone);
            port.Land(heli);
            multiVehiclesNotStarted = port.AllTakeOff();
            singleVehicleNotStarted = port.TakeOff(plane);

            //start vehicle engines
            plane.StartEngine();
            drone.StartEngine();
            heli.StartEngine();
            singleVehicle = port.TakeOff(plane);
            multiVehicles = port.AllTakeOff();


            //Assert
            Assert.AreEqual(noVehicles, "No vehicles to take off");
            Assert.AreEqual(notThere, plane.GetType() + " is not at this airport");
            Assert.AreEqual(multiVehiclesNotStarted, multiNotStarted);
            Assert.AreEqual(singleVehicleNotStarted, plane.GetType() + " can't fly, its engine is not started");
            Assert.AreEqual(multiVehicles, multiStarted);
            Assert.AreEqual(singleVehicle, plane.GetType() + " is flying");
        }


        [TestMethod]
        public void TestLand()
        {
            //arrange

            //Make new airport with specified max to test maxed out 
            //edge case
            Airport port2 = new Airport(Guid.NewGuid().ToString(), 2);
            //test strings
            string singleLanded;
            string multiLanded;
            string full;

            //Test Aerial vehicle objects and list
            Airplane plane = new Airplane();
            Drone drone = new Drone();
            Helicopter heli = new Helicopter();
            List<AerialVehicle> vehicles = new List<AerialVehicle>()
            { plane,drone};

            //Act
            //Add single and multi vehicles to the airport
            singleLanded = port.Land(heli);
            multiLanded = port.Land(vehicles);

            //max out specifed airport space and
            //then try to add a vehicle
            port2.Land(vehicles);
            full = port2.Land(heli);


            //Assert
            Assert.AreEqual(singleLanded, heli.GetType() + " has landed at the airport");
            Assert.AreEqual(multiLanded, "\n"+plane.GetType() + " has landed at the airport"
                                       + "\n" + drone.GetType() + " has landed at the airport");
            Assert.AreEqual(full, "Airport is full, " + heli.GetType() + " can't land here");
        }


       
    }
}
