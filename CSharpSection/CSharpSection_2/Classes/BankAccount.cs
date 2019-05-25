using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public float AddBalance(float balanceToBeAdded)
        {
            Balance = balance + balanceToBeAdded;
            return Balance;
        }

        // Method Overloading: Different methods that have the same name but a different signature
        public float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)
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
    }

    public class ChildBankAccount : BankAccount
    {
        public string Parent { get; set; }

        public ChildBankAccount(float balance, string owner, string parent) : base(balance, owner)
        {
            Parent = parent;
        }
    }
}
