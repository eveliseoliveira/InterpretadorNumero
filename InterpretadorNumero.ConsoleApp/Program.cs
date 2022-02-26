using System;

namespace InterpretadorNumero.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero = "     __  __      __  __ __  __  __  __ \n" +
                            "  |  __| __||__||__ |__   ||__||__||  |\n" +
                            "  | |__  __|   | __||__|  ||__| __||__|\n";


            System.IO.StringReader leitor_texto = new(numero);

            string primeira_linha = leitor_texto.ReadLine();

            char[] primeira = primeira_linha.ToCharArray();

            string segunda_linha = leitor_texto.ReadLine();

            char[] segunda = segunda_linha.ToCharArray();

            string terceira_linha = leitor_texto.ReadLine();

            char[] terceira = terceira_linha.ToCharArray();


            int contador = 0;
            int leitor = 4;

            for (int i = 0; i < primeira.Length; i += 4)
            {
                string linha_um = "";
                string linha_dois = "";
                string linha_tres = "";

                for (int j = contador; j < leitor; j++)
                {
                    linha_um += Convert.ToString(primeira[j]);
                    linha_dois += Convert.ToString(segunda[j]);
                    linha_tres += Convert.ToString(terceira[j]);
                }

                if (linha_um == "    " && linha_dois == "  | " && linha_tres == "  | ")
                    Console.Write(1);

                if (linha_um == " __ " && linha_dois == "__| " && linha_tres == "|__ ")
                    Console.Write(2);

                if (linha_um == " __ " && linha_dois == "__| " && linha_tres == "__| ")
                    Console.Write(3);

                if (linha_um == "    " && linha_dois == "|__|" && linha_tres == "  | ")
                    Console.Write(4);

                if (linha_um == " __ " && linha_dois == "|__ " && linha_tres == " __|")
                    Console.Write(5);

                if (linha_um == " __ " && linha_dois == "|__ " && linha_tres == "|__|")
                    Console.Write(6);

                if (linha_um == " __ " && linha_dois == "  | " && linha_tres == "  | ")
                    Console.Write(7);

                if (linha_um == " __ " && linha_dois == "|__|" && linha_tres == "|__|")
                    Console.Write(8);

                if (linha_um == " __ " && linha_dois == "|__|" && linha_tres == " __|")
                    Console.Write(9);

                if (linha_um == " __ " && linha_dois == "|  |" && linha_tres == "|__|")
                    Console.Write(0);

                leitor += 2;
                contador++;
            }

            Console.ReadLine();
        }
    }
}
