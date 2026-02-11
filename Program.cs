using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace atv1
{
    public class Pedido
    {
        public double CaulcularFrete(string modalidade, double peso, double distancia)
        {
            switch (modalidade.ToUpper())
            {
                case "PAC":
                    return 10 + (peso * 1.5) + (distancia * 0.01);
                case "SEDEX":
                    return 20 + (peso * 2.0) + (distancia * 0.02);
                case "TRANSPORTADORA":
                    return 15 + (peso * 1.2) + (distancia * 0.0015);

                default:
                    throw new ArgumentException("modalidade invalida");
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();

            double frete = pedido.CaulcularFrete("SEDEX", 5, 300);

            Console.WriteLine($"Valor do frete: R${frete:F2}");
        }
    }
}
