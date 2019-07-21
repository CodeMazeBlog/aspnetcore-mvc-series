using Microsoft.AspNetCore.Mvc;

namespace Filters.Filters
{
	public class CacheResourceAttribute : TypeFilterAttribute
	{
		public CacheResourceAttribute()
			: base(typeof(CacheResourceFilter))
		{
		}
	}
}
