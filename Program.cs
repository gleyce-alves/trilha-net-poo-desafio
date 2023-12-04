using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Realizar os testes com as classes Nokia e Iphone.

            // Exemplo de Nokia
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "ABC123", 16);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("JogoNokia");

            // Exemplo de Iphone
            Iphone iphone = new Iphone("987654321", "iPhone X", "XYZ456", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("JogoIphone");

            Console.ReadLine(); // Aguardar a entrada do usuário antes de encerrar o programa
        }
    }
}
