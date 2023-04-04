using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite uma palavra: ");
        string input = Console.ReadLine();
        char[] chars = input.ToCharArray();
        int length = chars.Length;

        for (int i = 0; i < length / 2; i++)
        {
            char temp = chars[i];
            chars[i] = chars[length - 1 - i];
            chars[length - 1 - i] = temp;
        }

        string a = new string(chars);
        Console.WriteLine("A string invertida é: " + a);
    }
}