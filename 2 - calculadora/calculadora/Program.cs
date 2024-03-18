

class Programa{

    static void Main(string[] args){

        int soma, sub, mult, div;

        int valor1 = 20, valor2 = 10;

        soma = valor1 + valor2;
        sub = valor1 - valor2;
        mult = valor1 * valor2;
        div = valor1 / valor2;

        Console.WriteLine("A soma das variaveis {0} e {1} é {2}", valor1, valor2, soma);
        Console.WriteLine("A subtração das variaveis {0} e {1} é {2}", valor1, valor2, sub);
        Console.WriteLine("A multiplicação das variaveis {0} e {1} é {2}", valor1, valor2, mult);
        Console.WriteLine("A divisão das variaveis {0} e {1} é {2}", valor1, valor2, div);

    }

}