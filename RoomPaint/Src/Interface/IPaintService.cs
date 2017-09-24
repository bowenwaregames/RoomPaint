namespace RoomPaint
{
    /// <summary>
    /// Contract interface to Paint Service
    /// </summary>
    /// <typeparam name="T">Room Type parameter</typeparam>
    public interface IPaintService<T>
    {
        T Room { get; set; }

        /// <summary>
        /// Get paint required to paint room
        /// </summary>
        /// <param name="coats">Number of coats to give the room</param>
        /// <param name="coverage">Paint coverage</param>
        /// <returns></returns>
        double PaintRoom(int coats, double coverage);
    }
}