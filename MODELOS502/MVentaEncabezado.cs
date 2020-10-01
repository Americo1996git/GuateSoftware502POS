using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MVentaEncabezado
    {
        private int idVentaEncabezado;
        private int idCliente;
        private string nombreCliente;
        private string razonSocial;
        private string nit;
        private int idSerie;
        private string serie;
        private int correlativo;
        private int idTienda;
        private int idVendedor;
        private int idAutorizador;
        private int controlVentas;
        private decimal subTotal;
        private decimal iva;
        private decimal total;
        private int idTipoDeVenta;
        private int idUsuarioCreacion;
        private string comentarios;
        private int idTipoDeDocumento;

        public int IdVentaEncabezado
        {
            get
            {
                return idVentaEncabezado;
            }

            set
            {
                idVentaEncabezado = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }

            set
            {
                nombreCliente = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }

            set
            {
                razonSocial = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public int IdSerie
        {
            get
            {
                return idSerie;
            }

            set
            {
                idSerie = value;
            }
        }

        public string Serie
        {
            get
            {
                return serie;
            }

            set
            {
                serie = value;
            }
        }



        public int IdTienda
        {
            get
            {
                return idTienda;
            }

            set
            {
                idTienda = value;
            }
        }

        public int IdVendedor
        {
            get
            {
                return idVendedor;
            }

            set
            {
                idVendedor = value;
            }
        }

        public int IdAutorizador
        {
            get
            {
                return idAutorizador;
            }

            set
            {
                idAutorizador = value;
            }
        }

        public int ControlVentas
        {
            get
            {
                return controlVentas;
            }

            set
            {
                controlVentas = value;
            }
        }

        public decimal SubTotal
        {
            get
            {
                return subTotal;
            }

            set
            {
                subTotal = value;
            }
        }

        public decimal Iva
        {
            get
            {
                return iva;
            }

            set
            {
                iva = value;
            }
        }

        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public int IdTipoDeVenta
        {
            get
            {
                return idTipoDeVenta;
            }

            set
            {
                idTipoDeVenta = value;
            }
        }

        public int IdUsuarioCreacion
        {
            get
            {
                return idUsuarioCreacion;
            }

            set
            {
                idUsuarioCreacion = value;
            }
        }

        public string Comentarios
        {
            get
            {
                return comentarios;
            }

            set
            {
                comentarios = value;
            }
        }

        public int IdTipoDeDocumento
        {
            get
            {
                return idTipoDeDocumento;
            }

            set
            {
                idTipoDeDocumento = value;
            }
        }

        public int Correlativo
        {
            get
            {
                return correlativo;
            }

            set
            {
                correlativo = value;
            }
        }
    }
}
