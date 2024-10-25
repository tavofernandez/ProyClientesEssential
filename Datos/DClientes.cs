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
    }
}
