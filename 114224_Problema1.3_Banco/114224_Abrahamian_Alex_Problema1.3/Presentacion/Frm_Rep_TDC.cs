using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _114224_Abrahamian_Alex_Problema1._3.Presentacion
{
    public partial class Frm_Rep_TDC : Form
    {
        public Frm_Rep_TDC()
        {
            InitializeComponent();
        }

        private void Frm_Rep_TDC_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'banco_114224DataSet.pa_TipoCuenta' Puede moverla o quitarla según sea necesario.
            this.pa_TipoCuentaTableAdapter.Fill(this.banco_114224DataSet.pa_TipoCuenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
