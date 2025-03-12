

namespace Adivinhação.ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Jogo da Adivinhação");

                Console.WriteLine("Escolha um Nivel de dificuldade!");

                Console.WriteLine("[1] - Facil - 10 Tentativas");
                Console.WriteLine("[2] - Medio - 5 Tentativas");
                Console.WriteLine("[3] - Dificil - 3 Tentativas");

                int totaltentativas = 5;

                Console.WriteLine("Digite sua Escolha de dificuldade");
                string opcaodificuldade = Console.ReadLine();

                if(opcaodificuldade == "1")
                {
                    totaltentativas = 10;
                } 
                
                if(opcaodificuldade == "2")
                {
                    totaltentativas = 5;
                }

               if (opcaodificuldade == "3")
                {
                    totaltentativas = 3;
                }

                

                        

                
                Random geradorNumeros = new Random();


                int numeroSecreto = geradorNumeros.Next(1, 20);

                

                for (int tentativa = 1; tentativa <= totaltentativas; tentativa++)
                {




                    
                        Console.WriteLine($"Tentativa: {tentativa} de {totaltentativas}");

                        Console.WriteLine("Digite um Numero");
                    
                        int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    
                    

                        Console.WriteLine("Voce digitou o numero: " + numeroDigitado);
                    


                    if (tentativa == totaltentativas)
                    {
                        Console.WriteLine("Voce não conseguiu acertar o numero");
                        
                    }

                    else if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("Parabens, voce acertou o numero secreto");
                        Console.Write("Pressione ENTER para sair");
                        Console.ReadLine();

                        break;
                    }
                    

                    else if (numeroDigitado > numeroSecreto)

                    {
                        Console.WriteLine("O numero digitado é maior que o numero secreto");
                    }

                    else if (numeroDigitado < numeroSecreto)

                    {
                        Console.WriteLine("O numero digitado é menor que o numero secreto");
                    }

                    

                }

                Console.WriteLine("Deseja Continuar? (S/N)");
                String opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar == "N")
                    {
                        break;
                    }

                

            }
        }
    }
}
