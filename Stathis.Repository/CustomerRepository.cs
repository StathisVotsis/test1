using Stathis.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            //var customer1 = new Customer();
            //customer1.Id = 1;
            //customer1.FirstName = "Stathis";
            //customer1.LastName = "Votsis";
            //customer1.Email = "stathisvotsis@gmail.com";
            //_customers.Add(customer1);

           // var customer2 = new Customer();
           // customer2.Id = 2;
            //customer2.FirstName = "Antonis";
            //customer2.LastName = "Klimis";
            //customer2.Email = "antonisklimis@gmail.com";
            //_customers.Add(customer2);

        }


        public List <Customer> GetCustomers()
        {
            //return listEmp.First(e => e.ID == id);  
            _customers = new List<Customer>();
            SqlDataReader reader = null;
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stathis\Desktop\develop\test1\Test2\App_Data\Votsis2.mdf;Integrated Security=True";

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from Table;";
            sqlCmd.Connection = myConnection;
            myConnection.Open();
            reader = sqlCmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
       
                _customers[i].FirstName = reader.GetValue(1).ToString();
                _customers[i].LastName = reader.GetValue(2).ToString();
                i = i + 1;

            }
            
            myConnection.Close();
            return _customers;
        }

        public Customer GetById(int Id)
        {
           
            return _customers.FirstOrDefault(c=> c.Id==Id);
            
        }
    }
}
