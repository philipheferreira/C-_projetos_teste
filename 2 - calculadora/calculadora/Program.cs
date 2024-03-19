

class Programa{

    static void Main(string[] args){

        int soma, sub, mult, div;

        int valor1 = 20, valor2 = 10;

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

                    soma = valor1 + valor2;
                    Console.WriteLine("A soma das variaveis {0} e {1} é {2}", valor1, valor2, soma);
                    break;
                case 2:

                    sub = valor1 - valor2;
                    Console.WriteLine("A subtração das variaveis {0} e {1} é {2}", valor1, valor2, sub);
                    break;
                case 3:

                    mult = valor1 * valor2;
                    Console.WriteLine("A multiplicação das variaveis {0} e {1} é {2}", valor1, valor2, mult);
                    break;
                case 4:

                    div = valor1 / valor2;
                    Console.WriteLine("A divisão das variaveis {0} e {1} é {2}", valor1, valor2, div);
                    break;
            }

        } while (menu != 0);


    }

}