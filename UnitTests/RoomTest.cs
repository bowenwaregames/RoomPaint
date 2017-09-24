using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomPaint;

namespace UnitTests
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void FloorArea()
        {
            double expectedArea = 225.0, width = 15.0, length = 15.0, height = 0.0;

            Room room = new Room(width, length, height);
            Assert.AreEqual(expectedArea, room.Area);
        }

        [TestMethod]
        public void RoomVolume()
        {
            double expectedVolume = 2250.0, width = 15.0, length = 15.0, height = 10.0;

            Room room = new Room(width, length, height);
            Assert.AreEqual(room.Volume, expectedVolume);
        }

        [TestMethod]
        public void PaintRoom()
        {
            int numOfCoats = 1;
            double expectedAmount = 4.8, width = 4.2, length = 6.1, height = 2.4;

            Room room = new Room(width, length, height);

            room.Windows.Add(new Window());
            room.Doors.Add(new Door(DoorType.Single));

            PaintService<Room> paintService = new PaintService<Room>(room);

            double result = paintService.PaintRoom(numOfCoats);

            result = Math.Round(result, 1);
            Assert.AreEqual(expectedAmount, result);
        }
    }
}