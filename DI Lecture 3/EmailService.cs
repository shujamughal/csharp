using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Lecture_3
{
	public class EmailService : IMessageService
	{
		public void SendMessage(string message)
		{
			Console.WriteLine($"Email sent with message: {message}");
		}
	}
}
