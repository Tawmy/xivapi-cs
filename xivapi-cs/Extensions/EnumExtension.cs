using System;
using System.Linq;
using System.Reflection;

namespace xivapi_cs.Extensions;

public static class EnumExtension
{
    /// <summary>
    ///     A generic extension method that aids in reflecting
    ///     and retrieving any attribute that is applied to an `Enum`.
    ///     https://stackoverflow.com/a/25109103
    /// </summary>
    public static TAttribute? GetAttribute<TAttribute>(this Enum enumValue)
        where TAttribute : Attribute
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<TAttribute>();
    }
}