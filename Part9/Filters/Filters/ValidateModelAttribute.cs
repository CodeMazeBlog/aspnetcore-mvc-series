using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace Filters.Filters
{
	public class ValidateModelAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			var param = context.ActionArguments.SingleOrDefault();

			if (param.Value == null)
			{
				context.Result = new BadRequestObjectResult("Model is null");
				return;
			}

			if (!context.ModelState.IsValid)
			{
				context.Result = new BadRequestObjectResult(context.ModelState);
			}
		}

		public override void OnActionExecuted(ActionExecutedContext context)
		{
		}
	}
}
