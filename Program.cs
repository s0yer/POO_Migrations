using System;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            MetodosAuxiliares metodos = new MetodosAuxiliares();
            metodos.FirstTeste();


            Console.WriteLine("----------------------  START  -----------------------------");

            //GravarUsandoEntity();
            //RecuperarEmpresa();
            ExcluirEmpresa();

            Console.WriteLine("----------------------  END  -----------------------------");

        }

        private static void GravarUsandoEntity()
        {
            Empresa ark = new Empresa();
            ark.Id = Guid.NewGuid();
            ark.Nome = "Arkadas";
            ark.Cnpj = 8888888888888;
            ark.Criacao = DateTime.Now;

            //using (var repo = new EmpresaContext())
            //{
            //    repo.Adicionar(ark);
            //}

            using (var contexto = new EmpresaContext())
            {
                contexto.Empresas.Add(ark);
                contexto.SaveChanges();
            }
        }

        //private static void RecuperarEmpresa()
        //{
        //    using(var repo = new EmpresaContext())
        //    {
        //        IList<Empresa> empresas = repo.Empresas.ToList();
        //        foreach (var item in empresas)
        //        {
        //            Console.WriteLine(item.Nome);
        //        }
        //    }
        //}          

        private static void RecuperarEmpresa()
        {
            using (var contexto = new EmpresaContext())
            {
                var empresas = contexto.Empresas.ToList();
                foreach (var item in empresas)
                {
                    Console.WriteLine(item);
                }
            }
        }

        //private static void ExcluirEmpresa()
        //{
        //    using(var repo = new EmpresaContext())
        //    {
        //        IList<Empresa> empresas = repo.Empresas.ToList();
        //        foreach(var item in empresas)
        //        {
        //            repo.Empresas.Remove(item);
        //        }
        //        repo.SaveChanges();
        //    }
        //}        

        private static void ExcluirEmpresa()
        {
            using (var contexto = new EmpresaContext())
            {
                var empresas = contexto.Empresas.ToList();
                foreach (var item in empresas)
                {
                    contexto.Empresas.Remove(item);
                }
                contexto.SaveChanges();
            }
        }


    }

}