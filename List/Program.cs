namespace list;

public class Program {
    public static void Main(){
        bool varContinue = true;
        string name;
           List<string> fruits = new List<string>(){};
        while (varContinue)
        {
        Console.WriteLine("----------Lista Simples----------");
        Console.WriteLine("\nEscolha uma opcao: ");
        Console.WriteLine("1. Adicionar a lista (+)");
        Console.WriteLine("2. Remover na lista (-)");
        Console.WriteLine("3. Limpar a lista (*)");
        Console.WriteLine("4. Sair");
        Console.WriteLine("Digite o numero da opcao: ");
        int operation = Convert.ToInt32(Console.ReadLine());
        switch (operation)
        {
            case 1:
                Console.WriteLine("Digite o nome para adicionar:");
                name = Console.ReadLine();
                fruits.Add(name);
            break;
            case 2:
                Console.WriteLine("Digite o nome para remover:");
                name = Console.ReadLine();
                fruits.Remove(name);
            break;
            case 3:
                fruits.Clear();
            break;
            case 4:
                varContinue = false;
            break;
            default:
                Console.WriteLine("Opcao invalida!");
            break;
        }

        listFruits(fruits);
        }
    }

    public static void listFruits(List<string> fruits){
        Console.WriteLine("--------------------------------------------------------------");
        foreach (var item in fruits)
        {
            Console.WriteLine(item);
        }
         Console.WriteLine("--------------------------------------------------------------");
    }
}