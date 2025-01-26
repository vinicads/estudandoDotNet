namespace OutputInput;

public class Program{
    public static void Main(){
        string email, password;
        Console.WriteLine("Output e Input no .Net");
        Console.WriteLine("--------Login--------");
        
        Console.WriteLine("Digite seu e-mail:");
        email = Console.ReadLine();
        
        Console.WriteLine("Digite a senha:");
        password = Console.ReadLine();
        
        if (email == "email@email.com" && password == "admin"){
            Console.WriteLine("Login realizado com sucesso.");
        }else{
            Console.WriteLine("E-mail ou senha invalidos.");
        }
    }
}