using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    using FiguresLib;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IArea cir = new Circle(5);
            Assert.AreEqual(78.5, Math.Round(cir.Area(),1, MidpointRounding.ToZero));
        }

        [TestMethod]
        public void TestMethod2()
        {
            IArea cir = new Circle(-1);
            Assert.AreEqual(-1, Math.Round(cir.Area(),1, MidpointRounding.ToZero));
        }

        [TestMethod]
        public void TestMethod3()
        {
            IArea cir = new Circle();
            Assert.AreEqual(3.14, Math.Round(cir.Area(),2, MidpointRounding.ToZero));
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            IArea tr = new Triangle(2.5, 4.7,3.1);
            Assert.AreEqual(3.54, Math.Round(tr.Area(), 2,MidpointRounding.ToZero));
        }


        [TestMethod]
        public void TestMethod2()
        {
            IArea tr = new Triangle();
            Assert.AreEqual(0, Math.Round(tr.Area(), 2, MidpointRounding.ToZero));
        }
        

        [TestMethod]
        public void TestMethod3()
        {
            IArea tr = new Triangle(1,-2,1);
            Assert.AreEqual(-1, Math.Round(tr.Area(), 2, MidpointRounding.ToZero));
        }
        

        [TestMethod]
        public void TestMethod4()
        {
            Triangle tr = new Triangle(3,4,5);
            Assert.AreEqual(6.0, Math.Round(tr.Area(), 2, MidpointRounding.ToZero));

            Assert.IsTrue(tr.IsRightTriangle());
        }


    }

}
