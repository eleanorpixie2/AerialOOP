using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AerialOOP;

namespace FlyingThingsTest
{
    [TestClass]
    public class AerialVehicleTest
    {
        [TestMethod]
        [ExpectedException(typeof(MissingMethodException),"Cannot create abstract instance")]
        public void TestAbstract()
        {
            var ae = Activator.CreateInstance<AerialVehicle>();
        }
    }
}
