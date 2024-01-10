namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor para inicializar propriedades específicas de Nokia
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            
        }

        // Sobrescrever o método InstalarAplicativo para smartphones Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia {Modelo}");
            // Lógica específica para instalar aplicativo no Nokia
        }
    }
}