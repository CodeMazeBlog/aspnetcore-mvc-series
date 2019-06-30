using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Controllers
{
	public class FileUploadController : Controller
	{
		[HttpPost("FileUpload")]
		public async Task<IActionResult> Index(List<IFormFile> files)
		{
			long size = files.Sum(f => f.Length);

			var filePaths = new List<string>();
			foreach (var formFile in files)
			{
				if (formFile.Length > 0)
				{
					// full path to file in temp location
					var filePath = Path.GetTempFileName();
					filePaths.Add(filePath);

					using (var stream = new FileStream(filePath, FileMode.Create))
					{
						await formFile.CopyToAsync(stream);
					}
				}
			}

			// process uploaded files
			// Don't rely on or trust the FileName property without validation.
			return Ok(new { count = files.Count, size, filePaths });
		}
	}
}