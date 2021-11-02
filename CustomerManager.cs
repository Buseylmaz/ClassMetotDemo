using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer1)
        {
            Console.WriteLine(customer1.Name +" "+ customer1.Surname+" " + "Sisteme eklendi");
        }

        public void List(Customer customer2)
        {
            Console.WriteLine(customer2.Tc + " " + customer2.Name + " " + customer2.Surname + " " + customer2.Phone + " " + customer2.RegularPayment + " " + "Bilgileri listelendi.");
        }

        public void Delete(Customer customer3)
        {
            Console.WriteLine(customer3.Name + " " + "İsmi silindi");
        }
    }
}
