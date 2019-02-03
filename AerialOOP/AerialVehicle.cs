using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialOOP
{
    abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }

        protected Engine Engine { get; set; }

        protected bool IsFlying { get; set; }

        protected int MaxAltitude { get; set; }

        //About this vehicle
        public virtual string About()
        {
            return ("This " + this + " has a max altitude of " + MaxAltitude
                + " ft. \nIts current altitude is " + CurrentAltitude + "ft."
                + "\n" + GetEngineStartedString());

        }

        //constructor
        public AerialVehicle()
        {
            CurrentAltitude = 0;
            Engine = new Engine();
            IsFlying = false;
        }

        //Fly down by a thousand
        public void FlyDown()
        {
            if(CurrentAltitude>=1000 && IsFlying)
            {
                CurrentAltitude -= 1000;
            }
        }

        //Fly down by specifed amount
        public void FlyDown(int HowManyFeet)
        {
            if(CurrentAltitude>=HowManyFeet && IsFlying)
            {
                CurrentAltitude -= HowManyFeet;
            }

        }

        //Fly up by a thousand
        public void FlyUp()
        {
            if (CurrentAltitude <= (MaxAltitude-1000) && IsFlying)
            {
                CurrentAltitude += 1000;
            }
        }

        //Fly up by specified amount
        public void FlyUp(int HowManyFeet)
        {
            if (CurrentAltitude <= (MaxAltitude-HowManyFeet) && IsFlying)
            {
                CurrentAltitude += HowManyFeet;
            }
        }

        //Get the engine about string
        protected string GetEngineStartedString()
        {
            return (this.Engine.About());
        }

        //Start the engine
        public virtual void StartEngine()
        {
            Engine.Start();
        }

        //Stop the engine
        public void StopEngine()
        {
            if (CurrentAltitude == 0)
            {
                Engine.Stop();
                IsFlying = false;
            }
        }

        //Have the plane take off
        public virtual string TakeOff()
        {
            if (Engine.IsStarted)
            {
                IsFlying = true;
                return (this + " is flying");
            }
            else
            {
                return (this + " can't fly, its engine is not started");
            }
        }
    }
}
