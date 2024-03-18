using System;

class Programa{

    static void Main(String[] args){

        int triangAlt = 20, triangBase = 10 , triangArea;

        int quadLado = 8, quadArea;

        double circArea, circRaio = 4;




        triangArea = triangAlt * triangBase;

        quadArea = quadLado * 4;

        circArea =  circRaio * 3.14;

        Console.WriteLine("A área do triangulo é {0}", triangArea);

        Console.WriteLine("A área do quadrado é {0}", quadArea);

        Console.WriteLine("A área do circulo é {0} ", circArea);

    }

}