namespace SimulacroExamen
{
    public class Ejercicio1
    {
        public void CalculoPrecioPesos(){
            var cotizacionDolar = Decimal.Parse(System.Console.ReadLine($"Cotización Dólar: U$S"));
            var cantidadDolares = int.Parse(System.Console.ReadLine($"Cantidad Dólares a comprar: U$S"));

            System.Console.WriteLine($"Pesos a Pagar: ${cotizacionDolar * cantidadDolares * 1.05}");
        }
    }
}