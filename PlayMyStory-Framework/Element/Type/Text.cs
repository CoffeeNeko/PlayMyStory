namespace PlayMyStory_Framework.Element.Type;

/// <summary>
/// 
/// </summary>
public class Text : BaseElement
{
    /// <summary>
    /// 
    /// </summary>
    public string Value { get; } = string.Empty;
    /// <summary>
    /// 
    /// </summary>
    public Color Foreground { get; } = Color.Black;
    /// <summary>
    /// 
    /// </summary>
    public Color Background { get; } = Color.Transparent;
    /// <summary>
    /// 
    /// </summary>
    public Font Font { get; } = Font.Arial;
    /// <summary>
    /// 
    /// </summary>
    public double Size { get; } = 8.0;
    /// <summary>
    /// 
    /// </summary>
    public bool IsBold { get; } = false;
    /// <summary>
    /// 
    /// </summary>
    public bool IsUnderline { get; } = false;
    /// <summary>
    /// 
    /// </summary>
    public bool IsStrikeOut { get; } = false;
    /// <summary>
    /// 
    /// </summary>
    public bool IsItalic { get; } = false;
}