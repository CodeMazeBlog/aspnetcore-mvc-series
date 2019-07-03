using System.Collections.Generic;

namespace DependencyInjection.Models.Services
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
