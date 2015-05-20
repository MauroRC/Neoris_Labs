using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02_POO
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sumar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            for (int i = 1; i <= 10; i++)
            {
                suma += i;
            }
            this.tbxResultado.Text = suma.ToString();
        }

        protected void Limpiar_Click(object sender, EventArgs e)
        {
            this.tbxResultado.Text = "";

        }
    }
}