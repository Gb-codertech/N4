using System;
public class N4
{
    public static void Main(string[] args)
    {
        int n1 = 0;
        int n2 = 4;
        int n3 = 8;
        int n4 = 4;

        if (n1 != n2)
        {
            Console.WriteLine("Os números 1 e 2 são diferentes");
        }
        else 
        { 
            Console.WriteLine("Os números 1 e 2 são iguais"); 
        }

        if (n2 != n3)
        {
            Console.WriteLine("Os números 2 e 3 são diferentes");
        }
        else
        {
            Console.WriteLine("Os números 2 e 3 são iguais");
        }

        if (n3 != n4)
        {
            Console.WriteLine("Os números 3 e 4 são diferentes");
        }
        else
        {
            Console.WriteLine("Os números 3 e 4 são iguais");
        }

        if (n4 != n2)
        {
            Console.WriteLine("Os números 4 e 2 são diferentes");
        }
        else
        {
            Console.WriteLine("Os números 4 e 2 são iguais");
        }

        if (n3 != n1)
        {
            Console.WriteLine("Os números 3 e 1 são diferentes");
        }
        else
        {
            Console.WriteLine("Os números 3 e 1 são iguais");
        }
    }
}