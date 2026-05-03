using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema2
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice) 
        {
            var Total = quantity <= 0 ? 0 : unitPrice*quantity;
            var anonima = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = Total
            };
            return string.Format("{0} - {1} - {3:C}", anonima.Code, anonima.Description, anonima.Total);
        }
    }
}
