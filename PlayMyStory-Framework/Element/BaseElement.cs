using PlayMyStory_Framework.Attribute;
using PlayMyStory_Framework.Enum;
using PlayMyStory_Framework.Service;

namespace PlayMyStory_Framework.Element;

/// <summary>
/// 
/// </summary>
public class BaseElement
{
    /// <summary>
    /// 
    /// </summary>
    protected BaseElement()
    {
        Id = IdService.GetInstance().GetNextId();
    }

    /// <summary>
    /// 
    /// </summary>
    [View(ViewProperty.Id)]
    public long Id { get; }
}