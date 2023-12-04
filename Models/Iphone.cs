namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // TODO: Implementar o construtor e passar os parâmetros para as propriedades
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na loja da Apple...");
        }
    }
}
