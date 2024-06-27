﻿namespace BiblioMonolitica.web.Data.Models.NumeroCorrelativoModels
{
    public class NumeroCorrelativoBaseModel : ModelBaseNumeroCorrelativo
    {
        public string? Prefijo { get; set; }

        public string? Tipo { get; set; }

        public int? UltimoNumero { get; set; }

        public DateTime? FechaRegistro { get; set; }

    }
}