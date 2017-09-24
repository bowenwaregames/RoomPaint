namespace RoomPaint
{
    /// <summary>
    /// Represents a room wall
    /// </summary>
    public class Wall : IComponent
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public double Area => Length * Height;

        public Wall(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }
}