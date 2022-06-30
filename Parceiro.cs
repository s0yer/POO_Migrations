using System;

namespace OOP
{
    public class Parceiro : EntidadeBase
    {
        public string Nome{get; set;}
        public DateTime Cadastro {get; set;}
        public long Cnpj { get; set; }
        public List<Obra> Obras { get; set;}

    }
}