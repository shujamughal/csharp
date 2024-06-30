using DI_Lecture_3;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		// Step 1: Set up configuration
		var configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
			.Build();

		// Step 2: Create a ServiceCollection
		var serviceCollection = new ServiceCollection();

		// Step 3: Configure Services based on configuration
		ConfigureServices(serviceCollection, configuration);

		// Step 4: Build ServiceProvider
		var serviceProvider = serviceCollection.BuildServiceProvider();

		// Step 5: Resolve and Run the Application
		var app = serviceProvider.GetService<App>();
		app.Run();
	}

	private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
	{
		// Read the configuration value
		var messageServiceType = configuration["MessageService"];

		// Register services based on configuration
		if (messageServiceType == "EmailService")
		{
			services.AddTransient<IMessageService, EmailService>();
		}
		else if (messageServiceType == "SMSService")
		{
			services.AddTransient<IMessageService, SMSService>();
		}
		else
		{
			throw new Exception("Invalid MessageService type in configuration.");
		}

		// Register the main application class
		services.AddTransient<App>();
	}
}
