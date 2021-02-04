//NOTE TO INSTRUCTOR ----->>>>> SEE PROGRAM.CS FOR PRINTED OBJECT




using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperclassBrady;
using System;

namespace Tests
{
    [TestClass]
    public class ShirtTests
    {
        [TestMethod]
        public void NormalConditions()
        {
            try
            {
                Shirt shirt = new Shirt("M", "gray", "short");

                shirt.DisplayClothing();
                shirt.Wash();
                shirt.Pack();
                shirt.Hang();
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void WrongTypeSleeves()
        {
            Assert.ThrowsException<ArgumentException>(() => new Shirt("M", "gray", "somewhat long"));
        }

        [TestMethod]
        public void WrongSize()
        {
            Assert.ThrowsException<ArgumentException>(() => new Shirt("medium", "gray", "long"));
        }
    }
}
