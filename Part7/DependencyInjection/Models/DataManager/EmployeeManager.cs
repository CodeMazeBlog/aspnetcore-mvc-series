using System;
using System.Collections.Generic;
using DependencyInjection.Models.Repository;

namespace DependencyInjection.Models.DataManager
{
	public class EmployeeManager : IDataRepository<Employee>
	{
		public void Add(Employee employee)
		{
			throw new NotImplementedException();
		}

		IEnumerable<Employee> IDataRepository<Employee>.GetAll()
		{
			return new List<Employee>() {
				new Employee()
			};
		}
	}
}
