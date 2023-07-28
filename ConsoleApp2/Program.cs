// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;

public class Kata
{
    static public void Main()
    {
        Random rnd = new Random();

        int size = rnd.Next(1, 15);
        string[] walk = new string[size];

        string[] direction = { "n", "s", "w", "e" };

        for(int i = 0; i < size; i++)
        {
            int a = rnd.Next(4);
            walk[i] = direction[a];
        }


        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(walk[i]);
        }
        
        IsValidWalk(walk);

    }


    public static bool IsValidWalk(string[] walk)
    {
        int x = 0;
        int y = 0;

        for (int i = 0; i < walk.Length; i++) {

            switch (walk[i])
            {
                    case "n":
                        y++;
                         break;
                
                    case "s":
                        y--;
                        break;
                
                    case "e":
                        x++;
                        break;
                    case "w":
                        x--;
                        break;
            }
        }

            if (x == 0 && y == 0 && walk.Length == 10)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("True");
                return false;
            }   
    }
}