namespace Condicionais;

public class Program{
    public static void Main(){
        Console.WriteLine("Estruturas condicionais em .Net");
        Console.WriteLine("----------------Verificador de Numeros Pares ou Impares----------------");
        Console.WriteLine("Digite o numero: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(VerifyEvenOdd(number));
    }

    public static string VerifyEvenOdd(int number){
        return number % 2 == 0 ? "Par" : "Impar";
    }
}