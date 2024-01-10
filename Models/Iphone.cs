namespace DesafioPOO.Models
{
     public class Iphone : Smartphone
    {
        // Construtor para inicializar propriedades específicas de iPhone
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
           
        }

        // Sobrescrever o método InstalarAplicativo para iPhones
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone {Modelo}");
            // Lógica específica para instalar aplicativo no iPhone
        }
    }
}