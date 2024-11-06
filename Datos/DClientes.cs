using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using ProyClientesEssential.Logica;
using System.Windows.Forms;

namespace ProyClientesEssential.Datos
{
    public class DClientes
    {
        public void InsertarClientes(Lclientes parametros)
        {
            try
            {   
                //nos conectamos a la base de datos
                conexionmaestra.abrir();
                SqlCommand cmd = new SqlCommand("InsertarClientes", conexionmaestra.conectar);

                //declaramos los parametros
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", parametros.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Edad", parametros.Edad);

                //ejecutamos el proceso
                cmd.ExecuteNonQuery();

                //mensaje que el cliente registrado ha sido correcto
                MessageBox.Show("Cliente Registrado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                //mensaje de error avanzado
                //MessageBox.Show(ex.StackTrace);
            }

            finally
            {
                conexionmaestra.cerrar();
            }
        }


        public void EliminarClientes(Lclientes parametros)
        {
            try
            {
                conexionmaestra.abrir();
                SqlCommand cmd = new SqlCommand("EliminarClientes", conexionmaestra.conectar);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idclientes", parametros.Idclientes);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Eliminado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                conexionmaestra.cerrar();
            }

        }


        public void EditarClientes(Lclientes parametros)
        {
            try
            {
                conexionmaestra.abrir();
                SqlCommand cmd = new SqlCommand("EditarClientes", conexionmaestra.conectar);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idclientes", parametros.Idclientes);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Edad", parametros.Edad);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro Actualizado");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }


        public void MostrarClientes(ref DataTable dt)
        {
            try
            {
                conexionmaestra.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarClientes", conexionmaestra.conectar);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                conexionmaestra.cerrar();
            }

        }
    }
}
