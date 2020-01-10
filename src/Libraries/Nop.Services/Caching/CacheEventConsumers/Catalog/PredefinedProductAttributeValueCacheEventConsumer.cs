﻿using Nop.Core.Domain.Catalog;
using Nop.Services.Caching.CachingDefaults;

namespace Nop.Services.Caching.CacheEventConsumers.Catalog
{
    public partial class PredefinedProductAttributeValueCacheEventConsumer : CacheEventConsumer<PredefinedProductAttributeValue>
    {
        protected override void ClearCache(PredefinedProductAttributeValue entity)
        {
            RemoveByPrefix(NopCatalogCachingDefaults.ProductAttributesPrefixCacheKey);
            RemoveByPrefix(NopCatalogCachingDefaults.ProductAttributeMappingsPrefixCacheKey);
            RemoveByPrefix(NopCatalogCachingDefaults.ProductAttributeValuesPrefixCacheKey);
            RemoveByPrefix(NopCatalogCachingDefaults.ProductAttributeCombinationsPrefixCacheKey);
        }
    }
}
