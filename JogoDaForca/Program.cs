namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string palavra = "banana";
            char[] display = new char[palavra.Length];

            int chances = 7;
            bool fimDaPartida = false;

            Console.WriteLine("Bem Vindo ao Jogo da Forca! Você terá {0} chances!\nBoa sorte!", chances);

            for (int i = 0; i < palavra.Length; i++)
            {
                display[i] = '_';
            }

            do
            {
                char letraDigitada;
                bool letraCerta = false;

                displayPalavra(display);

                Console.Write("\nDigite uma letra: ");
                letraDigitada = char.Parse(Console.ReadLine());

                for (int i = 0; i < palavra.Length; i++)
                {
                    if (letraDigitada == palavra[i])
                    {
                        display[i] = palavra[i];
                        letraCerta = true;
                    }
                }

                if (!letraCerta)
                {
                    Console.Clear();
                    chances--;
                    Console.WriteLine("{0} não consta na palavra", letraDigitada);
                    Console.WriteLine("Você tem {0} chances\nAperte qualquer tecla para continuar", chances);
                    Console.ReadKey();

                }

                if (chances == 0)
                {
                    fimDaPartida = true;
                }
                else
                {
                    fimDaPartida = verificadorDeVitoria(display, palavra);
                }

                Console.Clear();

            } while (fimDaPartida == false);

            if (chances != 0)
            {
                Console.WriteLine("Você Venceu");
            }
            else
            {
                Console.WriteLine("Você Perdeu");
            }

            Console.WriteLine("A palavra era: {0}\nObrigado por jogar!\nAperte qualquer tecla para sair...", palavra);

            Console.ReadKey();
        }

        public static void displayPalavra(char[] display)
        {
            for (int i = 0; i < display.Length; i++)
            {
                Console.Write(display[i]);
            }
        }

        public static bool verificadorDeVitoria(char[] display, string palavra)
        {

            string verificadorDePlavra = "";

            for (int i = 0; i < display.Length; i++)
            {
                verificadorDePlavra += display[i];
            }

            return (verificadorDePlavra == palavra) ? true : false;
        }
    }
}