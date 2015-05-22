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
        string _categoria;

        public Supervisor(string categoria)
        {
            Categoria = categoria;
        }
        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public override decimal CalculaSueldo()
        {
            return SueldoBase + PagoPorHora * HorasTrabajadas + this.PagoPorAntiguedad() + this.PagoPorCategoria() + this.PagoPorComision();
        }

        public decimal PagoPorCategoria()
        {
            if (this.Categoria == "A")
            {
                return PagoPorHora*HorasTrabajadas * (decimal)porcentajePorCategoria.A / 100;
            }
            else if (this.Categoria == "B")
            {
                return PagoPorHora*HorasTrabajadas * (decimal)porcentajePorCategoria.B / 100;
            }
            else if (this.Categoria == "C")
            {
                return PagoPorHora * HorasTrabajadas * (decimal)porcentajePorCategoria.C / 100;
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