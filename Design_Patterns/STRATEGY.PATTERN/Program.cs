using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATEGY.PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditManager manager = new CreditManager();
            manager.customer = new Customer()
            {
                Name = "Ali",
                Surname = "Zorlu",
                TargetCredit = 35500.00m
            };
            Console.WriteLine($"Talep Edilen Kredi:{manager.customer.TargetCredit}");
            Console.WriteLine("======");
            manager.qonyabank = new After2010CustomerCreditCalculator();
            manager.GenerateCredit();

            Console.WriteLine("======");
            manager.qonyabank = new Before2010CustomerCreditCalculator();
            manager.GenerateCredit();

            Console.ReadKey();
        }
    }
    abstract class QonyaBankCreditBase
    {
        public abstract void CalcCredit(Customer customer);
    }
    class After2010CustomerCreditCalculator : QonyaBankCreditBase
    {
        public override void CalcCredit(Customer customer)
        {
            Console.WriteLine($"Müşteri:{customer.Name}-{customer.Surname}\nHesaplanan Kredi:TRY{customer.TargetCredit+customer.TargetCredit*0.10m}");
        }
    }
    class Before2010CustomerCreditCalculator : QonyaBankCreditBase
    {
        public override void CalcCredit(Customer customer)
        {
            Console.WriteLine($"Müşteri:{customer.Name}-{customer.Surname}\nHesaplanan Kredi:TRY{customer.TargetCredit + customer.TargetCredit * 0.08m}");
        }
    }
    class CreditManager
    {
        public QonyaBankCreditBase qonyabank { get; set; }
        public Customer customer { get; set; }

        public void GenerateCredit()
        {
            Console.WriteLine("Kredi hesaplamanız şu şekildedir:\n");
            qonyabank.CalcCredit(customer);
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal TargetCredit { get; set; }
    }
}
