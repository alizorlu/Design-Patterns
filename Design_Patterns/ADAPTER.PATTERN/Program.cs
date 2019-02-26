using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAPTER.PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            RecivePaymentManager paymentManager
                = new RecivePaymentManager(new PaypalAdapter());
            paymentManager.GetPay();
            Console.ReadKey();
        }
    }
    class PaySafe : IPay
    {
        public void GetPayment(decimal price)
        {
            Console.WriteLine("====OK====");
            Console.WriteLine($"{price} TL ödeme alındı.\nLocation:PaySafe");
        }
    }
    internal interface IPay
    {
        void GetPayment(decimal price);
    }
    class PaypalAdapter : IPay
    {
        public void GetPayment(decimal price)
        {
            Paypal paypal = new Paypal();
            paypal.GetPaymentWithPaypal(price);
        }
    }
    
    class RecivePaymentManager
    {
        private IPay _pay;
        public RecivePaymentManager(IPay pay)
        {
            _pay = pay;
        }
        public void GetPay()
        {
            _pay.GetPayment(403.59m);
        }
    }
    //Erişilemez bir sınıf olduğunu varsay
    class Paypal
    {
        
        public void GetPaymentWithPaypal(decimal price)
        {
            Console.WriteLine("====OK====");
            Console.WriteLine($"{price} TL get paid.\nLocation:PayPal");
        }
    }
}
