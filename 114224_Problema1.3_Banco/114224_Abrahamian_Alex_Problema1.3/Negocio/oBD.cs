using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;

//1W4 - 114224 - Abrahamian Alex

namespace _114224_Abrahamian_Alex_Problema1._3
{
    public class oBD
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand command = new SqlCommand();

        public oBD()
        {

        }

        #region Conectar/Cerrar
        public bool ConectarBD()
        {
            bool retorno;

            try
            {
                conexion.ConnectionString = Properties.Resources.cnnString;

                conexion.Open();

                retorno = true;
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }

        public bool CerrarBD()
        {
            bool retorno;

            try
            {
                conexion.Close();
                retorno = true;
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region CargarDGV
        public SqlDataReader CargarDGV_cta_cli(int cta_cli) // 0 = cliente, 1 = cuenta, 2 = Ambos, 3 = Deshabilitadas
        {
            command.Parameters.Clear();

            if (cta_cli == 0)
            {
                command.Connection = conexion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_Grilla_cli";
            }
            else if (cta_cli == 1)
            {
                command.Connection = conexion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_Grilla_cta";
            }
            else if(cta_cli == 2)
            {
                command.Connection = conexion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_Grilla_cta_cli";
            }
            else if(cta_cli == 3)
            {
                command.Connection = conexion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_Grilla_cta_cli_Deshabilitadas";
            }
            else
            {
                //error
            }

            return command.ExecuteReader();
        }
        #endregion

        #region Insertar
        public bool insert_cta_cli(int dni, string nombre, string apellido, int cbu, int saldo, int tipoCuenta, DateTime ultimoMov)
        {
            bool retorno;
            SqlTransaction trans = null;

            try
            {
                //Cuenta

                trans = conexion.BeginTransaction();
                command.Transaction = trans;
                command.Connection = conexion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_insert_cuenta";
                command.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu;
                command.Parameters.AddWithValue("@saldo", SqlDbType.Int).Value = saldo;
                command.Parameters.AddWithValue("@tipoCuenta", SqlDbType.Int).Value = tipoCuenta;
                command.Parameters.AddWithValue("@ultimoMov", SqlDbType.DateTime).Value = ultimoMov;

                command.ExecuteNonQuery();

                command.Parameters.Clear();

                //Cliente
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_insert_cliente";
                command.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                command.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                command.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = apellido;
                command.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu;

                command.ExecuteNonQuery();

                command.Parameters.Clear();

                trans.Commit();
                retorno = true;
            }
            catch
            {
                trans.Rollback();
                retorno = false;
            }
            finally
            {
                command.Parameters.Clear();
            }

            return retorno;
        }
        #endregion

        #region Consulta Cuenta/Cliente
        public SqlDataReader Consulta_cta_cli(int cta_cli, int index) //0 = cliente, 1 = cuenta
        {
            command.Parameters.Clear();

            if (cta_cli == 0)
            {
                command.Connection = conexion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_consulta_cli";
                command.Parameters.AddWithValue("@index", index).Value = index;
            }
            else if(cta_cli == 1)
            {
                command.Connection = conexion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_consulta_cta";
                command.Parameters.AddWithValue("@index", index).Value = index;
            }
            else
            {
                //error
            }

            return command.ExecuteReader();
        }
        #endregion

        #region Cargar_Combo
        public SqlDataReader Combo()
        {
            command.Parameters.Clear();

            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "pa_combo";

            return command.ExecuteReader();
        }
        #endregion

        #region Update
        public bool Update_cli_cta(int dni, string nombre, string apellido, int cbu, int saldo, int tipoCuenta, DateTime ultimoMov)
        {
            bool retorno;
            SqlTransaction trans = null;

            try
            {
                trans = conexion.BeginTransaction();
                command.Transaction = trans;
                command.Connection = conexion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_update_cta";
                command.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu;
                command.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = saldo;
                command.Parameters.AddWithValue("@tipoCuenta", SqlDbType.Int).Value = tipoCuenta;
                command.Parameters.AddWithValue("@ultimoMov", SqlDbType.DateTime).Value = ultimoMov;
                command.ExecuteNonQuery();

                command.Parameters.Clear();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_update_cli";
                command.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                command.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                command.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = apellido;
                command.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu;
                command.ExecuteNonQuery();

                command.Parameters.Clear();

                trans.Commit();
                retorno = true;
            }
            catch
            {
                trans.Rollback();
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region Delete
        public bool Delete_cta_cli(int index)
        {
            bool retorno;
            SqlTransaction trans = null;

            try
            {
                trans = conexion.BeginTransaction();
                command.Transaction = trans;
                command.Connection = conexion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_delet_cli";
                command.Parameters.AddWithValue("@index", SqlDbType.Int).Value = index;
                command.ExecuteNonQuery();

                command.Parameters.Clear();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_delet_cta";
                command.Parameters.AddWithValue("@index", SqlDbType.Int).Value = index;
                command.ExecuteNonQuery();

                command.Parameters.Clear();

                trans.Commit();
                retorno = true;
            }
            catch
            {
                trans.Rollback();
                retorno = false;
            }


            return retorno;
        }
        #endregion

        #region Habilitar_Deshabilitar
        public bool cta_habilitar_deshabilitar(int cbu, int tipo) //--0 Habilitado / 1 Inhabilitado
        {
            bool retorno;
            SqlTransaction trans = null;

            try
            {
                trans = conexion.BeginTransaction();
                command.Transaction = trans;
                command.Connection = conexion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "pa_habilitar_deshabilitar";
                command.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu;
                command.Parameters.AddWithValue("@tipo", SqlDbType.Bit).Value = tipo;
                command.ExecuteNonQuery();

                command.Parameters.Clear();

                trans.Commit();
                retorno = true;
            }
            catch
            {
                trans.Rollback();
                retorno = false;
            }

            return retorno;
        }
        #endregion

    }
}