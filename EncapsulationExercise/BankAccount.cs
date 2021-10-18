using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExercise
{
    class BankAccount
    {
        private double _balance;

        public double Balance { get; set; }

        public BankAccount()
        {
            Balance = 0;
        }

        public void Deposit(double amountToDeposit)
        {
            _balance += amountToDeposit;
        }

        public void Withdraw(double amountToWithdraw)
        {
            _balance -= amountToWithdraw;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
