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
    public partial class CRUD_Cliente : Form
    {
        private oBD oBD = new oBD();
        private bool flag1; //true = editar cliente, false = nuevo cliente
        private Cliente cliente = new Cliente();

        public CRUD_Cliente()
        {
            InitializeComponent();
        }

        public CRUD_Cliente(bool flag, Cliente Edit_cliente)
        {
            InitializeComponent();
            flag1 = flag;
            cliente = Edit_cliente;
        }

        private void CRUD_Cliente_Load(object sender, EventArgs e)
        {
            if (flag1 == true)
            {
                txbox_nombre.Text = cliente.Nombre;
                txbox_Apellido.Text = cliente.Apellido;
                txbox_dni.Text = cliente.Dni.ToString();
                txbox_cbu.Text = cliente.Cbu.ToString();

                //Form
                txbox_dni.Enabled = false;
                txbox_cbu.Enabled = false;
            }

            //Form
            txbox_nombre.Focus();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            int dni_conver, cbu_conver;
            bool check_dni, check_cbu, check_nombre, check_apellido;
            
            //Control
            check_dni = int.TryParse(txbox_dni.Text, out dni_conver);

            if(txbox_nombre.Text != "")
            {
                check_nombre = true;
            }
            else
            {
                check_nombre = false;
            }

            if(txbox_Apellido.Text != "")
            {
                check_apellido = true;
            }
            else
            {
                check_apellido = false;
            }

            check_cbu = int.TryParse(txbox_cbu.Text, out cbu_conver);

            if (check_dni == true && check_nombre == true && check_apellido == true && check_cbu == true)
            {
                DateTime dateNull = new DateTime();

                if (flag1 == true)
                {
                    bool check_update;

                    //Update
                    oBD.ConectarBD();
                    check_update = oBD.Update_cli_cta(0, dni_conver, txbox_nombre.Text, txbox_Apellido.Text, cbu_conver, 0, 0, 0, dateNull); //0 = Cuenta, 1 = Cliente
                    oBD.CerrarBD();

                    if(check_update == true)
                    {

                        MessageBox.Show("El cliente a sido modificado con exito");

                        this.Close();

                    }
                    else
                    {

                        MessageBox.Show("Error en la modificación del cliente");

                        //Form
                        txbox_nombre.Focus();
                    }
                }
                else
                {
                    bool check_insert;

                    //Insert
                    oBD.ConectarBD();
                    check_insert = oBD.insert_cta_cli(0, dni_conver, txbox_nombre.Text, txbox_Apellido.Text, cbu_conver, 0, 0, 0, dateNull);
                    oBD.CerrarBD();

                    if (check_insert == true)
                    {
                        MessageBox.Show("El nuevo cliente ha sido registrado");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en la inserción del nuevo registro, verifique que el cliente NO este registrado");

                        //Form
                        txbox_nombre.Focus();
                    }
                }
            }
            else
            {
                string error_mess = "Se ha detectado un error en la carga de datos del registro" + "\n"
                    + "Verifique los siguientes apartados:" + "\n";

                if(check_dni == false)
                {
                    error_mess += "-DNI" + "\n";
                }
                if(check_nombre == false)
                {
                    error_mess += "-Nombre" + "\n";
                }
                if (check_apellido == false)
                {
                    error_mess += "-Apellido" + "\n";
                }
                if (check_cbu == false)
                {
                    error_mess += "-CBU" + "\n";
                }

                MessageBox.Show(error_mess);

                //Form
                txbox_nombre.Focus();
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
                txbox_nombre.Focus();
            }
        }
    }
}
