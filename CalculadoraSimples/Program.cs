namespace CalculadoraSimples;

public class Program {
    public static void Main(){
        bool varContinue = true;

        while (varContinue)
        {
          Console.WriteLine("----------Calculadora Simples----------");
        Console.WriteLine("Digite o primeiro numero:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEscolha uma operacao: ");
        Console.WriteLine("1. Adicao (+)");
        Console.WriteLine("2. Subtracao (-)");
        Console.WriteLine("3. Multiplicacao (*)");
        Console.WriteLine("4. Divisao (/)");
        Console.WriteLine("5. Sair");
        Console.WriteLine("Digite o numero da operacao: ");
        int operation = Convert.ToInt32(Console.ReadLine());

        double result = 0;
        if (operation == 1){
            result = number1 + number2;
        }else if(operation == 2){
            result = number1 - number2;
        }else if(operation == 3){
            result = number1 * number2;
        }else if(operation == 4){
            if (number2 != 0){
                result = number1 / number2;
            }else{
                Console.WriteLine("Nao e possivel fazer uma divisao por zero!");
            }
        }else if(operation == 5){
            varContinue = false;
        }else{
            Console.WriteLine("Operacao invalida!");
        }
            Console.WriteLine("Resultado: " + result + "\n");   
        }
        Console.WriteLine("Obrigado por usar a calculadora!");
    }
}