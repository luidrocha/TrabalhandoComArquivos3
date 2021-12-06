using System;
using System.IO;

namespace TrabalhandoComArquivos3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\File1.txt";

            try
            {
                // o Comando using fecha automaticamentes as classes que não são controladas pelo CLI                                                                                                                                                                                                                         
                //  using (FileStream fs = new FileStream(path, FileMode.Open))
                
                    using (StreamReader sr = File.OpenText(path))  //Simplificando usa-se o File
                    {
                        while (!sr.EndOfStream)
                        {
                            string linha = sr.ReadLine();
                            Console.WriteLine(linha);
                        }


                    }
                
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Ocorreu erro no arquivo: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
