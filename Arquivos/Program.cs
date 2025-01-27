namespace Arquivos;
using System.IO;
public class Program {
    public static void Main(){
        Console.WriteLine("Manipulando arquivos em .Net");

        //criar arquivos
        string path = @"C:\Users\vinic\OneDrive\Área de Trabalho\Projetos\.net\Arquivos\file.txt";
        System.IO.File.WriteAllText(path, "Ola, mundo!");

        //deletando arquivo
        File.Delete(path);
    }
}