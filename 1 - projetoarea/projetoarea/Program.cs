using System;
using projetoarea;
class Programa{

    static void Main(String[] args){

        Calculos calculos = new Calculos();

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

                    calculos.quadArea = calculos.quadLado * 4;

                    Console.WriteLine("A área do quadrado é {0}", calculos.quadArea);

                    break;
                case 2:

                    calculos.retArea = calculos.retLadoAlt * calculos.retLadoBase;

                    Console.WriteLine("A area da altura e base do retangulo é {0}", calculos.retArea);

                    break;
                case 3:

                    calculos.triangArea = calculos.triangAlt * calculos.triangBase;

                    Console.WriteLine("A área do triangulo é {0}", calculos.triangArea);

                    break;

                case 4:

                    calculos.circArea = calculos.circRaio * 3.14;

                    Console.WriteLine("A área do circulo é {0} ", calculos.circArea);

                    break;

            }

        } while (menu != 0);



    }

}