using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _114224_Abrahamian_Alex_Problema1._3
{
    public class Cuenta
    {
        private int cbu;
        private int saldo;
        private int tipoCuenta;
        private DateTime ultimoMov;

        public Cuenta()
        {
            this.cbu = 0;
            this.saldo = 0;
            this.tipoCuenta = 0;
            this.ultimoMov = DateTime.Today;
        }

        public Cuenta(int cbu, int saldo, int tipoCuenta, DateTime ultimoMov)
        {
            this.cbu = cbu;
            this.saldo = saldo;
            this.tipoCuenta = tipoCuenta;
            this.ultimoMov = ultimoMov;
        }

        public int Cbu { get { return cbu; } set { cbu = value; } }
        public int Saldo { get { return saldo; } set { saldo = value; } }
        public DateTime UltimoMov { get { return ultimoMov; } set { ultimoMov = value; } }
        public int TipoCuenta { get { return tipoCuenta; } set { tipoCuenta = value; } }
    }
}
