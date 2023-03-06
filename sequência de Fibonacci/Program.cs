using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        int anterior = 0, atual = 1, proximo = 1;
        bool pertence = false;

        while (proximo <= numero)
        {
            if (proximo == numero)
            {
                pertence = true;
            }

            proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }

        if (pertence)
        {
            Console.WriteLine("{0} pertence à sequência de Fibonacci.", numero);
        }
        else
        {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", numero);
        }
    }
}
