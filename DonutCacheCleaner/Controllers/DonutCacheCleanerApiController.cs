namespace Create.Umbraco.Plugin.DonutCacheCleaner.Controllers
{
    using System.Web.Http;
    using DevTrends.MvcDonutCaching;
    using global::Umbraco.Web.Editors;
    using global::Umbraco.Web.Mvc;

    /// <summary>
    /// Donut Cache Cleaner Api
    /// </summary>
    /// <seealso cref="Umbraco.Web.Editors.UmbracoAuthorizedJsonController" />
    [PluginController("DonutCacheCleaner")]
    public class DonutCacheCleanerApiController : UmbracoAuthorizedJsonController
    {
        /// <summary>
        /// Clears the cache.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public bool ClearCache()
        {
            var cacheManager = new OutputCacheManager();
            cacheManager.RemoveItems();

            return true;
        }
    }
}
