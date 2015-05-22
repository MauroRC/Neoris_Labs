using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP02_POO.Model
{
    public class Encargado: Empleado
    {
        
        public override decimal CalculaSueldo()
        {
            return SueldoBase + HorasTrabajadas * PagoPorHora + this.PagoPorAntiguedad()*2;
        }
    }
}