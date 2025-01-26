namespace variaveis;

public class Pogram{
    public static void Main(){
        Console.WriteLine("Vaiaveis em .Net!");
        string myName = "Vinicius";
        int myAge = 20;
        double myHeight = 1.77;
        char mySex = 'M';
        Console.WriteLine("Meu nome e " + myName +" e eu tenho " + myAge + " anos, minha altura e " + myHeight + " metros.");
        if (mySex == 'M')
        {
            Console.WriteLine("Sou um homem.");
        }else{
            Console.WriteLine("SOu uma mulher.");
        };

        bool imDeveloper = true;
        if (imDeveloper){
            Console.WriteLine("Sou desenvolvedor.");
        }else{
            Console.WriteLine("Nao sou desenvolvedor.");
        };

        var variable = "Agora e uma string";
        Console.WriteLine(variable);
    }
}
