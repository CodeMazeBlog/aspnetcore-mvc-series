using Microsoft.AspNetCore.Mvc;

namespace Filters.Filters
{
	public class AuthorizeAttribute : TypeFilterAttribute
	{
		public AuthorizeAttribute(string permission)
		   : base(typeof(AuthorizeActionFilter))
		{
			Arguments = new object[] { permission };
		}
	}
}
