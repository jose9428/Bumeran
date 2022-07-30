using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Publicacion
    {
        public int IdPublicacion { get; set; }
        public string? Puesto { get; set; }
        public string? Descrip { get; set; }
        public string? IdDepartamento { get; set; }
        public string? Departamento { get; set; }
        public string? Distrito { get; set; }
        public string? Lugar { get; set; }
        public string? Area { get; set; }
        public string? Jerarquia { get; set; }
        public decimal? Sueldo { get; set; }
        public string? NomEmpresa { get; set; }
        public string? Tipempleo { get; set; }
        public string? Modalidad { get; set; }
        public int? Vacantes { get; set; }
        public string? Habilidades { get; set; }
    }
}
