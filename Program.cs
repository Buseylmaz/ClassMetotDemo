using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Buse";
            customer.Surname = "Yılmaz";
            customer.Tc = 0123456789;
            customer.Phone = "0553456789";
            customer.RegularPayment = true;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.List(customer);
            customerManager.Delete(customer);

            Console.ReadLine();
            
        }
    }
}
