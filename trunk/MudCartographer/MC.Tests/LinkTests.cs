using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MudCartographer;

namespace MC.Tests
{
    [TestFixture]
    class LinkTests
    {
        [Test]
        public void createLink_constructor_NoReturn()
        {
            Room roomA = new Room(new Point3D(10, 10, 0));
            Room roomB = new Room(new Point3D(20, 20, 0));
            Link link = new Link(roomA, roomB);
            Link linkCopy = new Link(roomA, roomB);
            Link linkOpposite = new Link(roomB, roomA);

            Assert.IsTrue(link != null, "Link was not constructed");
            Assert.AreEqual(link.startRoom, roomA, "Start room was not instantiated correctly");
            Assert.AreEqual(link.endRoom, roomB, "End room was not instantiated correctly");
            Assert.AreEqual(link, linkCopy, "Links with identical rooms should be equal");
            Assert.AreNotEqual(link, linkOpposite, "Links should not be equal as the start and end rooms are switched");

        }
    }
}
