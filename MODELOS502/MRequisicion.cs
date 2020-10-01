using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MRequisicion
    {
        private int idcapturapedidodetalle;
        private int idcapturapedido;
        private int idtienda;
        private int idusuario;
        private string observacion;
        private bool autorizado;
        private bool anulado;
        private int idEstadoRequisicion;




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

  


        public string Observacion
        {
            get
            {
                return observacion;
            }

            set
            {
                observacion = value;
            }
        }


   

        public int Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
            }
        }

        public bool Autorizado
        {
            get
            {
                return autorizado;
            }

            set
            {
                autorizado = value;
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

        public bool Anulado
        {
            get
            {
                return anulado;
            }

            set
            {
                anulado = value;
            }
        }

        public int Idcapturapedidodetalle
        {
            get
            {
                return idcapturapedidodetalle;
            }

            set
            {
                idcapturapedidodetalle = value;
            }
        }

        public int IdEstadoRequisicion
        {
            get
            {
                return idEstadoRequisicion;
            }

            set
            {
                idEstadoRequisicion = value;
            }
        }
    }
}
