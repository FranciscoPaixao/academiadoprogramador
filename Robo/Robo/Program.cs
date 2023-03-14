using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho da matriz");
            String tamanho = Console.ReadLine();
            int y = Convert.ToInt32(Convert.ToString(tamanho[0]));
            int x = Convert.ToInt32(Convert.ToString(tamanho[2]));

            Console.WriteLine("Informe a posição inicial do robo 1");
            String robo1 = Console.ReadLine();
            int robo1x = Convert.ToInt32(Convert.ToString(robo1[0]));
            int robo1y = Convert.ToInt32(Convert.ToString(robo1[2]));
            String robo1d = robo1[4].ToString();
            Console.WriteLine("Informe o comando a ser executado pelo robo 1");
            String comandoR1 = Console.ReadLine();

            Console.WriteLine("Informe a posição inicial do robo 2");
            String robo2 = Console.ReadLine();
            int robo2x = Convert.ToInt32(robo1[0]);
            int robo2y = Convert.ToInt32(robo1[2]);
            String robo2d = robo2[4].ToString();
            Console.WriteLine("Informe o comando a ser executado pelo robo 2");
            String comandoR2 = Console.ReadLine(); 

            Direcionamento(robo1x, robo1y, comandoR1, robo1d);
            Direcionamento(robo2x, robo2y, comandoR2, robo2d);

            while (true) ;
        }
        private static void Direcionamento(int x, int y, String comando, String direcao)
        {
            for (int i = 0; i < comando.Length; i++)
            {
                if ('E' == comando[i])
                {
                    switch (direcao)
                    {
                        case "N": direcao = "O"; break;
                        case "O": direcao = "S"; break;
                        case "S": direcao = "L"; break;
                        case "L": direcao = "N"; break;
                    }
                }
                if ('D' == comando[i])
                {
                    switch (direcao)
                    {
                        case "N": direcao = "L"; break;
                        case "L": direcao = "S"; break;
                        case "S": direcao = "O"; break;
                        case "O": direcao = "N"; break;
                    }
                }
                if ('M' == comando[i])
                {
                    switch (direcao)
                    {
                        case "N": y++; break;
                        case "L": x++; break;
                        case "S": y--; break;
                        case "O": x--; break;
                    }
                }

            }
            Console.WriteLine($"{x} {y} {direcao}");
        }
    }
}
