using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSection_2.Classes
{
    public class BankAccount
    {
        private float balance;

        // When defining a property, you should define it as public // Because it should be available for access from anywhere in the code
        //public float Balance { get; set; }
        public float Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value >= 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        private string owner;

        // Constructor
        public BankAccount(float balance, string owner)
        {
            Balance = balance;
            this.owner = owner;
        }

        public virtual float AddBalance(float balanceToBeAdded)
        {
            Balance = balance + balanceToBeAdded;
            return Balance;
        }

        // Method Overloading: Different methods that have the same name but a different signature
        public virtual float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)
        {
            if (balanceCanBeNegative)
            {
                balance = balance + balanceToBeAdded;
            }
            else
            {
                Balance = balance + balanceToBeAdded;
            }

            return Balance;
        }

        public async Task<string> GetData()
        {
            Thread.Sleep(2000);
            return "Completed";
        }
    }

    public class ChildBankAccount : BankAccount
    {
        public string Parent { get; set; }

        public ChildBankAccount(float balance, string owner, string parent) : base(balance, owner)
        {
            Parent = parent;
        }

        // Overriding is being able to use a method that exists on the parent and add some functionality to that method, or entirely change it
        public override float AddBalance(float balanceToBeAdded)
        {
            if (balanceToBeAdded >= -10)
                return base.AddBalance(balanceToBeAdded);
            return Balance;
        }

        public override float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)
        {
            if (balanceToBeAdded >= -10)
                return base.AddBalance(balanceToBeAdded, balanceCanBeNegative);
            return Balance;
        }
    }
}
