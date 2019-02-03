using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerialOOP
{
    public class Engine
    {
        //Check whether the engine is started or not
        public bool IsStarted;

        //About the engine
        public string About()
        {
            //If the engine is on then return this
            if(IsStarted)
            {
                return (this + " is started");
            }
            //otherwise return this
            else
            {
                return (this + " is not started");
            }
        }

        //constructor
        public Engine()
        {
            IsStarted = false;
        }

        //Start the engine
        public void Start()
        {
            IsStarted = true;
        }

        //Stop the engine
        public void Stop()
        {
            IsStarted = false;
        }
    }
}
