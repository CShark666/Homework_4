using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class CreditCard
    {
        public string CVC { get; set; }
        public decimal Balance { get; set; }

        public CreditCard(string cvc, decimal balance)
        {
            CVC = cvc;
            Balance = balance;
        }

        public static CreditCard operator +(CreditCard card, decimal value)
        {
            card.Balance += value;
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal value)
        {
            card.Balance -= value;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.CVC == card2.CVC;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.CVC != card2.CVC;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard card)
            {
                return this.CVC == card.CVC;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return CVC.GetHashCode();
        }

        public override string ToString()
        {
            return $"CreditCard: {CVC}, Balance: {Balance}";
        }
    }
}
