using System.Linq;

namespace RoomPaint
{
    /// <summary>
    /// Paint service used to calculate the paint required
    /// for a room
    /// </summary>
    /// <typeparam name="T">Room Type Parameter</typeparam>
    public class PaintService<T> : IPaintService<T>
        where T : Room
    {

        public T Room { get; set; }

        /// <summary>
        /// Create an instance of PaintService
        /// </summary>
        /// <param name="room">The room to paint</param>
        public PaintService(T room)
        {
            Room = room;
        }

        /// <summary>
        /// Calculate the paint required to paint room.
        /// Returns calculated amount in litres
        /// </summary>
        /// <param name="coats">Number of coats to paint</param>
        /// <param name="coats">Paint coverage</param>
        /// <returns></returns>
        public double PaintRoom(int coats, double paintCoverage = 10)
        {
            // For now we will only assume the door/window areas
            double doorArea = 24;
            double windowArea = 18;

            double wallLengths = Room.walls.Sum(w => w.Length);

            // Assume the first wall is height for all walls for simplicity 
            double totalWallArea = wallLengths * Room.walls.First().Height;

            double totalWindowArea = Room.Windows * windowArea;
            double totalDoorArea = Room.Doors * doorArea;

            // Remove window and door areas from total wall area
            totalWallArea -= (totalWindowArea + totalDoorArea);

            return (totalWallArea / paintCoverage) * coats;
        }
    }
}