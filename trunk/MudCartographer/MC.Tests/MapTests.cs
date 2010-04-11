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
        Map testMap;

        [SetUp]
        public void Setup()
        {
            testMap = new Map();
        }

        [Test]
        public void AddRoom_CheckSizeWithOneRoom()
        {
            testMap.DeleteRoomsAndLinks();
            testMap.AddRoom(new Room(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z));
            Assert.AreEqual(testMap.GetNumberOfRooms(), 1);
        }

        [Test]
        public void AddLink_CheckSizeWithOneLink()
        {
            testMap.DeleteRoomsAndLinks();
            Room testStartRoom = new Room(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z);
            Room testEndRoom = new Room(TestConstants.POINT_2_X, TestConstants.POINT_2_Y, TestConstants.POINT_2_Z);
            testMap.AddRoom(testStartRoom);
            testMap.AddRoom(testEndRoom);

            testMap.AddLink(new Link(testStartRoom, testEndRoom));
            Assert.AreEqual(testMap.GetNumberOfLinks(), 1);
        }

        [Test]
        public void DeleteRoomsAndLinks()
        {
            testMap.DeleteRoomsAndLinks();
            Assert.AreEqual(testMap.GetNumberOfRooms(), 0);
            Assert.AreEqual(testMap.GetNumberOfLinks(), 0);
        }

        [Test]
        public void ClosestRoom()
        {
            testMap.DeleteRoomsAndLinks();

            Room testRoomToCompareWith = new Room(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z);
            testMap.AddRoom(testRoomToCompareWith);

            Point3D pointNearRoom = new Point3D(TestConstants.POINT_2_X, TestConstants.POINT_2_Y, TestConstants.POINT_2_Z);
            Point3D pointFarAway = new Point3D(TestConstants.POINT_3_X, TestConstants.POINT_3_Y, TestConstants.POINT_3_Z);
            Assert.AreEqual(testRoomToCompareWith, testMap.GetClosestRoomToPoint(pointNearRoom));
            Assert.AreNotEqual(testRoomToCompareWith, testMap.GetClosestRoomToPoint(pointFarAway));
        }

        [Test]
        public void DeleteSelectedRooms()
        {
            testMap.DeleteSelectedRooms();
            Assert.AreEqual(testMap.GetSelectedRooms().Count, 0);
        }

        [Test]
        public void AddRoomToSelectedRoom()
        {
            Room roomToSelect = new Room(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z);
            testMap.SelectASingleRoom(roomToSelect);
            Assert.AreEqual((Room)testMap.GetSelectedRooms()[0], roomToSelect);
        }

        [Test]
        public void LinkRoomToSelectedRooms()
        {
            testMap.DeleteRoomsLinksAndSelection();
            
            Room testStartRoom = new Room(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z);
            Room testEndRoom = new Room(TestConstants.POINT_2_X, TestConstants.POINT_2_Y, TestConstants.POINT_2_Z);
            testMap.AddRoom(testStartRoom);
            testMap.SelectASingleRoom(testStartRoom);
            testMap.LinkRoomToSelectedRooms(testEndRoom);
            Assert.IsTrue(testMap.Links.Contains(new Link(testStartRoom, testEndRoom)));
        }

        [Test]
        public void RemoveRoom()
        {
            testMap.DeleteRoomsLinksAndSelection();
            Room testRoom = new Room(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z);
            testMap.AddRoom(testRoom);
            testMap.SelectASingleRoom(testRoom);
            testMap.AddLink(testRoom, new Room(new Point3D(TestConstants.POINT_2_X, TestConstants.POINT_2_Y, TestConstants.POINT_2_Z)));
            testMap.DeleteRoom(testRoom);
            
            Assert.IsFalse(testMap.Rooms.Contains(testRoom));
            //TODO: Assert.IsFalse(testMap.Links.Contains(testRoom));
            Assert.IsFalse(testMap.SelectedRooms.Contains(testRoom));

        }
    }
}
