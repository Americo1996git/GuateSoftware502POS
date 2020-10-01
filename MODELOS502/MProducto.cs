using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MProducto
    {
        private int idproducto;
        private int idtienda;
        private int idlinea;
        private int idsublinea;
        private int idmarca;
        private string nombre;
        private string codigo;
        private decimal precioa;
        private decimal preciob;
        private decimal precioc;
        private string rutaImagen;
        private string rutaImagenEliminacion;
        private string rutaImagenInsercion;
        private int mesesGarantia;
        private string utilizaImagen;
        private string estado;
        private string conCaracteristica;
        private string presentacion;
        private string completo;
        private string esReciente;
        private decimal descuento;
        private string utilizaSublinea;
        private string utilizaMarca;
        private decimal ultimocosto;
        private string aplicaSerie;
        private string nombreLinea;
        private string activarImagen;
        private string modelo;

        public int Idproducto
        {
            get
            {
                return idproducto;
            }

            set
            {
                idproducto = value;
            }
        }

        public int Idlinea
        {
            get
            {
                return idlinea;
            }

            set
            {
                idlinea = value;
            }
        }

        public int Idsublinea
        {
            get
            {
                return idsublinea;
            }

            set
            {
                idsublinea = value;
            }
        }

        public int Idmarca
        {
            get
            {
                return idmarca;
            }

            set
            {
                idmarca = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public decimal Precioa
        {
            get
            {
                return precioa;
            }

            set
            {
                precioa = value;
            }
        }

        public string RutaImagen
        {
            get
            {
                return rutaImagen;
            }

            set
            {
                rutaImagen = value;
            }
        }

        public int MesesGarantia
        {
            get
            {
                return mesesGarantia;
            }

            set
            {
                mesesGarantia = value;
            }
        }

        public decimal Preciob
        {
            get
            {
                return preciob;
            }

            set
            {
                preciob = value;
            }
        }

        public decimal Precioc
        {
            get
            {
                return precioc;
            }

            set
            {
                precioc = value;
            }
        }

        public string UtilizaImagen
        {
            get
            {
                return utilizaImagen;
            }

            set
            {
                utilizaImagen = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string ConCaracteristica
        {
            get
            {
                return conCaracteristica;
            }

            set
            {
                conCaracteristica = value;
            }
        }

        public string Presentacion
        {
            get
            {
                return presentacion;
            }

            set
            {
                presentacion = value;
            }
        }

        public string Completo
        {
            get
            {
                return completo;
            }

            set
            {
                completo = value;
            }
        }

        public string EsReciente
        {
            get
            {
                return esReciente;
            }

            set
            {
                esReciente = value;
            }
        }



        public decimal Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        public string UtilizaSublinea
        {
            get
            {
                return utilizaSublinea;
            }

            set
            {
                utilizaSublinea = value;
            }
        }

        public string UtilizaMarca
        {
            get
            {
                return utilizaMarca;
            }

            set
            {
                utilizaMarca = value;
            }
        }

        public decimal Ultimocosto
        {
            get
            {
                return ultimocosto;
            }

            set
            {
                ultimocosto = value;
            }
        }

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

        public string NombreLinea
        {
            get
            {
                return nombreLinea;
            }

            set
            {
                nombreLinea = value;
            }
        }

        public string AplicaSerie
        {
            get
            {
                return aplicaSerie;
            }

            set
            {
                aplicaSerie = value;
            }
        }

        public string RutaImagenEliminacion
        {
            get
            {
                return rutaImagenEliminacion;
            }

            set
            {
                rutaImagenEliminacion = value;
            }
        }

        public string RutaImagenInsercion
        {
            get
            {
                return rutaImagenInsercion;
            }

            set
            {
                rutaImagenInsercion = value;
            }
        }

        public string ActivarImagen
        {
            get
            {
                return activarImagen;
            }

            set
            {
                activarImagen = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }
    }
}
