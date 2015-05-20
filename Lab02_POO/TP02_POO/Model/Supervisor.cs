using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP02_POO.Model
{
    public class Supervisor: Empleado
    {
        enum porcentajePorCategoria { A = 10, B = 5, C = 2 };
        int porcentajeComision = 5;

        public override decimal CalculaSueldo()
        {
            return SueldoBase + PagoPorHora * HorasTrabajadas + this.PagoPorAntiguedad() + this.PagoPorCategoria() + this.PagoPorComision();
        }

        public decimal PagoPorCategoria()
        {
            if (Categoria == "A")
            {
                return PagoPorHora*HorasTrabajadas * (int)porcentajePorCategoria.A / 100;
            }
            else if (Categoria == "B")
            {
                return PagoPorHora*HorasTrabajadas * (int)porcentajePorCategoria.B / 100;
            }
            else if (Categoria == "C")
            {
                return PagoPorHora * HorasTrabajadas * (int)porcentajePorCategoria.C / 100;
            }
            else
            {
                return 0;
            }
        }

        public decimal PagoPorComision()
        {
            return PagoPorHora * HorasTrabajadas * (int)porcentajeComision / 100;
        }
    }
}