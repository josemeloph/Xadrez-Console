using tabuleiro;
namespace xadrez
{
    internal class PartidaXadrez
    {
        public Tabuleiro Tab {get; private set;}
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set;}

        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            ColocarPecas();
            Terminada = false;
        }

        public void MoverPeca(Posicao origem, Posicao destino)
        {
            Peca pecaMovida = Tab.RetirarPeca(origem);
            pecaMovida.IncrementarQteMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(pecaMovida, destino);
        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('a', 1).ConverterPosicao());
            Tab.ColocarPeca(new Cavalo(Tab, Cor.Branca), new PosicaoXadrez('b', 1).ConverterPosicao());
            Tab.ColocarPeca(new Bispo(Tab, Cor.Branca), new PosicaoXadrez('c', 1).ConverterPosicao());
            Tab.ColocarPeca(new Rainha(Tab, Cor.Branca), new PosicaoXadrez('d', 1).ConverterPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('e', 1).ConverterPosicao());
            Tab.ColocarPeca(new Bispo(Tab, Cor.Branca), new PosicaoXadrez('f', 1).ConverterPosicao());
            Tab.ColocarPeca(new Cavalo(Tab, Cor.Branca), new PosicaoXadrez('g', 1).ConverterPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('h', 1).ConverterPosicao());

            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('a', 8).ConverterPosicao());
            Tab.ColocarPeca(new Cavalo(Tab, Cor.Preta), new PosicaoXadrez('b', 8).ConverterPosicao());
            Tab.ColocarPeca(new Bispo(Tab, Cor.Preta), new PosicaoXadrez('c', 8).ConverterPosicao());
            Tab.ColocarPeca(new Rainha(Tab, Cor.Preta), new PosicaoXadrez('d', 8).ConverterPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('e', 8).ConverterPosicao());
            Tab.ColocarPeca(new Bispo(Tab, Cor.Preta), new PosicaoXadrez('f', 8).ConverterPosicao());
            Tab.ColocarPeca(new Cavalo(Tab, Cor.Preta), new PosicaoXadrez('g', 8).ConverterPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('h', 8).ConverterPosicao());

        }
    }
}
