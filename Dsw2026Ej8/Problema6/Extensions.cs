using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Dsw2026Ej8.Problema6
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        { 
            if(string.IsNullOrEmpty(code)) return "SIN-CODIGO";
            return code.ToUpper().Trim().Replace(" ","-");
        }
    }
}
