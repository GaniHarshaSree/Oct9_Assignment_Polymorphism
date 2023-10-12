using System;

namespace BankLib
{
    public class Bank
    {
        private float _amt;

        public float Amount
        {
            get { return _amt; }
            set { _amt = value; }
        }

        private long _accNo;

        public long AccountNo
        {
            get { return _accNo; }
            set { _accNo = value; }
        }

        private string _branchname;

        public string BranchName
        {
            get { return _branchname; }
            set { _branchname = value; }
        }

        private DateTime _dDate;

        public DateTime DDate
        {
            get { return _dDate; }
            set { _dDate = value; }
        }

        private float _bal = 0;

        public float Bal
        {
            get { return _bal; }
            set { _bal = value; }
        }


        public void Deposit(float amt, DateTime depositDate, string branchname, long AccountNo)

        {
            Bal += amt;
            Console.WriteLine($"Amount {Amount} had been Deposited to the Account number {AccountNo} on {depositDate} from {branchname} branch \n Total Balance {Bal}");

        }

        public void Deposit(long AccountNo, float amt, DateTime depositDate, string branchname)
        {
            Bal += amt;
            Console.WriteLine($"Amount {amt} had been Deposited to the Account number {AccountNo} on {depositDate} from {branchname} branch \n Total Balance {Bal}");
        }

        public void Deposit(long AccountNo, float amt, DateTime depositDate)
        {
            Bal += amt;
            Console.WriteLine($"Amount {amt} had been Deposited to the Account number {AccountNo} on {depositDate} \n Total Balance {Bal}");
        }

        public void Withdraw(float amt, DateTime depositDate, string branchname, long accountNo)

        {
            Bal -= amt;
            Console.WriteLine($"Amount {amt} had been withdrawn from the Account number {AccountNo} on {depositDate} from {branchname} branch");
            Console.WriteLine("Balance:{0}", Bal);
        }

    }
}
