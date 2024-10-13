using System.IO;

namespace name{


public class Loops{

public void demonstrations(){


    Console.WriteLine("Using a for loop:");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("\nUsing a while loop:");
    int j = 1;
    while (j <= 10)
    {
        Console.WriteLine(j);
        j++;
    }

    Console.WriteLine("\nUsing a do-while loop:");
    int k = 1;
    do
    {
        Console.WriteLine(k);
        k++;
    } while (k <= 10);

}

}
}