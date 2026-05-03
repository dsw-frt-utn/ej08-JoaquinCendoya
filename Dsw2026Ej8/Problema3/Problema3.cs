using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Dsw2026Ej8.Problema3
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product) 
        {
            int copyValue = originalValue;
            copyValue++;
            var copyProduct = product;
            copyProduct.ModificarDescription("Nueva descripción");

            return string.Format("{0}-{1}-{2}",originalValue,copyValue,copyProduct.GetDescription());
        }
    }
}
