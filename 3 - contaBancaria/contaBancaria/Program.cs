using contaBancaria;

class Programa{

    static void Main(string[] args){

        Operacoes operacoes = new Operacoes();

        Console.WriteLine("Nome: {0}", operacoes.nomeConta);
        Console.WriteLine("Saldo: {0}", operacoes.saldoConta);
    }

}