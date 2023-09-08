using PlayMyStory_Framework.Interface;
using System.ComponentModel.DataAnnotations;

namespace PlayMyStory_Framework.Attribute;

/// <summary>
/// 
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public abstract class BaseAttribute<T> : ValidationAttribute, IBaseAttribute<T> where T : System.Enum
{
    /// <inheritdoc/>
    public T Value { get; set; }
    
    /// <inheritdoc/>
    protected BaseAttribute(T value)
    {
        Value = value;
    }
    
    /// <inheritdoc/>
    public bool IsNull()
    {
        return Value == null;
    }
    
    /// <inheritdoc/>
    public abstract bool IsValid(T? value);
    
    /// <inheritdoc/>
    public override bool IsValid(object? value)
    {
        // Don't use the default function, go to the specific (abstract) function
        return IsValid((T)value!);
    }
    
    /// <inheritdoc/>
    public bool Equals(T? value)
    {
        // Specific code
        return (value != null || IsNull()) && (value == null || !IsNull()) && value!.Equals(Value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? value)
    {
        // Don't use the default function
        return Equals((T)value!);
    }

    /// <inheritdoc cref="GetHashCode" />
    public override int GetHashCode()
    {
        // ReSharper disable once NonReadonlyMemberInGetHashCode
        return IsNull() ? 0 : Value!.GetHashCode();
    }

    /// <inheritdoc cref="ToString" />
    public override string? ToString()
    {
        return Value?.ToString();
    }
}