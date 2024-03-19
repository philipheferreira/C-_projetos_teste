using System;

class Programa{

    static void Main(String[] args){

        int triangAlt = 20, triangBase = 10 , triangArea, quadLado = 8, quadArea, retLadoAlt = 5, retLadoBase = 10, retArea;

        double circArea, circRaio = 4;

        int menu;

        do {

            Console.WriteLine("***Bem vindo ao menu de formas geometricas, digite qual area você quer calcular");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Retangulo");
            Console.WriteLine("3 - Triangulo");
            Console.WriteLine("4 - Circulo");
            Console.WriteLine("0 - Sair");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu){

                case 1:

                    quadArea = quadLado * 4;

                    Console.WriteLine("A área do quadrado é {0}", quadArea);

                    break;
                case 2:

                    retArea = retLadoAlt * retLadoBase;

                    Console.WriteLine("A area da altura e base do retangulo é {0}", retArea);

                    break;
                case 3:

                    triangArea = triangAlt * triangBase;

                    Console.WriteLine("A área do triangulo é {0}", triangArea);

                    break;

                case 4:

                    circArea = circRaio * 3.14;

                    Console.WriteLine("A área do circulo é {0} ", circArea);

                    break;

            }

        } while (menu != 0);



    }

}