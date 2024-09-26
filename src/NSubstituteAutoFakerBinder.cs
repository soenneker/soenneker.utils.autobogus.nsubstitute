using NSubstitute;
using Soenneker.Reflection.Cache.Types;
using Soenneker.Utils.AutoBogus.Context;

namespace Soenneker.Utils.AutoBogus.NSubstitute;

/// <summary>
/// An AutoFakerBinder for interfaces and abstract objects using NSubstitute
/// </summary>
public class NSubstituteAutoFakerBinder : AutoFakerBinder
{
    public override TType? CreateInstance<TType>(AutoFakerContext context, CachedType cachedType) where TType : default
    {
        if (cachedType.IsInterface || cachedType.IsAbstract)
        {
            return (TType) Substitute.For([cachedType.Type], []);
        }

        return base.CreateInstance<TType>(context, cachedType);
    }
}