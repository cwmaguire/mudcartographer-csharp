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
        Room testStartRoom;
        Room testEndRoom;

        [SetUp]
        public void Setup()
        {
            testStartRoom = new Room(new Point3D(TestConstants.POINT_1_X, TestConstants.POINT_1_Y, TestConstants.POINT_1_Z));
            testEndRoom = new Room(new Point3D(TestConstants.POINT_2_X, TestConstants.POINT_2_Y, TestConstants.POINT_2_Z));
        }

        [Test]
        public void CreateLink()
        {
            Link link = new Link(testStartRoom, testEndRoom);
            Link linkCopy = new Link(testStartRoom, testEndRoom);
            Link linkOpposite = new Link(testEndRoom, testStartRoom);

            Assert.IsTrue(link != null, "Link was not constructed");
            Assert.AreEqual(link.startRoom, testStartRoom, "Start room was not instantiated correctly");
            Assert.AreEqual(link.endRoom, testEndRoom, "End room was not instantiated correctly");
            Assert.AreEqual(link, linkCopy, "Links with identical rooms should be equal");
            Assert.AreNotEqual(link, linkOpposite, "Links should not be equal as the start and end rooms are switched");

        }
        [Test]
        public void Contains()
        {
            Link link = new Link(testStartRoom, testEndRoom);
            Assert.IsTrue(link.Contains(testStartRoom));
            Assert.IsTrue(link.Contains(testEndRoom));
            Assert.IsFalse(link.Contains(new Room(TestConstants.POINT_3_X, TestConstants.POINT_3_Y, TestConstants.POINT_3_Z)));

        }
    }
}
