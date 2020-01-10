﻿using Nop.Core.Domain.Directory;
using Nop.Services.Caching.CachingDefaults;

namespace Nop.Services.Caching.CacheEventConsumers.Directory
{
    public partial class CurrencyCacheEventConsumer : CacheEventConsumer<Currency>
    {
        protected override void ClearCache(Currency entity)
        {
            RemoveByPrefix(NopDirectoryCachingDefaults.CurrenciesPrefixCacheKey);
        }
    }
}
