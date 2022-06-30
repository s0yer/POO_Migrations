using System;

namespace OOP
{
    public class Empresa : EntidadeBase // herda de Entidadee base
    {
        public string Nome {get; set;}
        public long Cnpj {get; set;}

        public override string ToString()
        {
            return $"Produto: {this.Id}, {this.Nome},{this.Cnpj},{this.Criacao}";
        }

        //public Empresa()
        //{
        //    this.Nome = "Arkadas";
        //}
    }




}