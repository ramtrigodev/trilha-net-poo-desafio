namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        // Construtor da classe Nokia que chama o construtor da classe base (Smartphone)
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Qualquer inicialização adicional específica para a classe Nokia pode ser adicionada aqui
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Lógica específica para instalar um aplicativo em um Nokia
            Console.WriteLine($"Instalando {nomeApp} na Nokia...");
        }


    }
}