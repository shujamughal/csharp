using NUnit.Framework;
using Moq;
using MockExample;
using MockExample;
[TestFixture]
public class OrderProcessorTests
{
	private Mock<IEmailService> _mockEmailService;
	private OrderProcessor _orderProcessor;

	[SetUp]
	public void Setup()
	{
		_mockEmailService = new Mock<IEmailService>();
		_orderProcessor = new OrderProcessor(_mockEmailService.Object);
	}

	[Test]
	public void ProcessOrder_SendsConfirmationEmail()
	{
		// Arrange
		var order = new Order { CustomerEmail = "customer@example.com" };

		// Act
		_orderProcessor.ProcessOrder(order);

		// Assert
		_mockEmailService.Verify(
			e => e.SendEmail(
				It.Is<string>(email => email == "customer@example.com"),
				It.Is<string>(subject => subject == "Order Confirmation"),
				It.Is<string>(body => body == "Your order has been processed.")
			),
			Times.Once
		);
	}
}
/*
Assert: Verifies that the SendEmail method on the mock IEmailService was called exactly
once with the expected parameters using Verify method.

 */