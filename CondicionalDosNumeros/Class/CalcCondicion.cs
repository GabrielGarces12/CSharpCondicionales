
using System.ComponentModel.Design;

namespace CondicionalesPractica.Class
{
    public class CalcCondicion
    {
        public void CondicionalesPractica() 
        {
            decimal Numero1 = 0;
            decimal Numero2 = 0;
            decimal suma = 0;
            decimal diferencia = 0;
            decimal division = 0;
            decimal Producto = 0;

            try
            {
                Console.WriteLine("Digite el primer numero: ");
                Numero1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite el segundo numero: ");
                Numero2 = decimal.Parse(Console.ReadLine());

                if (Numero1 > Numero2)
                {
                    
                    
                    suma = (Numero1 + Numero2);
                    Console.WriteLine($"La suma de los dos numeros es: { suma } ");

                    diferencia = (Numero1 - Numero2);
                    Console.WriteLine($"La diferencia de el primer numero menos el segundo numero es: { diferencia }");
                }
                else 
                {
                  
                  
                    Producto = (Numero1 * Numero2);
                    Console.WriteLine($"El producto de los numeros es: {Producto} ");

                    division = (Numero1 / Numero2);
                    Console.WriteLine($"La division de el primer numero entre el segundo numero es: { division }");

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrio el siguiente error: { ex.Message }");
            }
        } 

        public void PromedioNota() 
        {
            decimal nota1 = 0 ;
            decimal nota2 = 0;
            decimal nota3 = 0;
            decimal promedio = 0;

            try
            {
                Console.WriteLine("Ingrese la primera nota: ");
                nota1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la segunda nota: ");
                nota2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la tercera nota: ");
                nota3 = decimal.Parse(Console.ReadLine());

                promedio = (nota1 + nota2 + nota3) / 3;

                if (promedio >= 7)
                {
                    Console.WriteLine($"Promocionado!! Tu promedio es: {promedio} ");
                }
                else if (promedio >= 4 && promedio < 7)
                {
                    Console.WriteLine($"Regular. Tu promedio es: {promedio} ");
                }
                else 
                {
                    Console.WriteLine($"Reprobado. Tu promedio es: { promedio } ");
                }
                    
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrio el siguiente error: { ex.Message } ");
            }

        }
    }
}
