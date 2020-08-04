﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace M_CHAT.Models
{
    public class Preguntas : BaseEntity
    {
        [Required(ErrorMessage = "Pregunta is required.")]
        [Display(Prompt = "Pregunta")]
        public string Texto { get; set; }
        [Display(Prompt = "Valor")]
        public string Valor { get; set; }

        public int NiñoID { get; set; }
        public Niño Niño { get; set; }
    }
}
