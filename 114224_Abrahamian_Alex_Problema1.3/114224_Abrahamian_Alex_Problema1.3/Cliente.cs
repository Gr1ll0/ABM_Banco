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
        private int cbu;

        public Cliente()
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = 0;
            this.cbu = 0;
        }

        public Cliente(string nombre, string apellido, int dni, int cbu)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.cbu = cbu;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public int Cbu { get { return cbu; } set { dni = value; } }
    }
}
