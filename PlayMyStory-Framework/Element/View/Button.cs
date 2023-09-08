using PlayMyStory_Framework.Attribute;
using PlayMyStory_Framework.Element.Type;
using PlayMyStory_Framework.Enum;

namespace PlayMyStory_Framework.Element.View;

/// <summary>
/// 
/// </summary>
public class Button<TIn, TOut> : BaseElement where TOut : class
{
    /// <summary>
    /// 
    /// </summary>
    [View(ViewProperty.Name)]
    public string Name { get; }

    /// <summary>
    /// 
    /// </summary>
    [View(ViewProperty.Title)]
    public Text Title { get; }

    /// <summary>
    /// 
    /// </summary>
    [View(ViewProperty.Tooltip)]
    public Text Tooltip { get; }

    /// <summary>
    /// 
    /// </summary>
    [View(ViewProperty.Execute)]
    public Execute<TIn, TOut?> Execute { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parameter"></param>
    /// <returns></returns>
    public TOut? Invoke(TIn parameter)
    {
        return Execute.Invoke(parameter);
    }
}