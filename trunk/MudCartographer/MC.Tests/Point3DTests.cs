using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MudCartographer;

namespace MC.Tests
{
    [TestFixture]
    class Point3DTests
    {
        [Test]
        public void createPoint_constructor_NoReturn()
        {
            Point3D p = new Point3D(10, 10, 0);
            bool result = (p[0] == 10 && p[1] == 10 && p[2] == 0);
            Assert.IsTrue(result, "verify point3D constructor");
        }
    }
}
