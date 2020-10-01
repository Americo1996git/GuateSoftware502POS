using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewGuate502.Reportes
{
    public partial class FormReporteRequisicion : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int idtienda;
        private int idcapturapedido;

        public int Idtienda
        {
            get
            {
                return idtienda;
            }

            set
            {
                idtienda = value;
            }
        }

        public int Idcapturapedido
        {
            get
            {
                return idcapturapedido;
            }

            set
            {
                idcapturapedido = value;
            }
        }

        public FormReporteRequisicion()
        {
            InitializeComponent();
        }

        private void FormReporteRequisicion_Load(object sender, EventArgs e)
        {
            //Requisicioes.ReporteRequisicion requisicion = new Requisicioes.ReporteRequisicion();
            //requisicion.mostrarReporte(Idtienda,Idcapturapedido);
            //requisicion.CreateDocument();

            //documentViewer1.DocumentSource = requisicion;
        }

        private void FormReporteRequisicion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
