using System.Collections.Generic;

namespace WorkingWithDI.Models.Repository
{
	public interface IDataRepository<TEntity>
	{
		IEnumerable<TEntity> GetAll();

		void Add(Employee employee);
	}
}
