using System;

{
    
    Console.Write("a2 = ");
    int a2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("a1 = ");
    int a1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b2 = ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b1 = ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    a2 = a2 + b2 + (a1 + b1) / 10;
    a1 = (a1 + b1) % 10;
    Console.Write($"c={a2}{a1}");
}