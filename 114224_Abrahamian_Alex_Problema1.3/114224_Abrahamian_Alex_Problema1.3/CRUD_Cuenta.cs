using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _114224_Abrahamian_Alex_Problema1._3
{
    public partial class CRUD_Cuenta : Form
    {
        private oBD oBD = new oBD();
        private bool flag1; //true = editar cuenta, false = nueva cuenta
        private Cuenta cuenta = new Cuenta();

        public CRUD_Cuenta()
        {
            InitializeComponent();
        }

        public CRUD_Cuenta(bool flag, Cuenta Edit_Cuenta)
        {
            InitializeComponent();
            flag1 = flag;
            cuenta = Edit_Cuenta;
        }

        private void CargarCombo(string display, string value, DataTable tabla)
        {
            comB_tipoCuenta.DataSource = tabla;
            comB_tipoCuenta.DisplayMember = display;
            comB_tipoCuenta.ValueMember = value;
        }

        private void CRUD_Cuenta_Load(object sender, EventArgs e)
        {
            DataTable comb_tabla = new DataTable();

            //Cagar combo
            oBD.ConectarBD();
            comb_tabla.Load(oBD.Combo());
            oBD.CerrarBD();

            CargarCombo("nombre", "tipoCuenta", comb_tabla);

            //Editar
            if (flag1 == true)
            {
                txbox_cbu.Text = cuenta.Cbu.ToString();
                txbox_Saldo.Text = cuenta.Saldo.ToString();
                comB_tipoCuenta.SelectedIndex = (cuenta.TipoCuenta-1);
                dTP_ultimoMov.Value = cuenta.UltimoMov;

                //Form
                txbox_cbu.Enabled = false;
                txbox_Saldo.Focus();
            }
            else
            {
                //Form
                txbox_cbu.Focus();
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            int cbu_conver, saldo_conver, tipoCuenta_conver=0;
            bool check_cbu, check_saldo, check_tipoCuenta, check_fecha;

            //Control
            check_cbu = int.TryParse(txbox_cbu.Text, out cbu_conver);

            check_saldo = int.TryParse(txbox_Saldo.Text, out saldo_conver);

            if(comB_tipoCuenta.SelectedIndex != -1)
            {
                tipoCuenta_conver = (comB_tipoCuenta.SelectedIndex+1);
                check_tipoCuenta = true;
            }
            else
            {
                check_tipoCuenta = false;
            }

            if(dTP_ultimoMov.Value >= DateTime.Today)
            {
                check_fecha = false;
            }
            else
            {
                check_fecha = true;
            }


            if (check_cbu == true && check_saldo == true && check_tipoCuenta == true && check_fecha == true)
            {
                if (flag1 == true)
                {
                    bool check_update;

                    //Update
                    oBD.ConectarBD();
                    check_update = oBD.Update_cli_cta(1, 0, "", "", 0, cbu_conver, saldo_conver, tipoCuenta_conver, dTP_ultimoMov.Value); // 0 = cliente, 1 = cuenta
                    oBD.CerrarBD();

                    if (check_update == true)
                    {
                        MessageBox.Show("La cuenta a sido modificada con exito");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en la modificación de la cuenta");

                        //Form
                        txbox_Saldo.Focus();
                    }

                }
                else
                {
                    bool check_insert;

                    //Insert
                    oBD.ConectarBD();
                    check_insert = oBD.insert_cta_cli(1, 0, "", "", 0, cbu_conver, saldo_conver, tipoCuenta_conver, dTP_ultimoMov.Value);
                    oBD.CerrarBD();

                    if (check_insert == true)
                    {
                        MessageBox.Show("La nueva cuenta ha sido registrado");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en la inserción de la nueva cuenta, verifique que el cuenta NO este registrada");

                        //Form
                        txbox_cbu.Focus();
                    }
                }
            }
            else
            {
                string error_mess = "Se ha detectado un error en la carga de datos del registro" + "\n"
                    + "Verifique los siguientes apartados:" + "\n";

                if (check_cbu == false)
                {
                    error_mess += "-CBU" + "\n";
                }
                if (check_saldo == false)
                {
                    error_mess += "-Saldo" + "\n";
                }
                if (check_tipoCuenta == false)
                {
                    error_mess += "-Tipo de Cuenta" + "\n";
                }
                if (check_fecha == false)
                {
                    error_mess += "-Fecha" + "\n";
                }

                MessageBox.Show(error_mess);

                //Form
                txbox_cbu.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("¿Desea salir del programa?", "", MessageBoxButtons.YesNo);

            if (cancelar == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                if(flag1 == true)
                {
                    txbox_Saldo.Focus();
                }
                else
                {
                    txbox_cbu.Focus();
                }
            }
        }
    }
}
