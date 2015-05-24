using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02_POO
{
    public partial class Ejercicio6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Pregunta_Click(object sender, EventArgs e)
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            string diaSemana = "";
            string mes = "";
            switch (tomorrow.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    diaSemana = "viernes";
                    break;
                case DayOfWeek.Monday:
                    diaSemana = "lunes";
                    break;
                case DayOfWeek.Saturday:
                    diaSemana = "sabado";
                    break;
                case DayOfWeek.Sunday:
                    diaSemana = "domingo";
                    break;
                case DayOfWeek.Thursday:
                    diaSemana = "jueves";
                    break;
                case DayOfWeek.Tuesday:
                    diaSemana = "martes";
                    break;
                case DayOfWeek.Wednesday:
                    diaSemana = "miercoles";
                    break;
                default:
                    break;
            }

            switch (tomorrow.Month)
            {
                case 1:
                    {
                        mes = "enero";
                        break;
                    }
                case 2:
                    {
                        mes = "febrero";
                        break;
                    }
                case 3:
                    {
                        mes = "marzo";
                        break;
                    }
                case 4:
                    {
                        mes = "abril";
                        break;
                    }
                case 5:
                    {
                        mes = "mayo";
                        break;
                    }
                case 6:
                    {
                        mes = "junio";
                        break;
                    }
                case 7:
                    {
                        mes = "julio";
                        break;
                    }
                case 8:
                    {
                        mes = "agosto";
                        break;
                    }
                case 9:
                    {
                        mes = "setiembre";
                        break;

                    }
                case 10:
                    {
                        mes = "octubre";
                        break;
                    }
                case 11:
                    {
                        mes = "noviembre";
                        break;
                    }
                case 12:
                    {
                        mes = "diciembre";
                        break;
                    }
                default:
                    break;
            }

            this.tbxDia.Text = string.Format("{0}, {1} de {2} del {3}", diaSemana, tomorrow.Day, mes, tomorrow.Year);
        }
    }
}