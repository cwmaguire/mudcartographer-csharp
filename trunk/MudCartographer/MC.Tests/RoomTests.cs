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
        Point3D testPosition;
        Room testRoomPositioned;

        [SetUp]
        public void SetUp()
        {
            testPosition = new Point3D(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z);
            testRoomPositioned = new Room(testPosition);
        }

        [Test]
        public void CreateRoom()
        {
            Assert.AreEqual(testRoomPositioned.Position, testPosition);
        }

        [Test]
        public void ChangeRoomPosition()
        {
            testRoomPositioned.ChangePosition(TestConstants.POINT_2_X, TestConstants.POINT_2_Y, TestConstants.POINT_2_Z);
            Assert.AreEqual(testRoomPositioned.X, TestConstants.POINT_2_X);
            Assert.AreEqual(testRoomPositioned.Y, TestConstants.POINT_2_Y);
            Assert.AreEqual(testRoomPositioned.Z, TestConstants.POINT_2_Z);
        }

        [Test]
        public void Equals()
        {
            Assert.AreEqual(new Room(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z), 
                            new Room(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z));
            Assert.AreNotEqual(new Room(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z), 
                               new Room(TestConstants.POINT_2_X, TestConstants.POINT_2_Y, TestConstants.POINT_2_Z));
        }
    }
}
