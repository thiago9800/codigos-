using System;

class Program
{
    static void Main()
    {
        // Define o faturamento mensal por estado
        double faturamentoSP = 67836.43;
        double faturamentoRJ = 36678.66;
        double faturamentoMG = 29229.88;
        double faturamentoES = 27165.48;
        double faturamentoOutros = 19849.53;

        // Calcula o valor total mensal da distribuidora
        double faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

        // Calcula o percentual de representação de cada estado no faturamento total
        double percentualSP = faturamentoSP / faturamentoTotal * 100;
        double percentualRJ = faturamentoRJ / faturamentoTotal * 100;
        double percentualMG = faturamentoMG / faturamentoTotal * 100;
        double percentualES = faturamentoES / faturamentoTotal * 100;
        double percentualOutros = faturamentoOutros / faturamentoTotal * 100;

        // Imprime os resultados
        Console.WriteLine("O faturamento Total e:{0:F2}",faturamentoTotal);
        Console.WriteLine("Percentual de representação do estado de SP: {0:F2}%", percentualSP);
        Console.WriteLine("Percentual de representação do estado do RJ: {0:F2}%", percentualRJ);
        Console.WriteLine("Percentual de representação do estado de MG: {0:F2}%", percentualMG);
        Console.WriteLine("Percentual de representação do estado do ES: {0:F2}%", percentualES);
        Console.WriteLine("Percentual de representação dos demais estados: {0:F2}%", percentualOutros);
    }
}
