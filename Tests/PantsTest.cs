//NOTE TO INSTRUCTOR ----->>>>> SEE PROGRAM.CS FOR PRINTED OBJECT




using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperclassBrady;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class PantsTest
    {
        [TestMethod]
        public void NormalConditions()
        {
            try
            {
                Pants pants = new Pants("large", "red");

                pants.DisplayClothing();
                pants.Wash();
                pants.Pack();
                pants.Hang();
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.IsTrue(true);
        }
    }
}
