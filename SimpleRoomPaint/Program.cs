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
        static void Main(string[] args)
        {
            while (true)
            {
                double paint = 0.0;
                int coats = 1;

                Console.WriteLine("\nPlease enter dimensions for new room: ");

                // Setup new room
                var inputs = GetRoomInputs();

                SetupRoom.Setup(inputs.Item1, inputs.Item2, inputs.Item3);

                // Get window and door inputs
                GetDoorInputs();
                GetWindowInputs();

                // Setup paint service
                Room current = SetupRoom.CurrentRoom;
                PaintService<Room> paintService = new PaintService<Room>(current);


                Console.WriteLine("How many coats of paint?");
                int.TryParse(Console.ReadLine(), out  coats);

                paint = paintService.PaintRoom(coats);

                string output = $"\nRoom Volume: {current.Volume}" +
                                $"\nRoom Area: {current.Area}" +
                                $"\nPaint required (litres): {paint}\n";

                Console.WriteLine(output);
            }
        }

        /// <summary>
        /// Returns user room inputs
        /// </summary>
        /// <returns></returns>
        static (double, double, double) GetRoomInputs()
        {
            double width = 0.0, length = 0.0, height = 0.0;

            Console.WriteLine("Room Width (m): ");
            double.TryParse(Console.ReadLine(), out width);

            Console.WriteLine("Room Length (m): ");
            double.TryParse(Console.ReadLine(), out length);

            Console.WriteLine("Room Height (m): ");
            double.TryParse(Console.ReadLine(), out height);

            return (width, length, height);
        }

        /// <summary>
        /// Get window inputs for room
        /// </summary>
        static void GetWindowInputs()
        {
            int windows = 0;

            Console.WriteLine("How many windows?");
            int.TryParse(Console.ReadLine(), out windows);

            SetupRoom.AddWindows(windows);
        }

        /// <summary>
        /// Get door inputs for room
        /// </summary>
        static void GetDoorInputs()
        {
            int doorsDouble = 0, doorsSingle = 0;

            Console.WriteLine("How many double doors?");
            int.TryParse(Console.ReadLine(), out doorsDouble);

            Console.WriteLine("How many single doors?");
            int.TryParse(Console.ReadLine(), out doorsSingle);

            SetupRoom.AddDoors(doorsDouble, doorsSingle);
        }
    }
}