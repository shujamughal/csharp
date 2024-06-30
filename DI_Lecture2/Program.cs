using DI_Lecture2;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
	static void Main(string[] args)
	{
		var serviceCollection = new ServiceCollection();
		ConfigureServices(serviceCollection);

		var serviceProvider = serviceCollection.BuildServiceProvider();
		var app = serviceProvider.GetService<App>();
		app.Run();
	}

	private static void ConfigureServices(IServiceCollection services)
	{
		services.AddTransient<IMessageService, EmailService>();
		services.AddTransient<App>();
	}
}