namespace RoomPaint
{
    /// <summary>
    /// Contains Predefined Door Types
    /// </summary>
    public enum DoorType
    {
        Single,
        Double, 
        Garage
    }

    /// <summary>
    /// Represents a room door
    /// </summary>
    public class Door : IComponent
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public double Area => Length * Height;
        
        public Door(double length, double height)
        {
            Length = length;
            Height = height;
        }

        public Door(DoorType type)
        {
            // Based on Standard Uk Door sizes
            if (type == DoorType.Single)
            {
                Height = 2.0;
                Length = 0.7;
            }
            else if (type == DoorType.Double)
            {
                Height = 2.0;
                Length = 1.2;
            }
            else
            {
                Height = 2.1;
                Length = 3.0;
            }
        }
    }
}