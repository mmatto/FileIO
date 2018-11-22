using System;
using System.IO;


namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\mdmat\OneDrive\Documentos\Mario\projetos\vs2017\treinamento\fileRepositorio\File01.txt";
            string targetpath = @"C:\Users\mdmat\OneDrive\Documentos\Mario\projetos\vs2017\treinamento\fileRepositorio\File02.txt";
            try
            {
                FileInfo fileinfo = new FileInfo(sourcepath);
                fileinfo.CopyTo(targetpath);
                string[] lines = File.ReadAllLines(sourcepath); 
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("ocorreu um erro");
                Console.WriteLine(e.Message );
            }
            Console.ReadLine();
        }
    }
}
