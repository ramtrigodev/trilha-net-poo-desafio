namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }

        public string IMEL { get; set; }

        public int Memoria { get; set; }


        public Smartphone(string numero, string modelo, string imel, int memoria)
        {
            Numero = numero;
           Modelo = modelo;
           IMEL = imel;
           Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}