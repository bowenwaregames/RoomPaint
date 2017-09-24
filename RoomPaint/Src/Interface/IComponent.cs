namespace RoomPaint
{
    /// <summary>
    /// Interface for room components
    /// </summary>
    public interface IComponent
    {
        double Length { get; set; }
        double Height { get; set; }
        double Area { get; }
    }
}