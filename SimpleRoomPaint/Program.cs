using System;
using RoomPaint;

namespace SimpleRoomPaint
{
    /// <summary>
    /// Simple application to calculate the area, volume
    /// and paint required to paint the walls
    /// </summary>
    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                int coats = 1, windows = 0, doors = 1;

                Console.WriteLine("Input Dimensions for new room:");

                // Get the room inputs and dimensions 
                Room room = CreateRoom();

                Console.WriteLine("Number of Windows: ");
                int.TryParse(Console.ReadLine(), out windows);

                Console.WriteLine("Number of Doors: ");
                int.TryParse(Console.ReadLine(), out doors);

                room.Windows = windows;
                room.Doors = doors;

                // Paint service setup
                PaintService<Room> paintService = new PaintService<Room>(room);

                Console.WriteLine($"Floor Area: {room.Area} \n Room Volume: { room.Volume }");

                Console.WriteLine("Number of coats: ");
                int.TryParse(Console.ReadLine(), out coats);

                // Calculate the paint needed
                double paint = Math.Round(paintService.PaintRoom(coats), 1);
                Console.WriteLine($"Paint Required {paint} litres \n");
            }
        }

        /// <summary>
        /// Create new room from user inputs
        /// </summary>
        /// <returns></returns>
        private static Room CreateRoom()
        {
            double width = 0, length = 0, height = 0;

            Console.WriteLine("Room Width (m): ");
            double.TryParse(Console.ReadLine(), out width);

            Console.WriteLine("Room Length (m): ");
            double.TryParse(Console.ReadLine(), out length);

            Console.WriteLine("Room Height (m): ");
            double.TryParse(Console.ReadLine(), out height);

            return new Room(width, length, height);
        }
    }
}