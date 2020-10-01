using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MCliente
    {
        public int idCliente { get; set; }
        public int idEstadoCivil { get; set; }
        public int IdSubGrupo { get; set; }
        public int IdUsuario { get; set; }
        public string identificacion { get; set; }
        public string primerNombre { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string apellidoCasada { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string direccion { get; set; }
        public string DireccionFiscal { get; set; }
        public string RazonSocial { get; set; }
        public string email { get; set; }
        public bool ConTelefonos { get; set; }
        public string empresaLabora { get; set; }
        public string cargo { get; set; }
        public string nit { get; set; }
        public bool manejaCuentaBanco { get; set; }
        public bool negocioPropio { get; set; }
        public string tipoNegocio { get; set; }
        public string tiempoNegocio { get; set; }
        public int cantidadHijos { get; set; }
        public double cantidadAportesFamilia { get; set; }
        public bool casaPropia { get; set; }
        public string tiempoResidir { get; set; }
        public bool trabajaPareja { get; set; }
        public string trabajoPareja { get; set; }
        public string descripcion { get; set; }
        public bool ConObservaciones { get; set; }
        public bool EsFiador { get; set; }
        public int LimiteDeCredito { get; set; }
        public int IdTelefono { get; set; }
        public int Opcion { get; set; }
        public string Telefono { get; set; }

    }
}
