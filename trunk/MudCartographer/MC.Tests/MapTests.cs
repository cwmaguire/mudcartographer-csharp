using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MudCartographer;

namespace MC.Tests
{
    [TestFixture]
    class MapTests
    {
        [Test]
        public void addRoom_checkSizeWithOneRoom_returnsOne()
        {
            Map m = new Map();
            Room roomA = new Room(new Point3D(10, 10, 0));
            m.addRoom(roomA);
            bool result = m.getNumberofRooms() == 1;
            roomA = null;
            m = null;
            Assert.IsTrue(result, "number of rooms in map invalid");
        }

        [Test]
        public void addLink_checkSizeWithOneLink_returnsOne()
        {
            Map m = new Map();
            Room roomA = new Room(new Point3D(10, 10, 0));
            m.addRoom(roomA);
            m.addLink(new Link(roomA, roomA));
            bool result = m.getNumberOfLinks() == 1;
            roomA = null;
            m = null;
            Assert.IsTrue(result, "number of links in map invalid");
        }

        [Test]
        public void clear_clearMap_returnZeroRoomsZeroLinks()
        {
            Map m = new Map();
            Room roomA = new Room(new Point3D(10, 10, 0));
            m.addRoom(roomA);
            Link l = new Link(roomA, roomA);
            m.addLink(l);
            m.Clear();
            bool result = m.getNumberOfLinks() == 0 && m.getNumberofRooms() == 0;
            roomA = null;
            m = null;

        }
    }
}
