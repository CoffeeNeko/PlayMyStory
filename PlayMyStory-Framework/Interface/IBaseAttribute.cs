using System.ComponentModel.DataAnnotations;

namespace PlayMyStory_Framework.Interface;

/// <summary>
/// 
/// </summary>
public interface IBaseAttribute<T>
{
    /// <summary>
    /// 
    /// </summary>
    public T Value { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool IsNull();

    /// <inheritdoc cref="ValidationAttribute.IsValid" />
    public bool IsValid(T? value);

    /// <inheritdoc cref="object.Equals(object?)" />
    public bool Equals(T? value);

    /// <inheritdoc cref="object.GetHashCode" />
    public int GetHashCode();

    /// <inheritdoc cref="object.ToString" />
    public string? ToString();
}