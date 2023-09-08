namespace PlayMyStory_Framework.Element.Type;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TIn"></typeparam>
/// <typeparam name="TOut"></typeparam>
public class Execute<TIn, TOut>: BaseElement where TOut : class
{
    private readonly Func<TIn, TOut> _action;

    /// <summary>
    /// 
    /// </summary>
    public bool IsExecuted => ExecutedCounts > 0;

    /// <summary>
    /// 
    /// </summary>
    public bool HasError => Exception != null;

    /// <summary>
    /// 
    /// </summary>
    public Exception? Exception { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public int ExecutedCounts { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public bool KeepResults { get; }

    /// <summary>
    /// 
    /// </summary>
    public List<TOut> Results { get; } = new();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="action"></param>
    /// <param name="keepResults"></param>
    public Execute(Func<TIn, TOut> action, bool keepResults = false)
    {
        _action = action;
        KeepResults = keepResults;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parameter"></param>
    /// <returns></returns>
    public TOut? Invoke(TIn parameter)
    {
        ExecutedCounts++;
        try
        {
            var result = _action.Invoke(parameter);
            if (KeepResults)
            {
                Results.Add(result);
            }
            return result;
        }
        catch (Exception e)
        {
            Exception = e;
        }
        return null;
    }
}