using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ControllerSoft502;

namespace ViewGuate502.Configuraciones
{
    class Configuraciones
    {
        public static int idtienda = 1;
        public static string tienda = "Local";
        public static int idusuario = 1;
        public static string usuario = "admin";
        public static string NombreDelSistema = "COMERCIALES AGLY";
        DashBoard dashboard;

        public static bool InventarioCerrado()
        {
            DataTable dt = new DataTable();
            bool Cerrado;
            dt = ControllerCierre.ValidarMes(DateTime.Now.Month - 1);
            if (dt.Rows[0]["aviso"].ToString() == "ABIERTO")
            {
                Cerrado = false;
            }
            else
            {
                Cerrado = true;
            }
            return Cerrado;
        }
    }
}
