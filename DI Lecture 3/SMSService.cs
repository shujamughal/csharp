using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Lecture_3
{
	public class SMSService : IMessageService
	{
		public void SendMessage(string message)
		{
			Console.WriteLine($"SMS sent with message: {message}");
		}
	}
}
