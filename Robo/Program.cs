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

            int robo1x, robo1y, robo2x, robo2y;
            string robo1d, comandoR1, robo2d, comandoR2;

            InputRobo(out robo1x, out robo1y, out robo1d, out comandoR1, 1);
            InputRobo(out robo2x, out robo2y, out robo2d, out comandoR2, 2);

            Direcionamento(robo1x, robo1y, comandoR1, robo1d);
            Direcionamento(robo2x, robo2y, comandoR2, robo2d);

            while (true) ;
        }

        private static void InputRobo(out int roboX, out int roboY, out string roboD, out string comando, int roboNumero)
        {
            Console.WriteLine($"Informe a posição inicial do robo {roboNumero}");
            String robo = Console.ReadLine();
            roboX = Convert.ToInt32(Convert.ToString(robo[0]));
            roboY = Convert.ToInt32(Convert.ToString(robo[2]));
            roboD = robo[4].ToString();
            Console.WriteLine($"Informe o comando a ser executado pelo robo {roboNumero}");
            comando = Console.ReadLine();
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
