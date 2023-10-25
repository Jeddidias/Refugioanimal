using System;

namespace Refugio_animal
{
    class Program
    { /// <summary>
      /// Nombre: Jorge Esteban Dawson 
      /// grupo:140
      /// Ingenieria Multimedia
      /// Problema 10: En resguardo animal se requiere un programa que permita contar el número de perros y gatos así: 
      /// Por teclado se debe solicitar la cantidad de animales a valorar. (ejemplo si digita 5 deberá repetir los pasos siguientes 5 veces)
      /// Se requiere captura por teclado de nombre y tipo de animal(siendo el tipo de animal una opción de 1 para perro y 2 para gato).
      /// Se debe calcular e imprimir el total de perros y gatos registrados.
      /// </summary>
      /// <param name="args"></param>
        static void Main(string[] args)
        {
            int animales, Perros = 0, Gatos = 0;
            Console.WriteLine("¿Cuantos animales desea ingresar");
            animales = int.Parse(Console.ReadLine());
            string[] Nombre = new string[animales];
            int[] Tipo = new int[animales];

            for(int i = 0; i <= animales - 1; i++)
            {
                Console.WriteLine("ingrese el nombre del la mascota");
                Nombre[i] = Console.ReadLine();
                Console.WriteLine("ingrese el tipo de mascota, 1 para perro y 2 para gato");
                Tipo[i] = int.Parse(Console.ReadLine());

            }for(int i = 0; i <= animales - 1; i++)
            {
                if (Tipo[i] == 1)
                {
                    Perros = Perros + 1;
                }
                if (Tipo[i] == 2)
                {
                    Gatos = Gatos + 1;
                }
            }Console.WriteLine("La cantidad de Perros es de :" + Perros);
            Console.WriteLine("La cantidad de Gatos es de :" + Gatos);
        }
    }
}
