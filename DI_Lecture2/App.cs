using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Lecture2
{
	public class App
	{
		private readonly IMessageService _messageService;

		public App(IMessageService messageService)
		{
			_messageService = messageService;
		}

		public void Run()
		{
			_messageService.SendMessage("Hello, Dependency Injection!");
		}
	}
}
