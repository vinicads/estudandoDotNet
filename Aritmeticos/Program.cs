namespace Aritmeticos;

public class Program{
    public static void Main(){
        Console.WriteLine("Operadores Aritméticos em .Net");
        Console.WriteLine("-------------Calculadora Simples-------------");
        Console.WriteLine("Digite o primeiro numero:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;
        int subtaction = number2 - number1;
        int multiplication = number1 * number2;
        int division = number2 / number1;
        int module = number2 % number1;
        Console.WriteLine("A soma dos numeros eh: " + sum);
        Console.WriteLine("A subtracao dos numeros eh: " + subtaction);
        Console.WriteLine("A multiplicacao dos numeros eh: " + multiplication);
        Console.WriteLine("A divisao dos numeros eh: " + division);
        Console.WriteLine("O resto da divisao dos numeros eh: " + module);
    }
}
