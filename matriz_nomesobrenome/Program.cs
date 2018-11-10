using System;

namespace matriz_nomesobrenome
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdLinhas = 2, qtdColunas = 2;
            string[,] m = new string[qtdLinhas, qtdColunas];

            string conteudo = "";

            for (int i = 0; i < qtdLinhas; i++)
            {
                for (int j = 0; j < qtdColunas; j++)
                {
                    if (j == 0) Console.WriteLine("Informe o NOME: ");
                    if (j == 1) Console.WriteLine("Informe o SOBRENOME: ");

                    m[i, j] = Console.ReadLine();
                    conteudo += m[i, j] + " ";
                }
                conteudo += "\n";
            }
            Console.WriteLine(conteudo);
        }
    }
}
