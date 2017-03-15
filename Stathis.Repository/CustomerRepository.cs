using Stathis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stathis.Repository
{
    public class CustomerRepository
    {
        private List<Customer> _customers;

        public CustomerRepository()
        {
            _customers = new List<Customer>();

            var customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Stathis";
            customer1.LastName = "Votsis";
            customer1.Email = "stathisvotsis@gmail.com";
            _customers.Add(customer1);

            var customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Antonis";
            customer2.LastName = "Klimis";
            customer2.Email = "antonisklimis@gmail.com";
            _customers.Add(customer2);

        }


        public List <Customer> GetCustomers()
        {
            return _customers;
        }

        public Customer GetById(int Id)
        {
           
            return _customers.FirstOrDefault(c=> c.Id==Id);
            
        }
    }
}
