using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace ProyClientesEssential.Datos
{
    public class conexionmaestra
    {
        //autentificacion de windows
        public static string conexion = @"Data source=DESKTOP-4N38VGD\SQLEXPRESS; Initial Catalog=ClientesEssentialDB; Integrated Security=true";
        
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
