using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqNTierExample
{
	public interface ICustomerRepository
	{
		Customer GetCustomerById(int id);
		void SaveCustomer(Customer customer);
	}

}
