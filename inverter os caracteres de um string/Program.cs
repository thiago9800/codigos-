using System;

class Program
{
    static void Main()
    {
        // Pede ao usuário para digitar uma string
        Console.WriteLine("Digite uma string:");
        string entrada = Console.ReadLine();

        // Converte a string para um array de caracteres
        char[] caracteres = entrada.ToCharArray();

        // Inverte a ordem dos caracteres no array
        int i = 0;
        int j = caracteres.Length - 1;

        while (i < j)
        {
            char temp = caracteres[i];
            caracteres[i] = caracteres[j];
            caracteres[j] = temp;
            i++;
            j--;
        }

        // Converte o array de caracteres de volta para uma string
        string saida = new string(caracteres);

        // Imprime a string invertida
        Console.WriteLine("A string invertida é: {0}", saida);
    }
}