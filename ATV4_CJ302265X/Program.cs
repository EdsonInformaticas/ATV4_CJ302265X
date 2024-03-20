namespace ATV4_CJ302265X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nrm;
            Console.WriteLine("/////////////////////////////////////////////////////////\nescolha qual operação deseja\n1-divisão\n2-multiplicação\n3-soma\n4-subtração\n5-potência\n/////////////////////////////////////////////////////////");
            nrm = int.Parse(Console.ReadLine());
            switch (nrm)
            {
                case 1:
                    Console.WriteLine("Escreva o número que deseja dividir e o divisor, respectivamente em linhas separadas");
                    int nmr1, nmr2;
                    float resul;
                    nmr1 = int.Parse(Console.ReadLine());
                    nmr2 = int.Parse(Console.ReadLine());
                    resul = nmr1 / nmr2;
                    Console.WriteLine("o resultado é {0}", resul) ;

                    break;
                case 2:
                    Console.WriteLine("Escreva os números que deseja multiplicar, respectivamente em linhas separadas");
                    int nmr3, nmr4;
                    float resul2;
                    nmr3 = int.Parse(Console.ReadLine());
                    nmr4 = int.Parse(Console.ReadLine());
                    resul2 = nmr3 * nmr4;
                    Console.WriteLine("o resultado é {0}", resul2);

                    break;
                    case 3:
                    Console.WriteLine("Escreva os números que deseja somar, respectivamente em linhas separadas");
                    int nmr5, nmr6;
                    float resul3;
                    nmr5 = int.Parse(Console.ReadLine());
                    nmr6 = int.Parse(Console.ReadLine());
                    resul3 = nmr5 + nmr6;
                    Console.WriteLine("o resultado é {0}", resul3);
                    break;
                    case 4:
                    Console.WriteLine("Escreva os números que deseja subtrair, respectivamente em linhas separadas");
                    int nmr7, nmr8;
                    float resul4;
                    nmr7 = int.Parse(Console.ReadLine());
                    nmr8 = int.Parse(Console.ReadLine());
                    resul4 = nmr7 - nmr8;
                    Console.WriteLine("o resultado é {0}", resul4);
                    break;
                    case 5:
                    Console.WriteLine("Escreva os números que deseja potenciar, e qual potência quer, respectivamente em linhas separadas");
                    double nmr9, nmr10;
                    double resul5;
                    nmr9 = double.Parse(Console.ReadLine());
                    nmr10 = double.Parse(Console.ReadLine());
                    resul5 = Math.Pow(nmr9, nmr10);
                    Console.WriteLine("o resultado é {0}", resul5);
                    break;
            }
        }
    }
}

