﻿namespace Oficina.Dominio
{
    public class Veiculo
    {
        public string Placa { get; set;}
        public int Ano { get; set;}
        public Cor Cor{ get; set; }
        public string obervacao { get; set; }
        public Modelo Modelo { get; set; }
        public Cambio Cambio { get; set; }
        public Combustivel Combustivel { get; set; }

    }
}