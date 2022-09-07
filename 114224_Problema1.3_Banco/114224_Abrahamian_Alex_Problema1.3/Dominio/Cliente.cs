using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _114224_Abrahamian_Alex_Problema1._3
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni; 
        private Cuenta cuenta;

        public Cliente()
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = 0;
            this.cuenta = null;
        }

        public Cliente(string nombre, string apellido, int dni, Cuenta cuenta)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.cuenta = cuenta;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public Cuenta Cuenta { get { return cuenta; } set { cuenta = value; } }
    }
}
