namespace OOP
{
    public class Fornecedor : EntidadeBase
    {
        public Obra Obra {get; set;}
        public string Nome { get; set; }
        public long Cnpj { get; set; }
    }

}