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
                try 
                {
                    Console.Clear();
                    Tela.ImprimirPartida(partida);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ConverterPosicao();
                    partida.ValidarSePosicaoExiste(origem);
                    partida.ValidarPosicaoOrigem(origem);
                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                    Console.Clear();

                    Tela.ImprimirTab(partida.Tab, posicoesPossiveis);
                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ConverterPosicao();
                    partida.ValidarSePosicaoExiste(destino);
                    partida.ValidarPosicaoDestino(origem, destino);
                    partida.VerificarPromocao(origem, destino);
                    if(partida.Promocao)
                    {
                        if (partida.Promocao)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 - Rainha");
                            Console.WriteLine("2 - Torre");
                            Console.WriteLine("3 - Bispo");
                            Console.WriteLine("4 - Cavalo");
                            Console.Write("O seu peão será promovido para: ");
                            int promocao = int.Parse(Console.ReadLine());
                            partida.RealizarJogada(origem, destino, promocao);

                        }
                    }
                    else
                    {
                        partida.RealizarJogada(origem, destino);
                    }

                }
                catch(TabuleiroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
                catch(Exception e) {
                    Console.ReadLine();
                }
            }
            Console.Clear();
            Tela.ImprimirPartida(partida);

        }
    }
}