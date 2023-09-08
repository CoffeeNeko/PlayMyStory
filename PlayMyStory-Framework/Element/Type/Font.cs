namespace PlayMyStory_Framework.Element.Type;

/// <summary>
/// 
/// </summary>
public class Font : BaseElement
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// 
    /// </summary>
    public static Font Arial { get; } = new Font("Arial");

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    public Font(string name)
    {
        Name = name;
    }
}