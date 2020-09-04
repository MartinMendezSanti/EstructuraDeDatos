using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructuraClase2
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Tarea 2: Crea un programa que diga el resultado de sumar 200 y 56.

            //Console.WriteLine(200 + 56);

            //Tarea 3: Haz un programa que calcule el producto de los números 13 y 12.

            //Console.WriteLine(13 * 12);

            //Tarea 4: Un programa que calcule la diferencia (resta) entre 321 y 213

            //Console.WriteLine(321 - 213);

            //Tarea 5: Calcular el resultado de (20+5) % 6

            /* float calculo;

            calculo = ((20 + 5) / 6);

            Console.WriteLine(calculo);
            */

            //Tarea 6: Crea un programa que calcule el producto de los números 12 y 102, usando variables.

            /*int PrimerNumero, SegundoNumero, calculo;

            PrimerNumero = 12;
            SegundoNumero = 102;
            calculo = (PrimerNumero * SegundoNumero);
            Console.WriteLine(calculo);
            */

            // Tarea 7: Crea un programa que calcule la suma de 200 y 1111, usando variables.
            /*
            int PrimerNumero, SegundoNumero, calculo;

            PrimerNumero = 200;
            SegundoNumero = 1111;
            calculo = (PrimerNumero + SegundoNumero);
            Console.WriteLine(calculo);
            Console.ReadLine();
            */

            //Tarea 8: Crea un programa que calcule el producto de los números 10 y 25, usando variables llamadas "numero1" y "numero2".
            /*
            int numero1, numero2;

            numero1 = 10;
            numero2 = 25;
            Console.WriteLine(numero1 * numero2);
            Console.ReadLine();
            */

            //Tarea 9: Crea un programa que calcule el producto de dos números introducidos por el usuario.
            /*
            int numero1, numero2, calculo;

            Console.WriteLine("Ingrese un primer número:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());
            calculo = (numero1 * numero2);
            Console.WriteLine("El producto entre {0} y {1} es igual a {2}", numero1, numero2, calculo);
            Console.ReadLine();
            */

            //Tarea 10: Crea un programa que pida al usuario un número entero y diga si es par
            /*
            int numero;

            Console.WriteLine("Ingrese un número:");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine("El número es par");
            else
                Console.WriteLine("El número es impar");
            Console.ReadLine();
            */

            //Tarea 11: Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.
            /*
            int numero1, numero2;
            Console.WriteLine("Ingrese un primer número:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2)
                Console.WriteLine("El numero {0} es el mayor", numero1);
            else
                if (numero1 < numero2)
                    Console.WriteLine("El numero {0} es el mayor", numero2);
                else
                    Console.WriteLine("Ambos números son iguales");
            Console.ReadLine();
            */

            //Tarea 12: Crea un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".
            /*
            int primernumero, segundonumero;

            Console.WriteLine("Ingrese un primer número:");
            primernumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número:");
            segundonumero = Convert.ToInt32(Console.ReadLine());

            if (segundonumero != 0)
                Console.WriteLine(primernumero/segundonumero);
            else
                Console.WriteLine("Error: No se puede dividir entre cero");
            Console.ReadLine();
            */

            //Tarea 13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el programa escribirá "uno").
        }
    }
}
