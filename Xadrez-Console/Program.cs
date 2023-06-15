using tabuleiro;
using xadrez;

namespace xadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.ColocarPeca(new Torre (tab, Cor.Branca), new Posicao(0, 2));
            tab.ColocarPeca(new Bispo(tab, Cor.Preta), new Posicao(7, 6));
            Tela.ImprimirTab(tab);

        }
    }
}