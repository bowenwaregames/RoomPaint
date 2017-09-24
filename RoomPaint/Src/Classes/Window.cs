namespace RoomPaint
{
    /// <summary>
    /// Represents a Room Window
    /// </summary>
    public class Window : IComponent
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public double Area
        {
            get
            {
                return Length * Height;
            }
        }

        public Window()
        {
            Height = 0.7;
            Length = 0.7;
        }

        public Window(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }
}