using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Account
    {
        private string accountNo;
        public string AccountNo { get { return accountNo; } set { accountNo = value; } }

        private string accountName;
        public string AccountName { get { return accountName; } set { accountName = value; } }

        private float balance;
        public float Balance { get { return balance; } set { balance = value; } }
    }


    public class CurrentAccount : Account
    {
        static private int serviceCharge = 100;
        public int ServiceCharge { get { return serviceCharge; } set { serviceCharge = value; } }


        static private int accountPrefix = 100;
        public string AccountPrefix { get { return AccountPrefix; } set { AccountPrefix = value; } }

        static string nextAccount;
        public string nextAccountNo()
        {
            return nextAccount;
        }
    }

    public class SavingsAccount : Account
    {
        private int interestRate;
        public int InterestRate { get { return interestRate; } set { interestRate = value; } }

        private int monthlyDepositAmount;
        public int MonthlyDepositAmount { get { return monthlyDepositAmount; } set { monthlyDepositAmount = value; } }

        static private int accountPrefix = 200;
        public string AccountPrefix { get { return AccountPrefix; } set { AccountPrefix = value; } }

        static string nextAccount;
        public string nextAccountNo()
        {
            return nextAccount;
        }
    }

    public class MonthlyDepositScheme : Account
    {
        private int interestRate;
        public string InterestRate { get { return InterestRate; } set { InterestRate = value; } }

        private int monthlyDepositAmount;
        public int MonthlyDepositAmount { get { return monthlyDepositAmount; } set { monthlyDepositAmount = value; } }
        static private int accountPrefix = 300;
        public string AccountPrefix { get { return AccountPrefix; } set { AccountPrefix = value; } }

        static string nextAccount;
        public string nextAccountNo()
        {
            return nextAccount;
        }
    }

    public class LoanAccount : Account
    {
        private int interestRate;
        public string InterestRate { get { return InterestRate; } set { InterestRate = value; } }

        private int monthlyDepositAmount;
        public int MonthlyDepositAmount { get { return monthlyDepositAmount; } set { monthlyDepositAmount = value; } }
        static private int accountPrefix = 900;
        public string AccountPrefix { get { return AccountPrefix; } set { AccountPrefix = value; } }

        static string nextAccount;
        public string nextAccountNo()
        {
            return nextAccount;
        }
    }

    public class TwoYearMDS : MonthlyDepositScheme
    {
        private int maximumInterest;
        public int MaximumInterest { get { return maximumInterest; } set { maximumInterest = value; } }
    }
    public class FiveYearMDS : MonthlyDepositScheme
    {
        private int maximumInterest;
        public int MaximumInterest { get { return maximumInterest; } set { maximumInterest = value; } }
    }
    public class InitialDepositMDS : MonthlyDepositScheme
    {
        private int maximumInterest;
        public int MaximumInterest { get { return maximumInterest; } set { maximumInterest = value; } }

        private int initialDepositAmount;
        public int InitialDepositAmount { get { return initialDepositAmount; } set { initialDepositAmount = value; } }
    }
}
