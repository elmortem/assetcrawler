using System.Collections.Generic;

namespace AssetCrawlers
{
	public interface IAssetCrawler
	{
		bool CanCrawl(object currentObject);
		IEnumerable<TraversalContext> GetChildren(object currentObject, TraversalContext parentContext);
	}
}