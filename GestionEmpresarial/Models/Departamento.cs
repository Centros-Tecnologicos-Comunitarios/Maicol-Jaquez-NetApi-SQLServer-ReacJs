using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GestionEmpresarial.Models
{
    public partial class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string NombreEmpleado { get; set; }
        public string NombreEmpleadoId { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public DateTime FechaDeCreacion { get; set; }
    }
}
