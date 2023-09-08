namespace PlayMyStory_Framework.Service;

/// <summary>
/// 
/// </summary>
public class IdService
{
    private static IdService? _instance;

    private long _id = -1;

    private IdService() {}

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static IdService GetInstance()
    {
        return _instance ??= new IdService();
    }

    public long GetNextId()
    {
        _id++;
        return _id;
    }
}