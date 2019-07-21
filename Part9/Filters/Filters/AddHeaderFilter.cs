using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters
{
	public class AddHeaderFilter : IResultFilter
	{
		public void OnResultExecuting(ResultExecutingContext context)
		{
			context.HttpContext.Response.Headers.Add(
				"OnResultExecuting",
				"This header was added by result filter.");
		}

		public void OnResultExecuted(ResultExecutedContext context)
		{
		}
	}
}
