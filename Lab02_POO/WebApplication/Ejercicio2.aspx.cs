using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02_POO
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        static List<int> numeros;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (numeros == null)
            {
                numeros = new List<int>();
            }
        }

        protected void Empezar_click(object sender, EventArgs e)
        {
            numeros = new List<int>();
        }

        protected void Ingresar_click(object sender, EventArgs e)
        {
            try
            {
                numeros.Add(int.Parse(this.tbxIngresar.Text));
            }
            catch (FormatException)
            {
                // falta agregar manejo de excepcion para cuando se ingresa una letra.
                throw;
            }
            finally
            {
                this.tbxIngresar.Text = "";
            }
        }

        protected void Analizar_click(object sender, EventArgs e)
        {
            int total = 0, positivos = 0, negativos = 0, ceros = 0;
            foreach (int i in numeros)
            {
                if (i>0)
                {
                    positivos++;
                }
                else if(i<0)
                {
                    negativos++;
                }
                else
                {
                    ceros++;
                }
                total++;
            }
            this.tbxResultado.Text = string.Format("Total ingresado: {0}, Positivos: {1}, Negativos: {2}, Ceros: {3}", total, positivos, negativos, ceros);
        }
    }
}