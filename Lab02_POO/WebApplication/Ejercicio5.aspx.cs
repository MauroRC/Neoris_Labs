using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02_POO
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Comprueba_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.tbxNumero.Text) % 5 == 0)
            {
                this.lblRespuesta.Text = this.tbxNumero.Text + " es multiplo de 5";
                this.tbxNumero.Text = "";
            }
            else
            {
                this.lblRespuesta.Text = this.tbxNumero.Text + " NO es multiplo de 5";
                this.tbxNumero.Text = "";
            }
        }
    }
}