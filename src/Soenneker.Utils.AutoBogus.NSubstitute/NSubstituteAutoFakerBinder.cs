using NSubstitute;
using Soenneker.Reflection.Cache.Types;
using Soenneker.Utils.AutoBogus.Context;

namespace Soenneker.Utils.AutoBogus.NSubstitute;

/// <summary>
/// An AutoFakerBinder for interfaces and abstract objects using NSubstitute
/// </summary>
public class NSubstituteAutoFakerBinder : AutoFakerBinder
{
    /// <summary>
    /// Creates instance.
    /// </summary>
    /// <typeparam name="TType">The TType type.</typeparam>
    /// <param name="context">The context.</param>
    /// <param name="cachedType">The cached type.</param>
    /// <returns>The result of the operation.</returns>
    public override TType? CreateInstance<TType>(AutoFakerContext context, CachedType cachedType) where TType : default
    {
        if (cachedType.IsInterface || cachedType.IsAbstract)
        {
            return (TType) Substitute.For([cachedType.Type], []);
        }

        return base.CreateInstance<TType>(context, cachedType);
    }
}