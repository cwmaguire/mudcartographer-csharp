using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MudCartographer;

namespace MC.Tests
{
    [TestFixture]
    class RoomTests
    {
        [Test]
        public void createRoom_constructor_noReturn()
        {
            Point3D position = new Point3D(10, 10, 0);
            Room roomA = new Room(position);
            bool result = position.Equals(roomA.Position);
            Assert.IsTrue(result, "Verify coordinates of rooms");
        }

        [Test]
        public void changeRoomPosition_checkRoomChanges_returnNewPosition()
        {
            Room roomA = new Room(new Point3D(10, 10, 0));
            roomA.changePosition(new Point3D(20,20,0));
            bool result = roomA.Position.X == 20 && roomA.Position.Y == 20 && roomA.Position.Z == 0;
            Assert.IsTrue(result, "Check new coordinates of a room");
        }
    }
}
