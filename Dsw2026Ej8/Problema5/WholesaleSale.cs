using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal amount) : base(amount)
        {
        }
        public override decimal CalculateTotal()
        {
            Console.WriteLine("Calculando el total con 10% de descuento...");
            return base.CalculateTotal() * 0.9m; // Aplica un descuento del 10%
        }
    }
}
