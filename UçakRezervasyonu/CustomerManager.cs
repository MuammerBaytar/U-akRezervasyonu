using System;
using System.Collections.Generic;
using System.Text;

namespace UçakRezervasyonu
{
    class CustomerManager
    {
        public void Accept (Customer customer)
        {
            Console.WriteLine("Bilet Onaylandı:" + " Adı: " + customer.Name + " " + " Soyadı: " + customer.Surname + " " + " TCno: " + customer.TCnumber + " " 
             + " Firma: " + customer.Company + " " + " Varışyeri: "  + customer.Destination + " " + " Tarih: " + customer.Date );
        }

    }
}
