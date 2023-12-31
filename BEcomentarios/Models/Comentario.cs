﻿using System.ComponentModel.DataAnnotations;

namespace BEcomentarios.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        [Required]
        public String Titulo { get; set; }
        [Required]
        public string Creador { get; set; }
        [Required]
        public string Texto { get; set; }
        [Required]
                
        public DateTime FechaCreacion { get; set; }
    }
}
