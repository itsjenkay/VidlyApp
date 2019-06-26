using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using VidlyApp.Models;

namespace VidlyApp.Dtos
{
    public class MoviesDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public byte GenreId { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime ReleasedDate { get; set; }
        
        public byte NumbersInStock { get; set; }
    }
}