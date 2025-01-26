namespace Arrays;

public class Program{
    public static void Main(){
        Console.WriteLine("Arrays em .Net");
        string[] fruits = {"Banana", "Maca", "Caju", "Manga"};
        Console.WriteLine(fruits[1]);
        Console.WriteLine("----------------------------------------");
        foreach (var item in fruits)
        {
                Console.WriteLine(item);
        }

        fruits[1] = "Abacaxi";

        Console.WriteLine("----------------------------------------");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine(fruits[i]);
        }
    }
}