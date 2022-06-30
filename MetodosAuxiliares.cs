namespace OOP
{
    public class MetodosAuxiliares
    {


        public void FirstTeste()
        {
            Console.WriteLine("------------------  START PROGRAM  ----------------------------");
            Console.WriteLine("----------------------  OOP  -----------------------------");

            var monteverde = new Obra()
            {
                Id = Guid.NewGuid(),
                Descricao = "Programacao de uma nova estrutura",
                Criacao = DateTime.Now,

            };

            var arkadas = new Parceiro()
            {
                Id = Guid.NewGuid(),
                Criacao = DateTime.Now,
                Nome = "Parceiro da macaxeira",
                Cnpj = 888888888888888888,
                //Obra = monteverde,
            };

            var ferramentasecia = new Fornecedor()
            {
                Id = Guid.NewGuid(),
                Criacao = DateTime.Now,
                Nome = "Oliveiras Construtora",
                Cnpj = 555555555555555555,
                //Obra = monteverde,
            };

            // imprimefornecedor
            Console.WriteLine(ferramentasecia);
            Console.WriteLine(ferramentasecia.Id);
            Console.WriteLine(ferramentasecia.Cnpj);
            Console.WriteLine(ferramentasecia.Nome);
            Console.WriteLine(ferramentasecia.Obra);
            Console.WriteLine(monteverde.Criacao);



            Console.WriteLine("-------------------------------------------------------");

            // imprime fornecedor
            Console.WriteLine(arkadas);
            Console.WriteLine(arkadas.Id);
            Console.WriteLine(arkadas.Cnpj);
            Console.WriteLine(arkadas.Nome);
            //Console.WriteLine(arkadas.Obra);
            Console.WriteLine(arkadas.Criacao);

            Console.WriteLine("----------------------  X  -----------------------------");

            //using (var contexto = new EmpresaContext())
            //{
            //    var empresas = contexto.Empresas.ToList();
            //    foreach (var item in empresas)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //var item1 = empresas.First();
            //item1.Nome = "Arkadas";


            Console.WriteLine("----------------------  Y  -----------------------------");

            Console.WriteLine("---------------------END----------------------------------");
        }
    }

}