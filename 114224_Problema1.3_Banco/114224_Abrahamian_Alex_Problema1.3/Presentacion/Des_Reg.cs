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
    public partial class Des_Reg : Form
    {
        private oBD oBD = new oBD();
        private int contador = 0; //Cuantas vueltas debe dar el for
        private int tamaño; //Tamaño de la lista "list_del" y "list_on_off"
        private int[] list_on_off; //Lista para confirmar habilitar o deshabilitar los registros por baja logica
        public Des_Reg()
        {
            InitializeComponent();
        }

        #region Load
        private void Des_Reg_Load(object sender, EventArgs e)
        {
            ActualizarDGV();

            list_on_off = new int[dgv_reg_des.RowCount];
            tamaño = dgv_reg_des.RowCount;
        }
        #endregion

        #region ActualizarDGV
        private bool ActualizarDGV()
        {
            bool retorno;
            DataTable tabla_DGV = new DataTable();

            try
            {
                dgv_reg_des.Columns.Remove("botones");
            }
            catch
            {

            }

            try
            {
                oBD.ConectarBD();
                tabla_DGV.Load(oBD.CargarDGV_cta_cli(3));
                oBD.CerrarBD();

                dgv_reg_des.DataSource = tabla_DGV;

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                btn.HeaderText = "Acciones";
                btn.Name = "botones";
                btn.Text = "Habilitar";
                btn.UseColumnTextForButtonValue = true;
                dgv_reg_des.Columns.Add(btn);

                retorno = true;
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region Btn_Volver
        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Evento_ClickDGV
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Habilitar registros
            if (e.ColumnIndex == 6)
            {
                contador += 1;

                for (int i = 0; i < tamaño; i++)
                {
                    if (list_on_off[i] == 0)
                    {
                        list_on_off[i] = int.Parse(dgv_reg_des.CurrentRow.Cells[2].Value.ToString());
                        break;
                    }
                }

                dgv_reg_des.Rows.RemoveAt(int.Parse(dgv_reg_des.CurrentRow.Index.ToString()));
            }
        }
        #endregion

        #region Btn_Cancelar
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            ActualizarDGV();

            //Form
            dgv_reg_des.Focus();
        }
        #endregion

        #region Btn_confirmar
        private void Btn_habilitar_confi_Click(object sender, EventArgs e)
        {
            bool check_update;
            DialogResult confirmar;
            string msj_cbu = "";

            //Armado del mensaje para mostrar que cbu's seran borrados
            for (int i = 0; i < contador; i++)
            {
                if (tamaño > 0)
                {
                    msj_cbu += "- " + list_on_off[i] + "\n";
                }
            }

            //Control de si algún registro se va a habilitar
            if (contador > 0)
            {
                //Mensaje de habilitado del modo singular y plural
                if (contador == 1)
                {
                    confirmar = MessageBox.Show("El registro con el CBU: " + "\n" +
                                                msj_cbu + "Sera habilitado" + "\n" + "Confirme la acción", "", MessageBoxButtons.YesNo);
                }
                else
                {
                    confirmar = MessageBox.Show("El registros con el CBU: " +
                                                    msj_cbu + "Seran habilitados" + "\n" + "Confirme la acción", "", MessageBoxButtons.YesNo);
                }

                //Confirmar habilitados
                if (confirmar == DialogResult.Yes)
                {
                    try
                    {
                        for (int i = 0; i < contador; i++)
                        {
                            oBD.ConectarBD();
                            check_update = oBD.cta_habilitar_deshabilitar(list_on_off[i], 0); //0 Habilitar 1 Deshabilitar
                            oBD.CerrarBD();
                        }
                        check_update = true;
                    }
                    catch
                    {
                        //Error
                        MessageBox.Show("Error al habilitar el registro." + "\n"
                            + "Verificar: " + "\n"
                            + "-Sí el registro existe");
                        check_update = false;
                    }
                    finally
                    {
                        ActualizarDGV();
                    }
                }
                else
                {
                    MessageBox.Show("El habilitar los registros ha sido cancelado");
                    check_update = false;
                }

                //Mensaje de OK o NO OK
                if (check_update == true)
                {
                    MessageBox.Show("Se ha habilitado el registro con exito");
                }
                else if (check_update == true && contador > 0)
                {
                    MessageBox.Show("Se han habilitado los registros con exito");
                }
                else if (check_update == false)
                {
                    MessageBox.Show("No se a habilitado ningun registros");
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("No se a seleccionado registro para ser habilitado");
            }

            ActualizarDGV();
        }
        #endregion
    }
}
