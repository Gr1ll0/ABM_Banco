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
        private int contador = 0; //Cuantas vueltas debe dar el for, para eliminar los registros, o para deshabilitar los registros
        private int tamaño; //Tamaño de la lista "list_del" y "list_on_off"
        private int[] list_del; //Lista para confirmar los registros a borrar
        private int[] list_on_off; //Lista para confirmar habilitar o deshabilitar los registros por baja logica
        private bool flag_bajas; //Bandera de borrado o baja logica --true = borrado / --false = baja logica

        public GridView()
        {
            InitializeComponent();
        }

        #region ActualizarDGV
        //Carga DGV, según sea necesario carga una tabla u otra, ambas, para el borrado de registros o habilitar registros
        public bool ActualizarDGV(int cta_cli) //0 = cliente, 1=cuenta, 2=ambos, 3=DGV borrado, 4=deshabilitar
        {
            bool retorno;
            DataTable tablaDGV = new DataTable();

            dGV_out.DataSource = null;


            //Se remueve el boton para que no ocasione columnas duplicadas
            try
            {
                dGV_out.Columns.Remove("boton");
            }
            catch
            {

            }

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
            else if (cta_cli == 1)
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
            else if (cta_cli == 2)
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
            //Actualizar para borrado
            else if (cta_cli == 3)
            {
                try
                {
                    oBD.ConectarBD();
                    tablaDGV.Load(oBD.CargarDGV_cta_cli(2));
                    oBD.CerrarBD();

                    dGV_out.DataSource = tablaDGV;

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.HeaderText = "Acciones";
                    btn.Name = "boton";
                    btn.Text = "Quitar";
                    btn.UseColumnTextForButtonValue = true;
                    dGV_out.Columns.Add(btn);


                    retorno = true;
                }
                catch
                {
                    retorno = false;
                }
            }
            //Actualizar DGV Baja logica --0 Habilitado / 1 Inhabilitado
            else if (cta_cli == 4)
            {
                try
                {
                    oBD.ConectarBD();
                    tablaDGV.Load(oBD.CargarDGV_cta_cli(2));
                    oBD.CerrarBD();

                    dGV_out.DataSource = tablaDGV;

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.HeaderText = "Acciones";
                    btn.Name = "boton";
                    btn.Text = "Deshabilitar";
                    btn.UseColumnTextForButtonValue = true;
                    dGV_out.Columns.Add(btn);


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
        #endregion

        #region Crear_Objetos
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

        private Cliente CrearCliente(string dni, string nombre, string apellido, Cuenta cuenta)
        {
            int dni_conver;

            dni_conver = int.Parse(dni);

            Cliente oNewcliente = new Cliente(nombre, apellido, dni_conver, cuenta);

            return oNewcliente;
        }
        #endregion

        #region Load
        //Load de main window, default 2. Cargado de ambas tablas con join
        private void GridView_Load(object sender, EventArgs e)
        {
            //Load del form
            ActualizarDGV(2);

            //Form
            dGV_out.Focus();

            listadoToolStripMenuItem.Enabled = false;
            estadisticosToolStripMenuItem.Enabled = false;
        }
        #endregion

        #region Btn_salir
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
        #endregion

        #region Evento_ClickDGV
        private void dGV_out_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag_bajas == true) //Borrar registros
            {
                //Borrado de registros
                if (e.ColumnIndex == 6)
                {
                    contador += 1;

                    for (int i = 0; i < tamaño; i++)
                    {
                        if (list_del[i] == 0)
                        {
                            list_del[i] = int.Parse(dGV_out.CurrentRow.Cells[2].Value.ToString());
                            break;
                        }
                    }

                    dGV_out.Rows.RemoveAt(int.Parse(dGV_out.CurrentRow.Index.ToString()));
                }
            }
            else if (flag_bajas == false) //Deshabilitar registros
            {
                //Deshabilitar registros
                if (e.ColumnIndex == 6)
                {
                    contador += 1;

                    for (int i = 0; i < tamaño; i++)
                    {
                        if (list_on_off[i] == 0)
                        {
                            list_on_off[i] = int.Parse(dGV_out.CurrentRow.Cells[2].Value.ToString());
                            break;
                        }
                    }

                    dGV_out.Rows.RemoveAt(int.Parse(dGV_out.CurrentRow.Index.ToString()));
                }
            }
            else
            {
                //Error
            }
        }
        #endregion

        #region Alta_registro
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarDGV(1);
            string[] list_cliente_cbu = new string[dGV_out.RowCount];

            for (int i = 0; i < dGV_out.RowCount; i++)
            {
                list_cliente_cbu[i] = dGV_out.Rows[i].Cells[0].Value.ToString();
            }

            ActualizarDGV(0);
            string[] list_cliente_dni = new string[dGV_out.RowCount];
            
            for (int i = 0; i < dGV_out.RowCount; i++)
            {
                list_cliente_dni[i] = dGV_out.Rows[i].Cells[0].Value.ToString();
            }

            ActualizarDGV(2);
            //Se le envia al crud Cliente la lista con los datos de los dni y cbu
            CRUD crud_cliente = new CRUD(list_cliente_dni, list_cliente_cbu);
            crud_cliente.ShowDialog();

            //Form
            ActualizarDGV(2);
            dGV_out.Focus();
        }
        #endregion

        #region Vistas_DGV
        //Vista - DGV
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
        #endregion

        #region Modificación_Reg
        //Editar Registro
        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActualizarDGV(2);

            btn_editar.Show();
            btn_editar.Enabled = true;
            btn_cancelar.Show();
            btn_cancelar.Enabled = true;
            nuevoToolStripMenuItem.Enabled = false;
            borrarToolStripMenuItem.Enabled = false;
            verToolStripMenuItem.Enabled = false;

            MessageBox.Show("Habilito el modo de edición de registros, se desactivaron las demás opciones." + "\n"
                                + "Si desea cancelar esta modo haga click en el boton cancelar");

            ActualizarDGV(2);
            //Form
            btn_cancelar.Focus();
        }
        #endregion

        #region Baja_Delete
        //Borrado de Registro
        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            flag_bajas = true;

            ActualizarDGV(3);
            list_del = new int[dGV_out.RowCount];
            tamaño = dGV_out.RowCount;

            btn_confirmar.Show();
            btn_cancelar.Show();
            btn_confirmar.Enabled = true;
            btn_cancelar.Enabled = true;
            nuevoToolStripMenuItem.Enabled = false;
            editarToolStripMenuItem.Enabled = false;
            verToolStripMenuItem.Enabled = false;
            inhabilitarRegistroToolStripMenuItem.Enabled = false;

            MessageBox.Show("Habilito el modo de borrado de registros, se desactivaron las demás opciones." + "\n"
                                + "Si desea cancelar esta modo haga click en el boton cancelar");

            //Form
            btn_cancelar.Focus();
        }
        #endregion

        #region Cancelar_General
        //Cancelar General
        private void btn_cancelar_Click(object sender, EventArgs e)
        { 
       
            btn_editar.Hide();
            btn_confirmar.Hide();
            btn_cancelar.Hide();
            btn_editar.Enabled = false;
            btn_confirmar.Enabled = false;
            btn_cancelar.Enabled = false;
            nuevoToolStripMenuItem.Enabled = true;
            editarToolStripMenuItem.Enabled = true;
            borrarToolStripMenuItem.Enabled = true;
            verToolStripMenuItem.Enabled = true;
            inhabilitarRegistroToolStripMenuItem.Enabled = true;
            borrarToolStripMenuItem.Enabled = true;

            ActualizarDGV(2);

            //Form
            dGV_out.Focus();
        }
        #endregion

        #region Confirmar_Borrado o Deshabilitado
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if(flag_bajas == true && contador != 0)//Borrar registro
            {
                bool check_delet;
                DialogResult confirmar;
                string msj_cbu = "";

                for (int i = 0; i < contador; i++)
                {
                    if (tamaño > 0)
                    {
                        msj_cbu += "- " + list_del[i] + "\n";
                    }
                }

                if (contador == 1)
                {
                    confirmar = MessageBox.Show("El registro con el CBU: " + "\n" +
                                                msj_cbu + "Sera eliminado" + "\n" + "Confirme la acción", "", MessageBoxButtons.YesNo);
                }
                else
                {
                    confirmar = MessageBox.Show("El registros con el CBU: " +
                                                    msj_cbu + "Seran eliminados" + "\n" + "Confirme la acción", "", MessageBoxButtons.YesNo);
                }

                if (confirmar == DialogResult.Yes)
                {
                    try
                    {
                        for (int i = 0; i < contador; i++)
                        {
                            oBD.ConectarBD();
                            check_delet = oBD.Delete_cta_cli(list_del[i]);
                            oBD.CerrarBD();
                        }
                        check_delet = true;
                    }
                    catch
                    {
                        MessageBox.Show("Error al borrar el registro." + "\n"
                            + "Verificar: " + "\n"
                            + "-Sí el registro existe");
                        check_delet = false;
                    }
                    finally
                    {
                        ActualizarDGV(3);
                    }
                }
                else
                {
                    MessageBox.Show("El borrado ha sido cancelado");
                    check_delet = false;
                }

                if (check_delet == true && contador == 0)
                {
                    MessageBox.Show("Se ha eliminado el registro con exito");
                }
                else if(check_delet == true && contador > 0)
                {
                    MessageBox.Show("Se han eliminado los registros con exito");
                }
                else if (check_delet == false)
                {
                    MessageBox.Show("No se a eliminado ningun registro");
                }
                else
                {

                }

                ActualizarDGV(3);
            }
            else if(flag_bajas == false && contador != 0)//Deshabilitar registros
            {
                bool check_update;
                DialogResult confirmar;
                string msj_cbu = "";
                

                for (int i = 0; i < contador; i++)
                {
                    if (tamaño > 0)
                    {
                        msj_cbu += "- " + list_on_off[i] + "\n";
                    }
                }

                if (contador == 1)
                {
                    confirmar = MessageBox.Show("El registro con el CBU: " + "\n" +
                                                msj_cbu + "Sera deshabilitado" + "\n" + "Confirme la acción", "", MessageBoxButtons.YesNo);
                }
                else
                {
                    confirmar = MessageBox.Show("El registros con el CBU: " +
                                                    msj_cbu + "Seran deshabilitados" + "\n" + "Confirme la acción", "", MessageBoxButtons.YesNo);
                }

                if (confirmar == DialogResult.Yes)
                {
                    try
                    {
                        for (int i = 0; i < contador; i++)
                        {
                            oBD.ConectarBD();
                            check_update = oBD.cta_habilitar_deshabilitar(list_on_off[i], 1); //0 Habilitar 1 Deshabilitar
                            oBD.CerrarBD();
                        }
                        check_update = true;
                    }
                    catch
                    {
                        MessageBox.Show("Error al deshabilitar el registro." + "\n"
                            + "Verificar: " + "\n"
                            + "-Sí el registro existe");
                        check_update = false;
                    }
                    finally
                    {
                        ActualizarDGV(4);
                    }
                }
                else
                {
                    MessageBox.Show("El deshabilitar los registros ha sido cancelado");
                    check_update = false;
                }

                if (check_update == true)
                {
                    MessageBox.Show("Se ha deshabilitado el registro con exito");
                }
                else if (check_update == true && contador > 0)
                {
                    MessageBox.Show("Se han deshabilitado los registros con exito");
                }
                else if (check_update == false)
                {
                    MessageBox.Show("No se a deshabilitado ningun registros");
                }
                else
                {

                }

                ActualizarDGV(4);
            }
            else if(contador <= 0 && flag_bajas == true)
            {
                MessageBox.Show("No se a seleccionado registro para ser borrado");
            }
            else if (contador <= 0 && flag_bajas == false)
            {
                MessageBox.Show("No se a seleccionado registro para ser deshabilitado");
            }
            else
            {

            }

            //Limpiamos todo
            contador = 0;
            list_on_off = null;
            list_del = null;

            list_on_off = new int[dGV_out.RowCount];
            list_del = new int[dGV_out.RowCount];

            //Form
            btn_cancelar.Focus();
        }
        #endregion

        #region Confirmar_Modificación
        //Boton confirmar edición de X registro
        private void btn_editar_Click(object sender, EventArgs e)
        {
            int index_cbu = int.Parse(dGV_out.CurrentRow.Cells[2].Value.ToString());

            DataTable tabla_cuenta = new DataTable();
            DataTable tabla_cliente = new DataTable();

            oBD.ConectarBD();
            tabla_cuenta.Load(oBD.Consulta_cta_cli(1, index_cbu));
            oBD.CerrarBD();

            Cuenta cuenta = new Cuenta();

            cuenta = CrearCuenta(tabla_cuenta.Rows[0][0].ToString(),
                                        tabla_cuenta.Rows[0][1].ToString(),
                                        tabla_cuenta.Rows[0][2].ToString(),
                                        tabla_cuenta.Rows[0][3].ToString());

            oBD.ConectarBD();
            tabla_cliente.Load(oBD.Consulta_cta_cli(0, index_cbu));
            oBD.CerrarBD();

            Cliente cliente = new Cliente();

            cliente = CrearCliente(tabla_cliente.Rows[0][0].ToString(),
                                            tabla_cliente.Rows[0][1].ToString(),
                                            tabla_cliente.Rows[0][2].ToString(),
                                            cuenta);

            CRUD crud_edit_cli = new CRUD(true, cliente);

            crud_edit_cli.ShowDialog();
            
            cliente = null;
            cuenta = null;

            index_cbu = -1;

            ActualizarDGV(2);
            

            //Form
            dGV_out.Focus();
            btn_cancelar.Focus();
        }
        #endregion

        #region Reg_deshabilitados_Form
        private void registrosDeshabilitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.Des_Reg des_Reg = new Presentacion.Des_Reg();

            des_Reg.ShowDialog();

            ActualizarDGV(2);

            //Form
            dGV_out.Focus();
        }
        #endregion

        #region Baja_Logica
        //InHabilitar registros
        private void inhabilitarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Logica de cambiar el registro de A a B
            flag_bajas = false;

            ActualizarDGV(4); //Actualizar para deshabilitar

            list_on_off = new int[dGV_out.RowCount];
            tamaño = dGV_out.RowCount;

            btn_confirmar.Show();
            btn_cancelar.Show();
            btn_confirmar.Enabled = true;
            btn_cancelar.Enabled = true;
            nuevoToolStripMenuItem.Enabled = false;
            editarToolStripMenuItem.Enabled = false;
            verToolStripMenuItem.Enabled = false;
            borrarToolStripMenuItem.Enabled = false;
            

            MessageBox.Show("Habilito el modo para deshabilitar registros, se desactivaron las demás opciones." + "\n"
                                + "Si desea cancelar esta modo haga click en el boton cancelar");

            //Form
            btn_cancelar.Focus();
        }
        #endregion

        #region Reportes

        /*--------------------------------------------------------------------*/
        #region Reportes (Mandos medios)
        private void tipoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Presentacion.Frm_Rep_TDC rep_inter = new Presentacion.Frm_Rep_TDC();

            rep_inter.ShowDialog();

            //Form
            dGV_out.Focus();
        }
        #endregion
        /*--------------------------------------------------------------------*/


        /*--------------------------------------------------------------------*/
        #region Listados_VACIO (Operativos)
        #endregion
        /*--------------------------------------------------------------------*/


        /*--------------------------------------------------------------------*/
        #region Estadísticos_VACIO (Altos Mandos - Generencial)
        #endregion
        /*--------------------------------------------------------------------*/

        #endregion
    }
}
