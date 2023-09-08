using PlayMyStory_Framework.Enum;

namespace PlayMyStory_Framework.Attribute;

/// <summary>
/// 
/// </summary>
public class ViewAttribute : BaseAttribute<ViewProperty>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    public ViewAttribute(ViewProperty value) : base(value) { }
    
    /// <inheritdoc/>
    public override bool IsValid(ViewProperty value)
    {
        return true;
    }
}