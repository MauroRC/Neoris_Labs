using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP02_POO.Model;

namespace TP02_POO
{
    public partial class FormEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calcular_Click(object sender, EventArgs e)
        {
            if( this.rbtnEncargado.Checked == true || this.rbtnSupervisor.Checked == true) {
            Empleado empleado;
            if (rbtnEncargado.Checked == true) 
            {
                empleado = new Encargado();
            }
            else
            {
                empleado = new Supervisor();
                empleado.Categoria = ddlCategoria.SelectedValue.ToString();
 
            }
            empleado.Nombre = this.tbxNombre.Text;
            empleado.Apellido = this.tbxApellido.Text;
            empleado.AñoIngreso = int.Parse(this.tbxAñoIngreso.Text);
            empleado.SueldoBase = int.Parse(this.tbxSueldoBase.Text);
            empleado.HorasTrabajadas = int.Parse(this.tbxHsTrabajadas.Text);
            empleado.PagoPorHora = int.Parse(this.tbxPrecioHora.Text);
            tbxSueldo.Text = string.Format("El sueldo de {0} {1} es de $ {2}", this.tbxNombre.Text, this.tbxApellido.Text, empleado.CalculaSueldo());
            }
            else
            {
                this.lblTipoEmpleado.Text="No ha especificado el tipo de empleado";
            }
        }
    }
        

        protected void rbtnEncargado_Check(object sender, EventArgs e)
        {
            this.ddlCategoria.SelectedIndex = 0;
            this.ddlCategoria.Enabled = false;
            this.rbtnSupervisor.Checked = false;
        }

        protected void rbtnSupervisor_Check(object sender, EventArgs e)
        {
            this.ddlCategoria.Enabled = true;
            this.rbtnEncargado.Checked = false;
        }
}
