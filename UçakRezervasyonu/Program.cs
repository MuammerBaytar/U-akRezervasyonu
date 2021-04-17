using System;

namespace UçakRezervasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Berfin";
            customer1.Surname = "Çınar";
            customer1.Age = 18;
            customer1.TCnumber = "45678912356";
            customer1.Company = "THY";
            customer1.Destination = "Bursa";
            customer1.Date = "26.06.2021";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Muammer";
            customer2.Surname = "Baytar";
            customer2.Age = 20;
            customer2.TCnumber = "15678912314";
            customer2.Company = "THY";
            customer2.Destination = "Bursa";
            customer2.Date = "26.06.2021";

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + ". Müşteri" + "\n" + "-------------------------------------");
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Age);
                Console.WriteLine(customer.TCnumber);
                Console.WriteLine(customer.Company);
                Console.WriteLine(customer.Destination);
                Console.WriteLine(customer.Date);
                Console.WriteLine(" \n ");
            }
            CustomerManager customerManager = new CustomerManager();
            customerManager.Accept(customer1);
            customerManager.Accept(customer2);
        }
    }
}
