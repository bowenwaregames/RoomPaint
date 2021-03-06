﻿using System.Collections.Generic;

namespace RoomPaint
{
    /// <summary>
    /// Represents a room
    /// </summary>
    public class Room
    {
        public List<Wall> walls { get; set; }

        public double Area => floorWidth * floorLength;

        public double Volume => Area * roomHeight;

        public List<Door> Doors { get; set; }
        public List<Window> Windows { get; set; }

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

            Doors = new List<Door>();
            Windows = new List<Window>();

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