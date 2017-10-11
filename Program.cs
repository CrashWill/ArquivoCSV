using System;
using System.IO;

namespace ArquivoCSV
{
    class Program
    {
        static void Main(string[] args)
     {
            
            string nome, email;
            int idade;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu email: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            idade = Int16.Parse(Console.ReadLine());

            StreamWriter arquivo = new StreamWriter("dados.csv",true);
            arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            arquivo.Close();







       
        }
    }
}
