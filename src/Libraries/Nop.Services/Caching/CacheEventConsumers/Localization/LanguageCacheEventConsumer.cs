﻿using Nop.Core.Domain.Localization;
using Nop.Services.Caching.CachingDefaults;

namespace Nop.Services.Caching.CacheEventConsumers.Localization
{
    public partial class LanguageCacheEventConsumer : CacheEventConsumer<Language>
    {
        protected override void ClearCache(Language entity)
        {
            RemoveByPrefix(NopLocalizationCachingDefaults.LanguagesPrefixCacheKey);
        }
    }
}