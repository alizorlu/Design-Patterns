using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADE.PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear customer\n");
            MyAccount account = new MyAccount();
            account.GetOperation();
            Console.ReadKey();
        }
    }
    class OwedMoney : IOwedMoney
    {
        private decimal owed = 400.59m;
        public decimal GetTotal()
        {
            return owed;
        }

        public void Print()
        {
            Console.WriteLine($"Alınacak Tutar:{owed}");
        }
    }
    internal interface IOwedMoney
    {
        decimal GetTotal();
        void Print();
    }
    class DebtMoney : IDebpMoney
    {
        private decimal debt = 1150.59m;
        public decimal GetDebtMoney()
        {
            return debt;
        }

        public void PrintDebt()
        {
            Console.WriteLine($"Ödenecek Tutar:{debt}");
        }
    }
    internal interface IDebpMoney
    {
        decimal GetDebtMoney();
        void PrintDebt();
    }
    class AccountAbstract : IAccountAbstract
    {
        public void GetAbstractAccount()
        {
            Console.WriteLine("Alışveriş\t:00021 KODLU İŞ YERİ#YEMEK#\t:30.99 ₺");
            Console.WriteLine("Para Çekme\t:FTT821 ATM\t:200.00 ₺");
           
        }
    }
    internal interface IAccountAbstract
    {
        void GetAbstractAccount();
    }    
    class BankAOperation
    {
        private IOwedMoney _owedmoney;
        private IDebpMoney _debtmoney;
        private IAccountAbstract _accountabstract;
        public BankAOperation()
        {
            _owedmoney= new OwedMoney();
            _debtmoney = new DebtMoney();
            _accountabstract = new AccountAbstract();
        }
        public void GetOperations()
        {
            _owedmoney.GetTotal();
            _owedmoney.Print();
            _debtmoney.GetDebtMoney();
            _debtmoney.PrintDebt();
            _accountabstract.GetAbstractAccount();
        }
    }
    class MyAccount
    {
        private BankAOperation _bankoperation;
        public MyAccount()
        {
            _bankoperation = new BankAOperation();
        }
        public void GetOperation()
        {
            _bankoperation.GetOperations();
        }
    }
}
