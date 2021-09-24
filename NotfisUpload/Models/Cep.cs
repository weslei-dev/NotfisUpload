﻿using System.ComponentModel.DataAnnotations;

namespace NotfisUpload.Models
{
    public class Cep
    {
        [Required]
        [MaxLength(9, ErrorMessage = "Cep tem que ser digitado no formato 70000-000")]
        [MinLength(9, ErrorMessage = "Cep tem que ser digitado no formato 70000-000")]
        public string Codigo { get; set; }
    }
}
