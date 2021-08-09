using System;

namespace Taller_Algoritmos_II_Pedro_Lara
{
    class Program
    {
        static void Main(string[] args)
        {
            //Caso de amortización:
            long ValorPrestamo;//valor del préstamo
            double InteresDeuda;//valor del interes mensual
            double NumeroMesesPrestamo;//meses para pagar el préstamo
            double Mensualidad;//mensualidad o renta
            

            Console.WriteLine("Ingrese el valor del prestamo");
            ValorPrestamo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del interes");
            InteresDeuda = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de meses");
            NumeroMesesPrestamo = Convert.ToDouble(Console.ReadLine());

            double InteresMensual = 0;
            double AmortizacionMensual = 0;
            double SaldoRestanteMensual = ValorPrestamo;

            //calcular la mensualidad
            Mensualidad = (ValorPrestamo * InteresDeuda) / (1 - (Math.Pow(1 + InteresDeuda, -NumeroMesesPrestamo)));

            //variables para amortización, intereses mensual, saldo mensual
            Console.WriteLine("El valor de la mensualidad es:" + Mensualidad);
            Console.WriteLine("Meses\t\tMensualidad\t\tInteres\t\tAmortizacion\t\tSaldo");

            
            for (int k = 1; k <= NumeroMesesPrestamo; k++)
            {
                //Calculo Amortizacion, Intereses y el saldo que queda cada mes
                InteresMensual = SaldoRestanteMensual * InteresDeuda;
                AmortizacionMensual = Mensualidad - InteresMensual;
                SaldoRestanteMensual = SaldoRestanteMensual - AmortizacionMensual;
                Console.WriteLine(k + "\t\t" + Mensualidad.ToString("N2") + "\t\t" + InteresMensual.ToString("N2") + "\t\t" + AmortizacionMensual.ToString("N2") + "\t\t" + SaldoRestanteMensual.ToString("N2"));
            }
        }
    }
}