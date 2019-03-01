using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRIDGE.PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentManger paymentManger
                = new PaymentManger();
            paymentManger.NewPayment = new IyzicoService();
            paymentManger.payment = new Payment()
            {
                From = "Ali Zorlu",
                To = "HepsiOrada INC",
                Money = 475.99m
            };
            paymentManger.SaleProduct();
            Console.ReadKey();
        }
    }
    abstract class PaymentServiceBase
    {
        public void Logging()
        {
            Console.WriteLine("Payment received");
        }
        public abstract void Receiving(Payment payment);
    }
    public class Payment
    {
        public string From { get; set; }
        public string To { get; set; }
        public decimal Money { get; set; }
    }
    class PaypalService : PaymentServiceBase
    {
        public override void Receiving(Payment payment)
        {
            Console.WriteLine($"{payment.From}=>{payment.To} received =TRY{payment.Money} [ via Paypal Service ]");
        }
    }
    class IyzicoService : PaymentServiceBase
    {
        public override void Receiving(Payment payment)
        {
            Console.WriteLine($"{payment.From}=>{payment.To} received =TRY{payment.Money} [ via Iyzico Service ]");
        }
    }

    class PaymentManger
    {
        public PaymentServiceBase NewPayment { get; set; }
        public Payment payment{ get; set; }
        public void SaleProduct()
        {
            NewPayment.Receiving(payment);
            NewPayment.Logging();
            Console.WriteLine("Product saled.Thank you");
        }
    }
}
