using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerCode = "SD5253";
            customer.CustomerName = "Tran Kien Tuong";
            customer.Insert();

            CountryMaster country = new CountryMaster();
            country.CountryCode = "HCM0001";
            country.CountryName = "Ho Chi Minh";
            country.Insert();
        }
    }
}