using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab03__Excepciones.Clases
{
    public class Logic
    {
        public string generaExcepcion()
        {
            try
            {
                int nro;
                nro = int.Parse("abc");
                return "";
            }
            catch (FormatException fe)
            {
                return string.Format( fe.GetType() + ", " + fe.Message);
                
            }
        }
    }
}