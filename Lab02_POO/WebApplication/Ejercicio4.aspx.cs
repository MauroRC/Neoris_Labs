using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02_POO
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        // constantes
        static int TIROS = 50;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LanzarDado_Click(object sender, EventArgs e)
        {
            int cont=0, cont1 = 0, cont2 = 0, cont3 = 0, contOtros = 0;
            Random rnd = new Random();

            while (cont < TIROS)
            {
                switch (rnd.Next(1, 6))
                {
                    case 1:
                        {
                            cont1++;
                            break;
                        }
                    case 2:
                        {
                            cont2++;
                            break;
                        }
                    case 3:
                        {
                            cont3++;
                            break;
                        }
                    default:
                        {
                            contOtros++;
                            break;
                        }
                }
                cont++;
            }
            this.tbxResultado.Text = string.Format("Prob 1: {0:c}%,  Prob 2: {1:c}%,  Prob 3: {2:c}%,  Prob Otros: {3:c}%", cont1 * 100 / TIROS, cont2 * 100 / TIROS, cont3 * 100 / TIROS, contOtros * 100 / TIROS);
            

        }
    }
}