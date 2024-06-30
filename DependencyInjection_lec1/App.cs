using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
	public class App
	{
		private readonly IMessageService _messageService;

		// Constructor Injection
		public App(IMessageService messageService)
		{
			_messageService = messageService;
		}

		// Application Logic
		public void Run()
		{
			_messageService.SendMessage("Hello, Dependency Injection!");
		}
	}

}
