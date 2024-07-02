using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqNTierExample
{
	public class CustomerService
	{
		private readonly ICustomerRepository _customerRepository;

		public CustomerService(ICustomerRepository customerRepository)
		{
			_customerRepository = customerRepository;
		}

		public Customer GetCustomerById(int id)
		{
			return _customerRepository.GetCustomerById(id);
		}

		public void SaveCustomer(Customer customer)
		{
			if (string.IsNullOrEmpty(customer.Name))
			{
				throw new ArgumentException("Customer name cannot be empty");
			}

			if (string.IsNullOrEmpty(customer.Email))
			{
				throw new ArgumentException("Customer email cannot be empty");
			}

			_customerRepository.SaveCustomer(customer);
		}
	}

}
