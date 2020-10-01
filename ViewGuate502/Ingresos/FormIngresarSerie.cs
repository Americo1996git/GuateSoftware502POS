using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ControllerSoft502;

namespace ViewGuate502.Ingresos
{
    public partial class FormIngresarSerie : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int CantidadRecibidos;
        public string producto;
        public int idgenordencompradetalle; //esta variable es equivalente al id_producto
        int contFilas = 0, cantidadAgregar = 0;
        public int tipo_ingreso = 0;
        public int id_ingreso_detalle;
        DataTable dtSeries;

       
        bool EsBotonOTecla;
        FormIngresosMercaderia ingresos = FormIngresosMercaderia.GetInstancia();
        FormIngresoPorTraslado ingresosTraslado = FormIngresoPorTraslado.GetInstancia(0);

        Ventas.RealizarVenta ventas = Ventas.RealizarVenta.GetInstancia(1);


        public FormIngresarSerie()
        {
            InitializeComponent();
        }

        public void GnerarSeries(DataTable table, DataTable table0)
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
            gridControlSeries.DataSource = table0;
        }

        public void OrdenarSeries(DataTable table0, DataTable table1)
        {
            int i = 0;
            foreach (DataRow row in table0.Rows)
            {
                if (Convert.ToInt32(row["idproducto"]) == idgenordencompradetalle)
                {
                    row["idproducto"] = idgenordencompradetalle;
                    row["numero"] = gridViewSerieProducto.GetRowCellValue(i, "numero");
                    row["serie"] = gridViewSerieProducto.GetRowCellValue(i, "serie");
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

        private void FormIngresarSerie_Load(object sender, EventArgs e)
        {
            bool agregarNuevas = false;
            txtProducto.Text = producto;

            if (tipo_ingreso == 0) // 0 si es ingreso de series por orden de compra
            {
                //GnerarSeries(ingresos.dtSeries, ingresos.dtSeriesCopia);
                GeneradorDeSeries.asignaciones(CantidadRecibidos,contFilas,cantidadAgregar,idgenordencompradetalle);
                dtSeries = GeneradorDeSeries.GnerarSeries(ingresos.dtSeries, ingresos.dtSeriesCopia);
                gridControlSeries.DataSource = dtSeries;
            }
            if (tipo_ingreso == 1) // 1 si es ingreso por trasaldo entre tiendas
            {
                GeneradorDeSeries.asignaciones(CantidadRecibidos, contFilas, cantidadAgregar, idgenordencompradetalle);
                dtSeries = GeneradorDeSeries.GnerarSeries(ingresosTraslado.dtSeries, ingresosTraslado.dtSeriesCopia);
                gridControlSeries.DataSource = dtSeries;
            }
            if (tipo_ingreso == 3) // si es 3 es correccion de series
            {
                gridControlSeries.DataSource = ControllerIngresoTrasladoTienda.MostrarSereisDeProductosPorIngresos(id_ingreso_detalle, 0);
            }
            if (tipo_ingreso == 4) // si es 4 es ingresos por ventas
            {
                GeneradorDeSeries.asignaciones(CantidadRecibidos, contFilas, cantidadAgregar, idgenordencompradetalle);
                dtSeries = GeneradorDeSeries.GnerarSeries(ventas.dtSeries, ventas.dtSeriesCopia);
                gridControlSeries.DataSource = dtSeries;
            }

        }





        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
  
        }


        private void FormIngresarSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void FormIngresarSerie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tipo_ingreso == 3)
            {
                bool listo = true;
                string res = "";
                for (int a = 0; a < gridViewSerieProducto.DataRowCount; a++)
                {
                    ControllerIngresoTrasladoTienda.AcutuallizarSeries(Convert.ToInt32(gridViewSerieProducto.GetRowCellValue(a, "id_movimiento_det")),0, gridViewSerieProducto.GetRowCellValue(a, "serie").ToString(), Convert.ToInt32(gridViewSerieProducto.GetRowCellValue(a, "id_serie")));
                }
                e.Cancel = listo == false ? true : false;
            }
            else
            {
                if (EsBotonOTecla)
                {
                    bool listo = true;
    
                    if (!listo)
                    {
                        e.Cancel = true;
                    }
                    if (listo)
                    {
                        if (tipo_ingreso == 0)
                        {
                            GeneradorDeSeries.OrdenarSeries(ingresos.dtSeries, ingresos.dtSeriesCopia, dtSeries);
                            e.Cancel = false;
                        }
                        if (tipo_ingreso == 1)
                        {

                            GeneradorDeSeries.OrdenarSeries(ingresosTraslado.dtSeries, ingresosTraslado.dtSeriesCopia, dtSeries);
                            e.Cancel = false;
                        }
                        if (tipo_ingreso == 4)
                        {

                            GeneradorDeSeries.OrdenarSeries(ventas.dtSeries, ventas.dtSeriesCopia, dtSeries);
                            e.Cancel = false;
                        }

                    }

                }
                else
                {
                    bool listo = true;
                    if (!listo)
                    {
                        e.Cancel = true;
                    }

                    if (listo)
                    {
                        if (tipo_ingreso == 0)
                        {
                            GeneradorDeSeries.OrdenarSeries(ingresos.dtSeries, ingresos.dtSeriesCopia,dtSeries);
                            e.Cancel = false;
                        }
                        if (tipo_ingreso == 1)
                        {

                            GeneradorDeSeries.OrdenarSeries(ingresosTraslado.dtSeries, ingresosTraslado.dtSeriesCopia, dtSeries);
                            e.Cancel = false;
                        }
                        if (tipo_ingreso == 4)
                        {

                            GeneradorDeSeries.OrdenarSeries(ventas.dtSeries, ventas.dtSeriesCopia, dtSeries);
                            e.Cancel = false;
                        }
                    }



                }
            }
           
        }

      

        private void FormIngresarSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnGrabar.Focus();
                EsBotonOTecla = true;
                this.Close();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            EsBotonOTecla = true;
            this.Close();
        }
    }
}