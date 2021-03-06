﻿using System.ComponentModel.DataAnnotations;

namespace MoviesCRUDApp.Models.Movies
{
    public class MovieInputModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int ReleaseYear { get; set; }

        public string Summary { get; set; }
    }
}
