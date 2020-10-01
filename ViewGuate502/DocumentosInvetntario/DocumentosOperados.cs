using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewGuate502.DocumentosInvetntario
{
    public class DocumentosOperados
    {

        public static void ImprimirDocumento(int correlativo, int id_tienda, int id_documento_inventario, int id_origen, int id_destino)
        {
            Ingresos.FormImprimirIngreso imprimir = new Ingresos.FormImprimirIngreso();
            imprimir.codigo = correlativo;
            imprimir.id_tienda = id_tienda;
            imprimir.id_documento_inventario = id_documento_inventario;
            imprimir.id_origen = id_origen;
            imprimir.id_destino = id_destino;
            imprimir.ShowDialog();
        }

        public static void ImprimirDocumentoGenerado(int correlativo, int id_tienda, int id_documento_inventario, int id_origen, int id_destino,bool ingresado,int opcion)
        {
            Reportes.DocumentosInventario.FormImprimirDocGenerado reporte = new Reportes.DocumentosInventario.FormImprimirDocGenerado();
            reporte.codigo = correlativo;
            reporte.id_tienda = id_tienda;
            reporte.id_tipo_documento_inventario = id_documento_inventario;
            reporte.id_origen = id_origen;
            reporte.id_destino = id_destino;
            reporte.ingresado = ingresado;
            reporte.opcion = opcion;
            reporte.ShowDialog();
        }

    }
}
