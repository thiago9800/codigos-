using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        // Lê o arquivo JSON com o faturamento diário
        string json = File.ReadAllText("faturamento.json");
        int[] faturamentoDiario = JsonConvert.DeserializeObject<int[]>(json);

        // Calcula o menor e o maior valor de faturamento diário
        int menorFaturamento = faturamentoDiario.Where(valor => valor > 0).Min();
        int maiorFaturamento = faturamentoDiario.Max();

        // Calcula a média mensal de faturamento, ignorando os dias sem faturamento
        double mediaMensal = faturamentoDiario.Where(valor => valor > 0).Average();

        // Calcula o número de dias no mês em que o faturamento diário foi superior à média mensal
        int diasAcimaDaMedia = faturamentoDiario.Count(valor => valor > mediaMensal);

        // Imprime os resultados
        Console.WriteLine("Menor faturamento diário: {0}", menorFaturamento);
        Console.WriteLine("Maior faturamento diário: {0}", maiorFaturamento);
        Console.WriteLine("Número de dias com faturamento acima da média mensal: {0}", diasAcimaDaMedia);
    }
}
