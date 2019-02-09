using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialOOP
{
    public class ToyPlane:Airplane
    {
        //Check to see if the toy is wound up or not
        public bool IsWoundUp;

        //constructor
        public ToyPlane()
        {
            //set max to 50
            MaxAltitude = 50;
            IsWoundUp = false;
        }

        //override about to include if it is wound up or not
        public override string About()
        {
            return ("This " + this + " has a max altitude of " + MaxAltitude
                + " ft. \nIts current altitude is " + CurrentAltitude + "ft."
                + "\n" + GetEngineStartedString()
                +"\n" + GetWindUpString());
        }

        //returns a string based on if the toy is wound up or not
        public string GetWindUpString()
        {
            if (IsWoundUp)
            {
                return (this + " is wound up.");
            }
            else
            {
                return (this + " is not wound up.");
            }
        }

        //start the engine only if the plane has been wound up
        public override void StartEngine()
        {
            if (IsWoundUp)
                Engine.Start();
        }

        //Have the toy take off only if the engine is started and it is wound up
        public override string TakeOff()
        {
            if (Engine.IsStarted && IsWoundUp)
            {
                IsFlying = true;
                return (this + " is flying");
            }
            else if(!Engine.IsStarted && IsWoundUp)
            {
                return (this + " can't fly, its engine is not started");
            }
            else
            {
                return (this + " can't fly, it has not been wound up");
            }
        }

        //unwind the toy
        public void UnWind()
        {
            IsWoundUp = false;
        }

        //wind up the toy
        public void WindUp()
        {
            IsWoundUp = true;
        }
    }
}
