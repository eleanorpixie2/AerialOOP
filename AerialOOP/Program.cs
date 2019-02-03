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
        }
    
    }

}
