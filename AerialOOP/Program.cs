using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester test = new Tester();
            test.AirplaneTest();
            Console.WriteLine("\n==================================================================\n");
            test.ToyPlaneTest();
            Console.WriteLine("\n==================================================================\n");
            test.DroneTest();
            Console.WriteLine("\n==================================================================\n");
            test.HelicopterTest();
            Console.WriteLine("\n==================================================================\n");
            test.AirportTest();
            Console.Read();
        }

        class Tester
        {
            public void AirplaneTest()
            {
                //Start of the test
                Console.WriteLine("\t\tFlying Vehicle Tester\n");
                Console.WriteLine("\n\tAirplane.cs\n");

                //create airplane object and display its intial about
                Airplane plane = new Airplane();
                Console.WriteLine(plane.About());

                //Attempt to make the plane take off
                Console.WriteLine("\n\tTakeOffTest\n");
                Console.WriteLine("Call TakeOff()\n"+plane.TakeOff());

                //start the engine and try again
                Console.WriteLine("\nCall StartEngine()");
                plane.StartEngine();
                Console.WriteLine("\nCall TakeOff()\n" + plane.TakeOff());

                //Try to make the plane fly up
                Console.WriteLine("\n\tFlyUpTest");
                //Make the plane go up a thousand feet
                Console.WriteLine("\nCall FlyUp() fly is 1000ft default");
                plane.FlyUp();
                Console.WriteLine(plane.About());

                //Make the plane go above its max
                Console.WriteLine("\nCall FlyUp(44000) fly up to 45000ft");
                plane.FlyUp(44000);
                Console.WriteLine(plane.About());

                //make the plane go to its max altitude
                Console.WriteLine("\nCall FlyUp(40000) fly to max altitude");
                plane.FlyUp(40000);
                Console.WriteLine(plane.About());

                //Try to make the plane fly down
                Console.WriteLine("\n\tFly Down Test");

                //Try to make the plane fly down more than its current altitude 
                Console.WriteLine("\nCall FlyDown(50000) Fly Down 50,000ft");
                plane.FlyDown(50000);
                Console.WriteLine(plane.About());

                //Try to make the plane fly down to 0
                Console.WriteLine("\nCall FlyDown(CurrentAltitude) this should land");
                plane.FlyDown(plane.CurrentAltitude);
                Console.WriteLine(plane.About());

                //Stop the Engine
                Console.WriteLine("\nCall StopEngine()");
                plane.StopEngine();
                Console.WriteLine(plane.About());

            }
            public void ToyPlaneTest()
            {
                //Start of the test
                Console.WriteLine("\t\tFlying Vehicle Tester\n");
                Console.WriteLine("\n\tToyPlane.cs\n");

                //create airplane object and display its intial about
                ToyPlane plane = new ToyPlane();
                Console.WriteLine(plane.About());

                //Attempt to make the plane take off
                Console.WriteLine("\n\tTakeOffTest\n");
                Console.WriteLine("Call TakeOff()\n" + plane.TakeOff());

                //Wind it up and try again
                Console.WriteLine("\nCall WindUp()");
                plane.WindUp();
                Console.WriteLine("\nCall TakeOff()\n" + plane.TakeOff());

                //start the engine and try again
                Console.WriteLine("\nCall StartEngine()");
                plane.StartEngine();
                Console.WriteLine("\nCall TakeOff()\n" + plane.TakeOff());

                //Try to make the plane fly up
                Console.WriteLine("\n\tFlyUpTest");
                //Make the plane go up a thousand feet
                Console.WriteLine("\nCall FlyUp() fly is 1000ft default");
                plane.FlyUp();
                Console.WriteLine(plane.About());

                //Make the plane go up 10 ft
                Console.WriteLine("\nCall FlyUp(10) fly up to 10ft");
                plane.FlyUp(10);
                Console.WriteLine(plane.About());

                //make the plane go to its max altitude
                Console.WriteLine("\nCall FlyUp(40) fly to max altitude");
                plane.FlyUp(40);
                Console.WriteLine(plane.About());

                //Try to make the plane fly down
                Console.WriteLine("\n\tFly Down Test");

                //Try to make the plane fly down more than its current altitude 
                Console.WriteLine("\nCall FlyDown(50000) Fly Down 50,000ft");
                plane.FlyDown(50000);
                Console.WriteLine(plane.About());

                //Try to make the plane fly down to 0
                Console.WriteLine("\nCall FlyDown(CurrentAltitude) this should land");
                plane.FlyDown(plane.CurrentAltitude);
                Console.WriteLine(plane.About());

                //UnWind it
                Console.WriteLine("\nCall UnWind()");
                plane.UnWind();
                Console.WriteLine(plane.About());

                //Stop the Engine
                Console.WriteLine("\nCall StopEngine()");
                plane.StopEngine();
                Console.WriteLine(plane.About());

            }

            public void DroneTest()
            {
                //Start of the test
                Console.WriteLine("\t\tFlying Vehicle Tester\n");
                Console.WriteLine("\n\tDrone.cs\n");

                //create airplane object and display its intial about
                Drone plane = new Drone();
                Console.WriteLine(plane.About());

                //Attempt to make the plane take off
                Console.WriteLine("\n\tTakeOffTest\n");
                Console.WriteLine("Call TakeOff()\n" + plane.TakeOff());

                //start the engine and try again
                Console.WriteLine("\nCall StartEngine()");
                plane.StartEngine();
                Console.WriteLine("\nCall TakeOff()\n" + plane.TakeOff());

                //Try to make the plane fly up
                Console.WriteLine("\n\tFlyUpTest");
                //Make the plane go up a thousand feet
                Console.WriteLine("\nCall FlyUp() fly is 1000ft default");
                plane.FlyUp();
                Console.WriteLine(plane.About());

                //Make the plane go above its max
                Console.WriteLine("\nCall FlyUp(300) fly up to 300ft");
                plane.FlyUp(300);
                Console.WriteLine(plane.About());

                //make the plane go to its max altitude
                Console.WriteLine("\nCall FlyUp(200) fly to max altitude");
                plane.FlyUp(200);
                Console.WriteLine(plane.About());

                //Try to make the plane fly down
                Console.WriteLine("\n\tFly Down Test");

                //Try to make the plane fly down more than its current altitude 
                Console.WriteLine("\nCall FlyDown(50000) Fly Down 50,000ft");
                plane.FlyDown(50000);
                Console.WriteLine(plane.About());

                //Try to make the plane fly down to 0
                Console.WriteLine("\nCall FlyDown(CurrentAltitude) this should land");
                plane.FlyDown(plane.CurrentAltitude);
                Console.WriteLine(plane.About());

                //Stop the Engine
                Console.WriteLine("\nCall StopEngine()");
                plane.StopEngine();
                Console.WriteLine(plane.About());

            }

            public void HelicopterTest()
            {
                //Start of the test
                Console.WriteLine("\t\tFlying Vehicle Tester\n");
                Console.WriteLine("\n\tHelicopter.cs\n");

                //create airplane object and display its intial about
                Helicopter plane = new Helicopter();
                Console.WriteLine(plane.About());

                //Attempt to make the plane take off
                Console.WriteLine("\n\tTakeOffTest\n");
                Console.WriteLine("Call TakeOff()\n" + plane.TakeOff());

                //start the engine and try again
                Console.WriteLine("\nCall StartEngine()");
                plane.StartEngine();
                Console.WriteLine("\nCall TakeOff()\n" + plane.TakeOff());

                //Try to make the plane fly up
                Console.WriteLine("\n\tFlyUpTest");
                //Make the plane go up a thousand feet
                Console.WriteLine("\nCall FlyUp() fly is 1000ft default");
                plane.FlyUp();
                Console.WriteLine(plane.About());

                //Make the plane go above its max
                Console.WriteLine("\nCall FlyUp(3500) fly up to 4500ft");
                plane.FlyUp(3500);
                Console.WriteLine(plane.About());

                //make the plane go to its max altitude
                Console.WriteLine("\nCall FlyUp(3500) fly to max altitude");
                plane.FlyUp(3500);
                Console.WriteLine(plane.About());

                //Try to make the plane fly down
                Console.WriteLine("\n\tFly Down Test");

                //Try to make the plane fly down more than its current altitude 
                Console.WriteLine("\nCall FlyDown(50000) Fly Down 50,000ft");
                plane.FlyDown(50000);
                Console.WriteLine(plane.About());

                //Try to make the plane fly down to 0
                Console.WriteLine("\nCall FlyDown(CurrentAltitude) this should land");
                plane.FlyDown(plane.CurrentAltitude);
                Console.WriteLine(plane.About());

                //Stop the Engine
                Console.WriteLine("\nCall StopEngine()");
                plane.StopEngine();
                Console.WriteLine(plane.About());

            }

            public void AirportTest()
            {
                //Start of the test
                Console.WriteLine("\t\tFlying Vehicle Tester\n");
                Console.WriteLine("\n\tAirport.cs\n");

                //create aerial vehicles and a airport object
                Helicopter plane = new Helicopter();
                Drone drone = new Drone();
                Airplane airplane = new Airplane();
                Airport port = new Airport(Guid.NewGuid().ToString(),2);
                List<AerialVehicle> vehicles = new List<AerialVehicle>()
                { drone, airplane };

                //Attempt to make the plane(s) take off
                Console.WriteLine("\n\tTakeOffTest\n");
                Console.WriteLine("Call TakeOff()\n" + port.TakeOff(plane));

                //Attempt to make all planes take off
                Console.WriteLine("\nCall AllTakeOff()\n" + port.AllTakeOff());

                //Try to make the plane(s) land at the airport
                Console.WriteLine("\n\tLandTest");
                //Make the plane land at the airport
                Console.WriteLine("\nCall Land(a) to land a single vehicle");
                Console.WriteLine(port.Land(plane));

                //Try to make the planes land at the airport
                Console.WriteLine("\nCall Land(List<AerialVehicle>) to land multiple vehicles");
                Console.WriteLine(port.Land(vehicles));

                // Attempt to make the plane(s) take off
                Console.WriteLine("\n\tTakeOffTest\n");
                Console.WriteLine("Call TakeOff()\n" + port.TakeOff(plane));

                //Attempt to make all planes take off
                Console.WriteLine("\nCall AllTakeOff()\n" + port.AllTakeOff());

            }
        }
    
    }

}
