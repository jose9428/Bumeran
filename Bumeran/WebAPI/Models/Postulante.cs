using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Postulante
    {
        public int IdPostulante { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Nacionalidad { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Genero { get; set; }
        public string? Dni { get; set; }
        public string? Direccion { get; set; }
        public string? Celular { get; set; }
        public string? Foracademica { get; set; }
        public string? Idioma { get; set; }
        public decimal? Salario { get; set; }
        public string? Expericencia { get; set; }
        public string? Conocimientos { get; set; }
    }
}
