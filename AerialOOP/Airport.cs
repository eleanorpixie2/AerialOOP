using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialOOP
{
    class Airport
    {
        protected int MaxVehicles;
        private List<AerialVehicle> Vehicles;
        string AirportCode { get; set; }

        //Default constructor that requires a code
        public Airport(string code)
        {
            AirportCode = code;
            //instantiate the variables, set the default max to 10
            Vehicles = new List<AerialVehicle>();
            MaxVehicles = 10;
        }

        //overloaded constructor
        public Airport(string code,int MaxVehicles)
        {
            //instatiate all the variables from passed in arguments
            AirportCode = code;
            Vehicles = new List<AerialVehicle>();
            this.MaxVehicles = MaxVehicles;
        }

        public string AllTakeOff()
        {
            if (Vehicles.Count > 0)
            {
                string sTakeOff = "";
                //List of vehicles that have left the airport
                List<AerialVehicle> flyingVehicles = new List<AerialVehicle>();
                //Try to take off
                foreach (AerialVehicle a in Vehicles)
                {
                    sTakeOff += "\n" + a.TakeOff();
                    if (a.Engine.IsStarted)
                    {
                        flyingVehicles.Add(a);
                    }
                }
                //Remove the vehicles that could take off
                foreach (AerialVehicle a in flyingVehicles)
                {
                    Vehicles.Remove(a);
                }
                //clear take off list
                flyingVehicles.Clear();

                //return string
                return sTakeOff;
            }
            else
            {
                return "No vehicles to take off";
            }
        }

        //Try to make a single vehicle take off
        public string TakeOff(AerialVehicle a)
        {
            if (Vehicles.Contains(a))
            {
                if (a.Engine.IsStarted)
                {
                    Vehicles.Remove(a);
                }
                return a.TakeOff();
            }
            else
            {
                return a.GetType() + " is not at this airport";
            }
        }

        //Land a single vehicle unless airport is full
        public string Land(AerialVehicle a)
        {
            if (Vehicles.Count < MaxVehicles)
            {
                a.IsFlying = false;
                a.CurrentAltitude = 0;
                Vehicles.Add(a);
                return (a.GetType() + " has landed at the airport");
            }
            else
            {
                return ("Airport is full, "+ a.GetType() + " can't land here");
            }
        }

        //Land several vehicles and add them to the airport
        public string Land(List<AerialVehicle> landing)
        {
            string sLand = "";
            foreach(AerialVehicle a in landing)
            {
                sLand += "\n" + Land(a);
            }
            return sLand;
        }
    }
}
