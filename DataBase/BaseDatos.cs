using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


namespace ApiRest.DataBase
{
    public class BaseDatos
    {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-NAQSPQP; database=ejemplo ; integrated security = true");
   
    }
}