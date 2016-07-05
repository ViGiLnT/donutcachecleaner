namespace Create.Umbraco.Plugin.DonutCacheCleaner.Trees
{
    using System.Net.Http.Formatting;
    using global::Umbraco.Core;
    using global::Umbraco.Web.Models.Trees;
    using global::Umbraco.Web.Mvc;
    using global::Umbraco.Web.Trees;

    [Tree("donutCacheCleaner", "donutCacheCleanerTree", "Content for Refreshing")]
    [PluginController("DonutCacheCleaner")]
    public class CacheCleanerTreeController : TreeController
    {
        /// <summary>
        /// Gets the tree nodes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="queryStrings">The query strings.</param>
        /// <returns>The content for approval tree collection.</returns>
        protected override TreeNodeCollection GetTreeNodes(string id, FormDataCollection queryStrings)
        {
            var nodes = new TreeNodeCollection();

            //check if we're rendering the root node's children
            if (id == Constants.System.Root.ToInvariantString())
            {
                TreeNode node = CreateTreeNode(
                "1",
                "-1",
                queryStrings,
                "Everything",
                "icon-umb-content",
                false);

                nodes.Add(node);
            }

            return nodes;
        }

        /// <summary>
        /// Gets the menu for node.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="queryStrings">The query strings.</param>
        /// <returns>The menu items.</returns>
        protected override MenuItemCollection GetMenuForNode(string id, FormDataCollection queryStrings)
        {
            var menu = new MenuItemCollection();
            return menu;
        }
    }
}