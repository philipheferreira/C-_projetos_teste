using calculadora;

class Programa{

    static void Main(string[] args){

        Operacoes operacoes = new Operacoes();

        int menu;

        do
        {

            Console.WriteLine("Ola, bem vindo a sua calculadora. Escolha o numero para selecionar sua operação");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu){
                case 1:

                    operacoes.soma = operacoes.valor1 + operacoes.valor2;
                    Console.WriteLine("A soma das variaveis {0} e {1} é {2}", operacoes.valor1, operacoes.valor2, operacoes.soma);
                    break;
                case 2:

                    operacoes.sub = operacoes.valor1 - operacoes.valor2;
                    Console.WriteLine("A subtração das variaveis {0} e {1} é {2}", operacoes.valor1, operacoes.valor2, operacoes.sub);
                    break;
                case 3:

                    operacoes.mult = operacoes.valor1 * operacoes.valor2;
                    Console.WriteLine("A multiplicação das variaveis {0} e {1} é {2}", operacoes.valor1, operacoes.valor2, operacoes.mult);
                    break;
                case 4:

                    operacoes.div = operacoes.valor1 / operacoes.valor2;
                    Console.WriteLine("A divisão das variaveis {0} e {1} é {2}", operacoes.valor1, operacoes.valor2, operacoes.div);
                    break;
            }

        } while (menu != 0);


    }

}