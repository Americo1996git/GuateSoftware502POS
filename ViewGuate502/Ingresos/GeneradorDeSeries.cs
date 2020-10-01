using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ViewGuate502.Ingresos
{
    class GeneradorDeSeries
    {
        static int CantidadRecibidos;
        static int idproducto;
        static int idgenordencompradetalle;
        static int contFilas = 0, cantidadAgregar = 0;

        public static void asignaciones(int cant_recibida,int cont_filas, int cantidad_agregar, int id_producto)
        {
            CantidadRecibidos = cant_recibida;
            contFilas = cont_filas;
            cantidadAgregar = cantidad_agregar;
            idgenordencompradetalle = id_producto;
        }

        public static DataTable GnerarSeries(DataTable table, DataTable table0)
        {
            int cont1 = 0;
            foreach (DataRow item in table.Rows)
            {
                if (Convert.ToInt32(item["idproducto"]) == idgenordencompradetalle)
                {
                    cont1++;
                    contFilas++;
                }
            }

            if (cont1 == 0)
            {
                for (int i = 0; i < CantidadRecibidos; i++)
                {
                    DataRow row = table.NewRow();
                    row["idproducto"] = idgenordencompradetalle;
                    row["numero"] = 0;
                    row["serie"] = "";
                    table.Rows.Add(row);
                }

            }
            else
            {


                if (contFilas >= CantidadRecibidos)
                {
                    cantidadAgregar = contFilas - CantidadRecibidos;
                    int cont = 0;
                    for (int i = table.Rows.Count - 1; i > 0; i--)
                    {
                        if (Convert.ToInt32(table.Rows[i]["idproducto"]) == idgenordencompradetalle)
                        {

                            if (cont == cantidadAgregar)
                            {
                                break;
                            }
                            else
                            {
                                DataRow row = table.Rows[i];
                                table.Rows.Remove(row);
                            }
                            cont++;
                        }

                    }
                }
                if (contFilas <= CantidadRecibidos)
                {
                    cantidadAgregar = CantidadRecibidos - contFilas;
                    for (int i = 0; i < cantidadAgregar; i++)
                    {
                        DataRow row = table.NewRow();
                        row["idproducto"] = idgenordencompradetalle;
                        row["numero"] = 0;
                        row["serie"] = "";
                        table.Rows.Add(row);
                    }


                }

            }

            int count = 1;
            foreach (DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row["idproducto"]) == idgenordencompradetalle)
                {

                    DataRow row1 = table0.NewRow();
                    row1["idproducto"] = row["idproducto"];
                    row1["numero"] = count;
                    row1["serie"] = row["serie"];
                    table0.Rows.Add(row1);
                    count++;
                }


            }
            return table0;
        }

        public static void OrdenarSeries(DataTable table0, DataTable table1, DataTable dtSeries)
        {
            int i = 0;
            foreach (DataRow row in table0.Rows)
            {
                if (Convert.ToInt32(row["idproducto"]) == idgenordencompradetalle)
                {
                    row["idproducto"] = idgenordencompradetalle;
                    row["numero"] = dtSeries.Rows[i]["numero"];
                    row["serie"] = dtSeries.Rows[i]["serie"];
                    i++;
                }

            }


            var index = from row in table0.AsEnumerable()
                        let parte1 = row.Field<int>("idproducto")
                        let parte2 = row.Field<int>("numero")
                        orderby parte1, parte2
                        select row;

            table0 = index.CopyToDataTable();

            table1.Rows.Clear();
        }




    }
}
