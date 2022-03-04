using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GestionEmpresarial.Models
{
    public partial class Empleado
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string NombrePosicion { get; set; }
        public string Departamento { get; set; }
    }
}
