using System;
using System.IO;

namespace ArquivoCSV
{
    class Program
    {
        static void Main(string[] args)
     {
            Console.Clear();
            string nome, email;
            int idade;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu email: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            idade = Int16.Parse(Console.ReadLine());

            FileInfo fi = new FileInfo("dados_cabecalho.csv");
            
            StreamWriter arquivo;
            
            if(fi.Exists){
            arquivo = new StreamWriter("dados_cabecalho.csv",true);
            arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            }
            else{
            arquivo = new StreamWriter("dados_cabecalho.csv",true);
            arquivo.WriteLine("Nome;Email;Idade;Data de Cadastro");
            arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            }
            
            arquivo.Close();

            
       
        }
    }
}
