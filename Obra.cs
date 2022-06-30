using System;

namespace OOP
{
    public class Obra : EntidadeBase
    {
        public string Nome { get; set; }
        public long Cnpj { get; set; }
        public string Descricao {get; set;}
        public Parceiro Parceiro { get; set; }
        public Empresa Empresa { get; set; }


    }
}