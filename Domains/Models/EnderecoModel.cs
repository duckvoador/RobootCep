﻿namespace Domains.Models
{
    public class EnderecoModel
    {
        public string Id { get; set; }
        public string CEP { get; set; }
        public string? Logadouro { get; set; }
        public string? Bairro { get; set; }
        public string? UF { get; set; }

    }
}
