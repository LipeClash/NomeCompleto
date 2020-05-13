using System;

namespace auladepc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu primeiro nome");
            String Nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            String Sobrenome = Console.ReadLine();
        
            Console.WriteLine(Nome + " " +  Sobrenome);

             Console.WriteLine("Digite seu sobrenome");
             String CatálagoSobrenome = Console.ReadLine();

             Console.WriteLine("Digite seu primeiro nome");
             String CatálagoNome = Console.ReadLine();

             Console.WriteLine(CatálagoSobrenome + " " + CatálagoNome);

        }
    }
}
