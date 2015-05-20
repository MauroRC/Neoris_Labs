using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02_POO
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        //constantes
        static int INTENTOS = 5, MIN = 1, MAX = 50;
        
        // variables
        static int numero;
        static int contador;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (contador== 0)
            {
                this.lblMensaje.Text = "Debe presionar 'Nuevo Juego' para iniciar";
                this.lblConsigna.Text = string.Format("Se generará un número aleatorio entre {0} y {1}, y debera adivinarlo en {2} intentos", MIN, MAX, INTENTOS);
            }
        }

        protected void NuevoJuego_Click(object sender, EventArgs e)
        {
            Random rnd= new Random();
            numero = rnd.Next(MIN,MAX);
            contador = 1;
            this.lblMensaje.Text = "Ingrese numero";
        }

        protected void Probar_Click(object sender, EventArgs e)
        {
            if (contador != 0)
            {
                if (contador < INTENTOS)
                {
                    try
                    {
                        if (int.Parse(this.tbxNumero.Text) == numero)
                        {
                            lblMensaje.Text = "A acertado el numero (yupiiii !!!)";
                            contador = 1;
                            this.tbxNumero.Text = "";
                        }
                        else if (int.Parse(this.tbxNumero.Text) > numero)
                        {
                            lblMensaje.Text = string.Format("El numero es menor al ingresado. Intente de nuevo (quedan {0} intentos)", INTENTOS - contador);
                            contador++;
                            this.tbxNumero.Text = "";
                        }
                        else
                        {
                            lblMensaje.Text = string.Format("El numero es mayor al ingresado. Intente de nuevo (quedan {0} intentos)", INTENTOS - contador);
                            contador++;
                            this.tbxNumero.Text = "";
                        }
                    }
                    catch (FormatException)
                    {
                        // falta agregar manejo de excepcion para cuando se ingresa una letra.
                        throw;
                    }
                }
                else
                {
                    lblMensaje.Text = string.Format("Ha agotado las 5 oportunidades, el numero era {0}.Debe presionar 'Nuevo Juego' para iniciar nuevamente", numero);
                    this.tbxNumero.Text = "";
                }
            }
        }
    }
}