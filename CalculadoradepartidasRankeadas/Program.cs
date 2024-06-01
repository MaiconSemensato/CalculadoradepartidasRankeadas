using System;
namespace CalculadoradepartidasRankeadas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int vitorias = 0;
            int derrotas = 0;
            int saldoRankeadas = 0;
            string nivel = "";
            bool sair = true;
            int op = 1;

            while (sair)
            {
                Console.WriteLine("digite as vitorias:");
                vitorias = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("digite as derrotas:");
                derrotas = Convert.ToInt32(Console.ReadLine());

                saldoRankeadas = VitoriaDerrota(vitorias, derrotas);

                if (saldoRankeadas < 10)
                {
                    nivel = "Ferro";
                } else if (saldoRankeadas >= 11 && saldoRankeadas <= 20)
                {
                    nivel = "Bronze";
                } else if (saldoRankeadas >= 21 && saldoRankeadas <= 50)
                {
                    nivel = "Prata";
                } else if (saldoRankeadas >= 51 && saldoRankeadas <= 80)
                {
                    nivel = "Ouro";
                } else if (saldoRankeadas >= 81 && saldoRankeadas <= 90)
                {
                    nivel = "Diamante";
                } else if (saldoRankeadas >= 91 && saldoRankeadas <= 100)
                {
                    nivel = "Lendário";
                } else if (saldoRankeadas >= 101)
                {
                    nivel = "Imortal";
                }

                Console.WriteLine("O Herói tem de saldo de {0} está no nível de {1}", saldoRankeadas, nivel);

                Console.WriteLine("Deseja continuar? '0' para nao e '1' para sim");
                op = Convert.ToInt32(Console.ReadLine());

                switch(op) {
                    case 0:
                        sair = false;
                        break;
                    case 1:
                        sair = true; 
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }

            
        }

        static int VitoriaDerrota(int vitoria, int derrota)
        {
            return vitoria - derrota;

        }
    }
}

