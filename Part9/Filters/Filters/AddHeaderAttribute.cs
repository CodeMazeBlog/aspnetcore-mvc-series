using Microsoft.AspNetCore.Mvc;

namespace Filters.Filters
{
	public class AddHeaderAttribute : TypeFilterAttribute
	{
		public AddHeaderAttribute() : base(typeof(AddHeaderFilter))
		{
		}
	}
}
