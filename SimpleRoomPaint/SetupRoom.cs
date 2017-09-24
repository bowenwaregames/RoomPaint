using System;
using RoomPaint;

namespace SimpleRoomPaint
{
    /// <summary>
    /// Helper class for new room setup
    /// </summary>
    static class SetupRoom 
    {
        public static Room CurrentRoom;

        /// <summary>
        /// Setup a new room
        /// </summary>
        /// <param name="width">Width of the room</param>
        /// <param name="length">Length of the room</param>
        /// <param name="height">Height of the room</param>
        public static void Setup(double width, double length, double height)
        {
            CurrentRoom = new Room(width, length, height);
        }

        /// <summary>
        /// Add a new window to current room
        /// </summary>
        /// <param name="count">Number of windows to add</param>
        public static void AddWindows(int count)
        {
            double width = 0.0, height = 0.0;

            Console.WriteLine("Would you like to specify window dimensions? Y/N");

            string option = Console.ReadLine();

            // Allow the user to specify their own dimensions. Or use default.
            if (option.ToLower() == "y")
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Window Height (m): ");
                    double.TryParse(Console.ReadLine(), out height);

                    Console.WriteLine("Window Width (m): ");
                    double.TryParse(Console.ReadLine(), out width);

                    CurrentRoom.Windows.Add(new Window(width, height));
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                    CurrentRoom.Windows.Add(new Window());
            }
        }

        /// <summary>
        /// Add doors to the room
        /// </summary>
        /// <param name="count">Number of doors to add</param>
        public static void AddDoors(int doubles, int singles)
        {
            // Add all double doors
            for (int i = 0; i < doubles; i++)
                CurrentRoom.Doors.Add(new Door(DoorType.Double));

            // Add all single doors
            for (int i = 0; i < singles; i++)
                CurrentRoom.Doors.Add(new Door(DoorType.Single));
        }
    }
}