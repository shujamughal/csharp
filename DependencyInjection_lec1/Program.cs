using DependencyInjection;
using System;

class Program
{
	static void Main(string[] args)
	{
		// Manually create the service instance
		IMessageService messageService = new EmailService();
		// IMessageService messageService = new SMSService(); // Alternatively, use SMSService

		// Manually inject the dependency
		var app = new App(messageService);

		// Run the application
		app.Run();
	}
}
