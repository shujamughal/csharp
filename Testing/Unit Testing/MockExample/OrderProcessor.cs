using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExample
{
	public class OrderProcessor
	{
		private readonly IEmailService _emailService;

		public OrderProcessor(IEmailService emailService)
		{
			_emailService = emailService;
		}

		public void ProcessOrder(Order order)
		{
			// Order processing logic
			// ...

			// Send confirmation email
			_emailService.SendEmail(order.CustomerEmail, "Order Confirmation", "Your order has been processed.");
		}
	}

	

}
