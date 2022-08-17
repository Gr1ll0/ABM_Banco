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
    public partial class GridView : Form
    {
        private oBD oBD = new oBD();
        bool delet_cta_cli;

        public GridView()
        {
            InitializeComponent();
        }

        private bool ActualizarDGV(int cta_cli) //0 = cliente, 1=cuenta, 2=ambos
        {
            bool retorno;
            DataTable tablaDGV = new DataTable();

            dGV_out.DataSource = null;

            if (cta_cli == 0)
            {
                try
                {
                    oBD.ConectarBD();
                    tablaDGV.Load(oBD.CargarDGV_cta_cli(cta_cli));
                    oBD.CerrarBD();

                    dGV_out.DataSource = tablaDGV;

                    retorno = true;
                }
                catch
                {
                    retorno = false;
                }
            }
            else if(cta_cli == 1)
            {
                try
                {

                    oBD.ConectarBD();
                    tablaDGV.Load(oBD.CargarDGV_cta_cli(cta_cli));
                    oBD.CerrarBD();

                    dGV_out.DataSource = tablaDGV;

                    retorno = true;
                }
                catch(Exception e)
                {
                    retorno = false;
                    MessageBox.Show("" + e);
                }
            }
            else if(cta_cli == 2)
            {
                try
                {
                    oBD.ConectarBD();
                    tablaDGV.Load(oBD.CargarDGV_cta_cli(cta_cli));
                    oBD.CerrarBD();

                    dGV_out.DataSource = tablaDGV;

                    retorno = true;
                }
                catch
                {
                    retorno = false;
                }
            }
            else
            {
                //error
                retorno = false;
            }
            
            return retorno;
        }

        private Cuenta CrearCuenta(string cbu, string saldo, string tipoCuenta, string ultimoMov)
        {
            int cbu_conver, saldo_conver, tipoCuenta_conver;
            DateTime ultimoMov_conver;

            cbu_conver = int.Parse(cbu);
            saldo_conver = (int)Math.Round(decimal.Parse(saldo, System.Globalization.NumberStyles.Any));
            tipoCuenta_conver = int.Parse(tipoCuenta);
            ultimoMov_conver = DateTime.Parse(ultimoMov);

            Cuenta oNewcuenta = new Cuenta(cbu_conver, saldo_conver, tipoCuenta_conver, ultimoMov_conver);

            return oNewcuenta;
        }

        private Cliente CrearCliente(string dni, string nombre, string apellido, string cbu)
        {
            int dni_conver, cbu_conver;

            dni_conver = int.Parse(dni);
            cbu_conver = int.Parse(cbu);

            Cliente oNewcliente = new Cliente(nombre, apellido, dni_conver, cbu_conver);

            return oNewcliente;
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            //Load del form
            ActualizarDGV(1);

            //Form
            dGV_out.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("¿Desea salir del programa?", "", MessageBoxButtons.YesNo);

            if(exit == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                dGV_out.Focus();
            }
        }

        private void dGV_out_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Cliente crud_cliente = new CRUD_Cliente();
            crud_cliente.ShowDialog();

            //Form
            ActualizarDGV(0);
            dGV_out.Focus();
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Cuenta crud_cuenta = new CRUD_Cuenta();
            crud_cuenta.ShowDialog();

            //Form
            ActualizarDGV(1);
            dGV_out.Focus();
        }

        //Vista del Grid
        //Cuenta
        private void cuentaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ActualizarDGV(1);

            //Form
            dGV_out.Focus();
        }

        //Cliente
        private void clienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ActualizarDGV(0);

            //Form
            dGV_out.Focus();
        }

        //Both
        private void cuentaYClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarDGV(2);

            //Form
            dGV_out.Focus();
        }

        private void cuentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cuenta_index = int.Parse(dGV_out.CurrentRow.Cells[0].Value.ToString());

            DataTable tabla_Cuenta = new DataTable();

            oBD.ConectarBD();
            tabla_Cuenta.Load(oBD.Consulta_cta_cli(1, cuenta_index));
            oBD.CerrarBD();

            Cuenta edit_cuenta = new Cuenta();

            edit_cuenta = CrearCuenta(tabla_Cuenta.Rows[0][0].ToString(),
                                      tabla_Cuenta.Rows[0][1].ToString(),
                                      tabla_Cuenta.Rows[0][2].ToString(),
                                      tabla_Cuenta.Rows[0][3].ToString());

            CRUD_Cuenta crud_edit_cta = new CRUD_Cuenta(true, edit_cuenta);

            crud_edit_cta.ShowDialog();

            bool retorno = ActualizarDGV(1); 
            /*Error al momento finalizar el update en la base de datos -> el flujo de información intenta realizar la consulta
             para actualizar el datagrid, pero por algún motivo que desconozco no se ejecuta correctamente y no se actualiza el datagrid.
             A su vez en otros llamados al ActualizarDGV tampoco funcionan.
             
              Al parecer el edit rompe el proceso almacenado de la consulta del datagrid.
             */
            

            MessageBox.Show("" + retorno); //<- mensaje del error

            //Form
            dGV_out.Focus();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cliente_index = int.Parse(dGV_out.CurrentRow.Cells[0].Value.ToString());

            DataTable tabla_Cliente = new DataTable();

            oBD.ConectarBD();
            tabla_Cliente.Load(oBD.Consulta_cta_cli(0, cliente_index));
            oBD.CerrarBD();

            Cliente edit_cliente = new Cliente();

            edit_cliente = CrearCliente(tabla_Cliente.Rows[0][0].ToString(),
                                          tabla_Cliente.Rows[0][1].ToString(),
                                          tabla_Cliente.Rows[0][2].ToString(),
                                          tabla_Cliente.Rows[0][3].ToString());

            CRUD_Cliente crud_edit_cli = new CRUD_Cliente(true, edit_cliente);

            crud_edit_cli.ShowDialog();

            ActualizarDGV(0);

            //Form
            dGV_out.Focus();
        }

        private void cuentaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            delet_cta_cli = true;

            ActualizarDGV(1);

            btn_borrar.Show();
            btn_cancelar.Show();
            btn_borrar.Enabled = true;
            btn_cancelar.Enabled = true;
            nuevoToolStripMenuItem.Enabled = false;
            editarToolStripMenuItem.Enabled = false;
            verToolStripMenuItem.Enabled = false;

            MessageBox.Show("Habilito el modo de borrado de registros, se desactivaron las demás opciones." + "\n"
                                + "Si desea cancelar esta modo haga click en el boton cancelar");

            //Form
            btn_cancelar.Focus();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            delet_cta_cli = false;

            ActualizarDGV(0);

            btn_borrar.Show();
            btn_cancelar.Show();
            btn_borrar.Enabled = true;
            btn_cancelar.Enabled = true;
            nuevoToolStripMenuItem.Enabled = false;
            editarToolStripMenuItem.Enabled = false;
            verToolStripMenuItem.Enabled = false;

            MessageBox.Show("Habilito el modo de borrado de registros, se desactivaron las demás opciones." + "\n"
                                + "Si desea cancelar esta modo haga click en el boton cancelar");

            ActualizarDGV(0);
            //Form
            btn_cancelar.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_borrar.Hide();
            btn_cancelar.Hide();
            btn_borrar.Enabled = false;
            btn_cancelar.Enabled = false;
            nuevoToolStripMenuItem.Enabled = true;
            editarToolStripMenuItem.Enabled = true;
            verToolStripMenuItem.Enabled = true;

            ActualizarDGV(1);
            //Form
            dGV_out.Focus();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            //True = cuenta, false= cliente

            bool check_delet;
            bool cancelado = false;
            DialogResult confirmar;

            int index = int.Parse(dGV_out.CurrentRow.Cells[0].Value.ToString());

            if (delet_cta_cli == true)
            {
                confirmar = MessageBox.Show("El registro de la cuenta con el CBU: " + index + ". Sera eliminado" + "\n" + "Confirme la acción", "", MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes)
                {
                    oBD.ConectarBD();
                    check_delet = oBD.Delete_cta_cli(1, index);
                    oBD.CerrarBD();

                    ActualizarDGV(1);
                }
                else
                {
                    btn_cancelar.Focus();
                    check_delet = true;
                    cancelado = true;
                    MessageBox.Show("El borrado ha sido cancelado");
                }
            }
            else
            {
                confirmar = MessageBox.Show("El registro del cliente con el DNI: " + index + ". Sera eliminado" + "\n" + "Confirme la acción", "", MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes)
                {
                    oBD.ConectarBD();
                    check_delet = oBD.Delete_cta_cli(0, index);
                    oBD.CerrarBD();

                    ActualizarDGV(0);
                }
                else
                {
                    btn_cancelar.Focus();
                    check_delet = true;
                    cancelado = true;
                    MessageBox.Show("El borrado ha sido cancelado");
                }
            }

            if (check_delet == false)
            {
                MessageBox.Show("Error al borrar el registro." + "\n"
                                 + "Verificar: " + "\n"
                                 + "-Sí el registro existe");
                                //Falta comprobar el error de identidad referencial (se intenta borrar una cuenta que tiene un cliente)
            }
            else if (check_delet == true && cancelado == true)
            {

            }
            else
            {
                MessageBox.Show("El registro se ha borrado con exito");
            }

            //Form

            btn_cancelar.Focus();
        }
    }
}
