using System;

namespace Pruebatec_laboral.Models
{
    public class TrabajadorLista
    {
        public int Id { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombres { get; set; }
        public string Sexo { get; set; }
        public string NombreDepartamento { get; set; }
        public string NombreProvincia { get; set; }
        public string NombreDistrito { get; set; }
    }
}
