using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using DependencyInjection.Controllers;
using DependencyInjection.Models;
using DependencyInjection.Models.Repository;
using Xunit;

namespace UnitTests
{
	public class EmployeeControllerTest
	{
		[Fact]
		public void Index_ReturnsAViewResult_WithAListOfEmployees()
		{
			// Arrange
			var mockRepo = new Mock<IDataRepository<Employee>>();
			mockRepo.Setup(repo => repo.GetAll())
				.Returns(GetTestEmployees());
			var controller = new EmployeeController(mockRepo.Object);

			// Act
			var result = controller.Index();

			// Assert
			var viewResult = Assert.IsType<ViewResult>(result);
			var model = Assert.IsAssignableFrom<List<Employee>>(
				viewResult.ViewData.Model);
			Assert.Equal(2, model.Count());
		}

		[Fact]
		public void Add_ReturnsBadRequestResult_WhenModelStateIsInvalid()
		{
			// Arrange
			var mockRepo = new Mock<IDataRepository<Employee>>();

			var controller = new EmployeeController(mockRepo.Object);
			controller.ModelState.AddModelError("Name", "Required");
			var newEmployee = GetTestEmployee();

			// Act
			var result = controller.Add(newEmployee);

			// Assert
			var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
			Assert.IsType<SerializableError>(badRequestResult.Value);
		}

		[Fact]
		public void Add_AddsEmployeeAndReturnsARedirect_WhenModelStateIsValid()
		{
			// Arrange
			var mockRepo = new Mock<IDataRepository<Employee>>();
			mockRepo.Setup(repo => repo.Add(It.IsAny<Employee>()))
				.Verifiable();
			var controller = new EmployeeController(mockRepo.Object);
			var newEmployee = GetTestEmployee();

			// Act
			var result = controller.Add(newEmployee);

			// Assert
			var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
			Assert.Null(redirectToActionResult.ControllerName);
			Assert.Equal("Index", redirectToActionResult.ActionName);
			mockRepo.Verify();
		}

		private IEnumerable<Employee> GetTestEmployees()
		{
			return new List<Employee>()
	{
		new Employee()
		{
			Id = 1,
			Name = "John"
		},
		new Employee()
		{
			Id = 2,
			Name = "Doe"
		}
	};
		}

		private Employee GetTestEmployee()
		{
			return new Employee()
			{
				Id = 1,
				Name = "John"
			};
		}
	}
}
