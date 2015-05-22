using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab03__Excepciones
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            this.tbxExcepcion.Text = "";
            try
            {
                this.tbxResultado.Text = (float.Parse(this.tbxDividendo.Text) / float.Parse(this.tbxDivisor.Text)).ToString();
                this.clear();
            }
            catch (DivideByZeroException ex)
            {
                this.clear();
                this.tbxResultado.Text = "Error";
                this.tbxExcepcion.Text = "Solo Mascherano y Chuck Norris dividen por cero. Error: " + ex.Message;
            }
            catch (FormatException ex)
            {
                this.clear();
                this.tbxResultado.Text = "Error";
                this.tbxExcepcion.Text = "Seguro ingreso un cero o no ingreso nada. Error: " + ex.Message;
            }
        }

        public void clear()
        {
            this.tbxDividendo.Text = "";
            this.tbxDivisor.Text = "";
        }
    }
}