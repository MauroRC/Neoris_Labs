using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab03__Excepciones
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SimpleException_CLick(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int nro1, nro2;
                nro2 = rnd.Next() / nro1;
            }
            catch (DivideByZeroException)
            {
                this.tbxMensaje.Text = "Attempted to divide by zero";
            }
            finally
            {
                this.tbxFinaliza.Text = "Finalizo";
            }
        }
    }
}