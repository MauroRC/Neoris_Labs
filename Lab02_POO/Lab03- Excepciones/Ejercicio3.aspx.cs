using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab03__Excepciones.Clases;

namespace Lab03__Excepciones
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GenerarExcepcion_Click(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            this.tbxExcepcion.Text= logic.generaExcepcion();

        }
    }
}