using tabuleiro;
using xadrez;

namespace xadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartidaXadrez partida = new PartidaXadrez();
            while(!partida.Terminada)
            {
                Console.Clear();
                Tela.ImprimirTab(partida.Tab);

                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ConverterPosicao();
                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ConverterPosicao();

                partida.MoverPeca(origem, destino);
            }


        }
    }
}