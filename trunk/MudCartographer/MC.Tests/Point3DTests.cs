using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MudCartographer;
using MC.Cartography;

namespace MC.Tests
{
    [TestFixture]
    class Point3DTests
    {
        [Test]
        public void CreatePoint()
        {
            Point3D testPoint = new Point3D(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z);
            Assert.AreEqual(testPoint[Constants.X_COORD], TestConstants.POINT_1_X);
            Assert.AreEqual(testPoint[Constants.Y_COORD], TestConstants.POINT_1_Y);
            Assert.AreEqual(testPoint[Constants.Z_COORD], TestConstants.POINT_1_Z);
        }
    }
}
