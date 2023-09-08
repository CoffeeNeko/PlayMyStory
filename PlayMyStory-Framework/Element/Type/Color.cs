namespace PlayMyStory_Framework.Element.Type;

/// <summary>
/// 
/// </summary>
public class Color : BaseElement
{
    /// <summary>
    /// 
    /// </summary>
    public static Color Transparent { get; } = new Color(0, 0, 0, 0);
    /// <summary>
    /// 
    /// </summary>
    public static Color Black { get; } = new Color(0, 0, 0, 1);
    /// <summary>
    /// 
    /// </summary>
    public static Color Red { get; } = new Color(255, 0, 0, 1);
    /// <summary>
    /// 
    /// </summary>
    public static Color Green { get; } = new Color(0, 255, 0, 1);
    /// <summary>
    /// 
    /// </summary>
    public static Color Blue { get; } = new Color(0, 0, 255, 1);

    /// <summary>
    /// 
    /// </summary>
    public double AlphaValue { get; }

    /// <summary>
    /// 
    /// </summary>
    public int BlueValue { get; }

    /// <summary>
    /// 
    /// </summary>
    public int GreenValue { get; }

    /// <summary>
    /// 
    /// </summary>
    public int RedValue { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="red"></param>
    /// <param name="green"></param>
    /// <param name="blue"></param>
    /// <param name="alpha"></param>
    public Color(int red, int green, int blue, double alpha)
    {
        RedValue = red;
        GreenValue = green;
        BlueValue = blue;
        AlphaValue = alpha;
    }
}