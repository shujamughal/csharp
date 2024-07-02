using NUnit.Framework;
using Moq;
using MoqNTierExample;

namespace MoqNTierExampleTest
{
	

	[TestFixture]
	public class CustomerServiceTests
	{
		private Mock<ICustomerRepository> _mockCustomerRepository;
		private CustomerService _customerService;

		[SetUp]
		public void Setup()
		{
			_mockCustomerRepository = new Mock<ICustomerRepository>();
			_customerService = new CustomerService(_mockCustomerRepository.Object);
		}

		[Test]
		public void GetCustomerById_ReturnsCustomer()
		{
			// Arrange
			var customer = new Customer { Id = 1, Name = "John Doe", Email = "john.doe@example.com" };
			_mockCustomerRepository.Setup(repo => repo.GetCustomerById(1)).Returns(customer);

			// Act
			var result = _customerService.GetCustomerById(1);

			// Assert
			Assert.AreEqual(customer, result);
		}

		[Test]
		public void SaveCustomer_WithValidCustomer_CallsSaveCustomerOnRepository()
		{
			// Arrange
			var customer = new Customer { Id = 1, Name = "John Doe", Email = "john.doe@example.com" };

			// Act
			_customerService.SaveCustomer(customer);

			// Assert
			_mockCustomerRepository.Verify(repo => repo.SaveCustomer(customer), Times.Once);
		}

		[Test]
		public void SaveCustomer_WithEmptyName_ThrowsArgumentException()
		{
			// Arrange
			var customer = new Customer { Id = 1, Name = "", Email = "john.doe@example.com" };

			// Act & Assert
			var ex = Assert.Throws<ArgumentException>(() => _customerService.SaveCustomer(customer));
			Assert.AreEqual("Customer name cannot be empty", ex.Message);
		}

		[Test]
		public void SaveCustomer_WithEmptyEmail_ThrowsArgumentException()
		{
			// Arrange
			var customer = new Customer { Id = 1, Name = "John Doe", Email = "" };

			// Act & Assert
			var ex = Assert.Throws<ArgumentException>(() => _customerService.SaveCustomer(customer));
			Assert.AreEqual("Customer email cannot be empty", ex.Message);
		}
	}

}