using System.Collections.Generic;

namespace RoomPaint
{
    /// <summary>
    /// Represents a room
    /// </summary>
    public class Room
    {
        public List<Wall> walls { get; set; }

        public double Area
        {
            get
            {
                return floorWidth * floorLength;
            }
        }

        public double Volume
        {
            get
            {
                return Area * roomHeight;
            }
        }

        public int Doors { get; set; }
        public int Windows { get; set; }

        private double floorWidth;
        private double floorLength;
        private double roomHeight;


        /// <summary>
        /// Create an instance of Room
        /// </summary>
        /// <param name="width">Width of the room</param>
        /// <param name="length">Length of the room</param>
        /// <param name="height">Height of the room</param>
        public Room(double width, double length, double height)
        {
            floorWidth = width;
            floorLength = length;
            roomHeight = height;

            walls = new List<Wall>
            {
                new Wall(width, height),
                new Wall(width, height),
                new Wall(length, height),
                new Wall(length, height)
            };
        }

        /// <summary>
        /// Create an instance of room
        /// </summary>
        /// <param name="width">Width of the room</param>
        /// <param name="length">Length of the room</param>
        /// <param name="height">Height of the room</param>
        /// <param name="doors">Number of room doors</param>
        /// <param name="windows">Number of room windows</param>
        public Room(double width, double length, double height, int doors, int windows)
        {
            floorWidth = width;
            floorLength = length;
            roomHeight = height;
            Doors = doors;
            Windows = windows;

            walls = new List<Wall>
            {
                new Wall(width, height),
                new Wall(width, height),
                new Wall(length, height),
                new Wall(length, height)
            };
        }
    }
}