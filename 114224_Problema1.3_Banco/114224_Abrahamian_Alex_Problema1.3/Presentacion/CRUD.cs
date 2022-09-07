using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _114224_Abrahamian_Alex_Problema1._3
{
    public partial class CRUD : Form
    {
        private oBD oBD = new oBD();
        private bool flag1; //true = editar registro, false = nuevo registro
        private Cliente registro = new Cliente();
        private string[] list_dni;
        private string[] list_cbu;

        //Constructor 1 - Se le pasan 2 listas con información de los DNI y CBU
        public CRUD(string[] lista_dni, string[] lista_cbu)
        {
            InitializeComponent();
            flag1 = false;
            registro = null;
            list_dni = lista_dni;
            list_cbu = lista_cbu;
        }


        //Constructor 2 - Se le pasan 1 flag y una clase Cliente
        //flag -> Cambia el camino en btn_registrar debido si es una edición o una inserción
        //Clase Cliente -> Se le transfiera toda la información al CRUD de todo el registro para ser editado
        public CRUD(bool flag, Cliente Edit_reg)
        {
            InitializeComponent();
            flag1 = flag;
            registro = Edit_reg;
            list_dni = null;
            list_cbu = null;
        }

        //Carga combo metodo
        private void CargarCombo(string display, string value, DataTable tabla)
        {
            cbo_tipoCuenta.DataSource = tabla;
            cbo_tipoCuenta.DisplayMember = display;
            cbo_tipoCuenta.ValueMember = value;
        }

        //Existe dni en la BD?
        private bool ExisteCliente_dni()
        {
            bool retorno = false;

            for (int i = 0; i < list_dni.Length; i++)
            {
                if (txbox_dni.Text == list_dni[i].ToString())
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        //Existe el CBU?
        private bool ExisteCuenta()
        {
            bool retorno = false;

            for (int i = 0; i < list_cbu.Length; i++)
            {
                if (txt_cbu.Text == list_cbu[i].ToString())
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        //Load -> En caso de ser una edición se cargan los datos del registro
        private void CRUD_Cliente_Load(object sender, EventArgs e)
        {
            DataTable comb_tabla = new DataTable();

            //Cagar combo
            oBD.ConectarBD();
            comb_tabla.Load(oBD.Combo());
            oBD.CerrarBD();

            CargarCombo("nombre", "tipoCuenta", comb_tabla);

            //Camino de edicion
            if (flag1 == true)
            {
                txt_cbu.Text = registro.Cuenta.Cbu.ToString();
                txt_saldo.Text = registro.Cuenta.Saldo.ToString();
                cbo_tipoCuenta.SelectedIndex = (registro.Cuenta.TipoCuenta - 1);
                dtp_ultimoMovimiento.Value = registro.Cuenta.UltimoMov;
                txbox_nombre.Text = registro.Nombre;
                txbox_Apellido.Text = registro.Apellido;
                txbox_dni.Text = registro.Dni.ToString();
                txt_cbu.Text = registro.Cuenta.Cbu.ToString();


                //Form
                txbox_dni.Enabled = false;
                txt_cbu.Enabled = false;
                txbox_nombre.Focus();
            }
            else
            {
                //Form
                txt_cbu.Focus();
            }
        }


        //Registrar Control + Conversición en simultaneo datos en el CRUD

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            int dni_conver, cbu_conver, saldo_conver, tipoCuenta_conver = 0;
            bool check_dni, check_cbu, check_nombre, check_apellido, check_saldo, check_tipoCuenta, check_fecha;

            //Control
            check_cbu = int.TryParse(txt_cbu.Text, out cbu_conver);

            check_saldo = int.TryParse(txt_saldo.Text, out saldo_conver);

            if (cbo_tipoCuenta.SelectedIndex != -1)
            {
                tipoCuenta_conver = (cbo_tipoCuenta.SelectedIndex + 1);
                check_tipoCuenta = true;
            }
            else
            {
                check_tipoCuenta = false;
            }

            if (dtp_ultimoMovimiento.Value >= DateTime.Today)
            {
                check_fecha = false;
            }
            else
            {
                check_fecha = true;
            }
            
            check_dni = int.TryParse(txbox_dni.Text, out dni_conver);

            if (txbox_nombre.Text != "")
            {
                check_nombre = true;
            }
            else
            {
                check_nombre = false;
            }

            if (txbox_Apellido.Text != "")
            {
                check_apellido = true;
            }
            else
            {
                check_apellido = false;
            }

            if (check_dni == true && check_cbu == true && check_nombre == true && check_apellido == true 
                     && check_saldo == true && check_tipoCuenta == true && check_fecha == true)
            {

                if (flag1 == true)
                {
                    bool check_update;

                    //Update
                    oBD.ConectarBD();
                    check_update = oBD.Update_cli_cta(dni_conver, txbox_nombre.Text, txbox_Apellido.Text, cbu_conver, saldo_conver, tipoCuenta_conver, dtp_ultimoMovimiento.Value);
                    oBD.CerrarBD();

                    if (check_update == true)
                    {

                        MessageBox.Show("El registro a sido modificado con exito");

                        this.Close();

                    }
                    else
                    {

                        MessageBox.Show("Error en la modificación del registro");

                        //Form
                        txbox_nombre.Focus();
                    }
                }
                else
                {
                    //Control de existencia

                    if (ExisteCliente_dni() == false)
                    {

                        if (ExisteCuenta() == false)
                        {
                            bool check_insert;

                            //Insert
                            oBD.ConectarBD();
                            check_insert = oBD.insert_cta_cli(dni_conver, txbox_nombre.Text, txbox_Apellido.Text, cbu_conver, saldo_conver, tipoCuenta_conver, dtp_ultimoMovimiento.Value);
                            oBD.CerrarBD();

                            if (check_insert == true)
                            {
                                MessageBox.Show("El nuevo registro ha sido registrado");

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error en la inserción del nuevo registro");

                                //Form
                                txbox_nombre.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cuenta con el CBU: " + cbu_conver + " no existe");

                            //Form
                            txt_cbu.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El DNI: " + dni_conver + " del cliente ya esta registrado, verifique que ingrese un nuevo cliente");
                        txbox_dni.Focus();
                    }
                }
            }
            else
            {
                //Muestra en que partes del CRUD existen discrepancias
                string error_mess = "Se ha detectado un error en la carga de datos del registro" + "\n"
                    + "Verifique los siguientes apartados:" + "\n";

                if (check_dni == false)
                {
                    error_mess += "-DNI" + "\n";
                }
                if (check_nombre == false)
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
                txbox_nombre.Focus();
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("¿Seguro que desea cancelar?", "", MessageBoxButtons.YesNo);

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
