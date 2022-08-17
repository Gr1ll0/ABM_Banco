using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//1W4 - 114224 - Abrahamian Alex

namespace _114224_Abrahamian_Alex_Problema1._3
{
    public class oBD
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand command = new SqlCommand();
        private SqlDataReader lector; //No tiene construct

        public oBD()
        {

        }

        public bool ConectarBD()
        {
            bool retorno;

            try
            {
                conexion.ConnectionString = @"Data Source=LAPTOP-LINMAH7K\SQLEXPRESS;Initial Catalog=Banco_114224;Integrated Security=True";

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

        public SqlDataReader ConsultaBD(string consulta)
        {
            command.Connection = conexion;
            command.CommandType = CommandType.Text;
            command.CommandText = consulta;

            return command.ExecuteReader();
        }

        public bool InsertBD(string insert)
        {
            bool retorno;

            try
            {
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
                command.CommandText = insert;
                command.ExecuteNonQuery();

                retorno = true;
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }

        public bool UpdateBD(string update)
        {
            bool retorno;
            try
            {
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
                command.CommandText = update;
                command.ExecuteNonQuery();

                retorno = true;
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }

        public bool DeleteBD(string delete)
        {
            bool retorno;
            try
            {
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
                command.CommandText = delete;
                command.ExecuteNonQuery();

                retorno = true;
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }

        public SqlDataReader CargarDGV_cta_cli(int cta_cli) // 0 = cliente, 1 = cuenta, 2= Ambos
        {
            if(cta_cli == 0)
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
            else
            {
                //error
            }

            return command.ExecuteReader();
        }

        public bool insert_cta_cli(int cta_cli, int dni, string nombre, string apellido, int cbu_cli, 
                                    int cbu_cta, int saldo, int tipoCuenta, DateTime ultimoMov)//0 = cliente, 1 = cuenta
        {
            bool retorno;

            try
            {
                if(cta_cli == 0)
                {
                    //Cliente

                    command.Connection = conexion;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pa_insert_cliente";
                    command.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                    command.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                    command.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = apellido;
                    command.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu_cli;

                    command.ExecuteNonQuery();

                    retorno = true;

                }
                else if(cta_cli == 1)
                {
                    //Cuenta

                    command.Connection = conexion;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pa_insert_cuenta";
                    command.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu_cta;
                    command.Parameters.AddWithValue("@saldo", SqlDbType.Int).Value = saldo;
                    command.Parameters.AddWithValue("@tipoCuenta", SqlDbType.Int).Value = tipoCuenta;
                    command.Parameters.AddWithValue("@ultimoMov", SqlDbType.DateTime).Value = ultimoMov;

                    command.ExecuteNonQuery();

                    retorno = true;
                }
                else
                {
                    //error
                    retorno = false;
                }
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }

        public SqlDataReader Consulta_cta_cli(int cta_cli, int index) //0 = cliente, 1 = cuenta
        {
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

        public SqlDataReader Combo()
        {
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "pa_combo";

            return command.ExecuteReader();
        }

        public bool Update_cli_cta(int cta_cli, int dni, string nombre, string apellido, int cbu_cli,
                                    int cbu_cta, int saldo, int tipoCuenta, DateTime ultimoMov) //0 = cliente, 1 = cuenta
        {
            bool retorno;

            try
            {
                if (cta_cli == 0)
                {
                    command.Connection = conexion;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pa_update_cli";
                    command.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                    command.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                    command.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = nombre;
                    command.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu_cli;
                    command.ExecuteNonQuery();

                    retorno = true;
                }
                else if (cta_cli == 1)
                {
                    command.Connection = conexion;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pa_update_cta";
                    command.Parameters.AddWithValue("@cbu", SqlDbType.Int).Value = cbu_cta;
                    command.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = saldo;
                    command.Parameters.AddWithValue("@tipoCuenta", SqlDbType.Int).Value = tipoCuenta;
                    command.Parameters.AddWithValue("@ultimoMov", SqlDbType.DateTime).Value = ultimoMov;
                    command.ExecuteNonQuery();

                    retorno = true;
                }
                else
                {
                    //error
                    retorno = false;
                }
            }
            catch
            {
                retorno = false;
            }


            return retorno;
        }

        public bool Delete_cta_cli(int cta_cli, int index)//0 = cliente, 1 = cuenta
        {
            bool retorno;

            try
            {
                if (cta_cli == 0)
                {
                    command.Connection = conexion;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pa_delet_cli";
                    command.Parameters.AddWithValue("@index", SqlDbType.Int).Value = index;
                    command.ExecuteNonQuery();

                    retorno = true;
                }
                else if (cta_cli == 1)
                {
                    command.Connection = conexion;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "pa_delet_cta";
                    command.Parameters.AddWithValue("@index", SqlDbType.Int).Value = index;
                    command.ExecuteNonQuery();

                    retorno = true;
                }
                else
                {
                    //error
                    retorno = false;
                }
            }
            catch
            {
                retorno = false;
            }


            return retorno;
        }
    }
}