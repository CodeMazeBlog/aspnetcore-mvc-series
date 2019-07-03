using System.Collections.Generic;

namespace WorkingWithDI.Models.Services
{
	public class BooksLookupService
	{
		public List<string> GetGenres()
		{
			return new List<string>()
		{
			"Fiction",
			"Thriller",
			"Comedy",
			"Autobiography"
		};
		}
	}
}
