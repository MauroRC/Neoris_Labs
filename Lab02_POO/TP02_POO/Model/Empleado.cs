using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP02_POO.Interfaces;

namespace TP02_POO.Model
{
    public class Empleado: IEmpleado
    {
        enum porcentajePorAntiguedad { menosDe5Años = 0, entre5Y10Años = 5, masDe10Años = 10 };

        // variables + propiedades
        string _nombre;
        string _apellido;
        int _añoIngreso;
        int _sueldoBase;
        string _dni;
        int _pagoPorHora;
        string _categoria;
        int _horasTrabajadeas;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        public int AñoIngreso
        {
            get { return _añoIngreso; }
            set { _añoIngreso = value; }
        }


        public int SueldoBase
        {
            get { return _sueldoBase; }
            set { _sueldoBase = value; }
        }


        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }


        public int PagoPorHora
        {
            get { return _pagoPorHora; }
            set { _pagoPorHora = value; }
        }


        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }


        public int HorasTrabajadas
        {
            get { return _horasTrabajadeas; }
            set { _horasTrabajadeas = value; }
        }


        virtual public decimal CalculaSueldo()
        {
            throw new NotImplementedException();
        }

        public decimal PagoPorAntiguedad()
        {
            if ((DateTime.Today.Year - AñoIngreso) > 10)
            {
                return PagoPorHora* HorasTrabajadas * (int)porcentajePorAntiguedad.masDe10Años / 100;
            }
            else if ((DateTime.Today.Year - AñoIngreso) < 5)
            {
                return PagoPorHora*HorasTrabajadas* (int)porcentajePorAntiguedad.menosDe5Años/100;
            }
            else
            {
                return PagoPorHora*HorasTrabajadas * (int)porcentajePorAntiguedad.entre5Y10Años / 100;
            }

        }
    }
}