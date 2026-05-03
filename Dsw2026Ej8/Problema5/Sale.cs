using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    internal abstract class Sale
    {
        protected decimal Amount;

        public Sale (decimal amount)
        {
            Amount = amount;
        }

        public virtual decimal CalculateTotal()
        {
            return Amount;
        }
    }
}
