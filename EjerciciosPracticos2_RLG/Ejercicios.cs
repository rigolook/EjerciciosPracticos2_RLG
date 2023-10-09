using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos2_RLG
{
    internal class Ejercicios
    {
        public void TresArrays()
        {
            Console.WriteLine("Escribe el tamaño de los arrays");
            int valores = int.Parse(Console.ReadLine());
            int[] array1 = new int[valores];
            int[] array2 = new int[valores];
            int[] arraySuma = new int[valores];
            int posicion1;
            int posicion2;
            int posicion3;
            for (int i = 0; i < array1.Length; i++)
            {
                posicion1 = i; posicion2 = i;
                Console.WriteLine($"Escriba el valor en la {posicion1} en el primer array");
                array1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Escriba el valor en la {posicion2} en el primer array");
                array2[i] = Convert.ToInt32(Console.ReadLine());
                posicion1++; posicion2++;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                int suma = array1[i] + array2[i];
                arraySuma[i] = suma;
            }
            for (int i = 0; i < arraySuma.Length; i++)
            {
                posicion1 = i; posicion2 = i; posicion3 = i;
                Console.WriteLine($"Valor posicion {posicion1} es {array1[i]} + valor posicion {posicion2} es {array2[i]} = valor posicion {posicion3} es {arraySuma[i]}");
                posicion1++; posicion2++; posicion3++;
            }
        }

        public void ValorPosicion()
        {

            Console.WriteLine("Ingresa el tamaño del arreglo:");
            int posiciones = int.Parse(Console.ReadLine());
            int[] arreglo = new int[posiciones];
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Escriba el elemento en la posicion {i}:");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Escribe el elemento buscado en el arreglo");
            int elemento = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == elemento)
                {
                    Console.WriteLine("La posicion(es) del elemento buscado esta en: " + i);
                }
                else if (arreglo[i] != elemento)
                {
                    Console.WriteLine("Elemento no encontrado o no existe");
                    return;
                }
            }

        }

        public void IDsTresArreglos()
        {
            Console.WriteLine("Escribe cuantos alumnos hay");
            int alumnos = int.Parse(Console.ReadLine());
            int[] algebra = new int[alumnos];
            int[] analisis = new int[alumnos];
            int[] arregloTres = new int[alumnos];
            for (int i = 0; i < algebra.Length; i++)
            {
                Console.WriteLine("Escribe el ID del alumno de algebra");
                algebra[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < analisis.Length; i++)
            {
                Console.WriteLine("Escribe el ID del alumno de analisis");
                analisis[i] = Convert.ToInt32(Console.ReadLine());
            }
            int numeros = 0; int num;
            Console.WriteLine($"Las ID's de alumnos que se repiten son: ");
            for (int i = 0; i < algebra.Length; i++)
            {

                if (algebra[i] == analisis[i])
                {
                    num = algebra[i];
                    Console.WriteLine($"-{num}  ");
                    numeros++;

                }

            }
            Console.WriteLine("El numero de alumnos que se repiten es " + numeros);
        }

        public void MostrarNoRepetidos()
        {
            Console.WriteLine("Escribe el tamaño del arreglo");
            int tamaño = int.Parse(Console.ReadLine());
            int[] arreglo = new int[tamaño];
            Console.WriteLine("Escriba el primer numero");
            arreglo[0] = Convert.ToInt32(Console.ReadLine());
            int contador = 0; int posicion = 0; int separador = 1;
            Console.WriteLine("Escriba un numero que no se repita a los anteriores");
            arreglo[separador] = Convert.ToInt32(Console.ReadLine());
            for (int i=2;i<arreglo.Length;i++)
            {
                Console.WriteLine("Escriba un numero que no se repita a los anteriores");
                if (arreglo[contador] != arreglo[separador])
                {
                    arreglo[i] = Convert.ToInt32(Console.ReadLine());
                    contador++; separador++;
                }
            }
            Console.WriteLine("Los valores del arreglo son:");
            for (int i=0; i<arreglo.Length; i++)
            {
                Console.WriteLine($"Posicion {posicion}: {arreglo[i]}");
            }
        }

        public void NotasPromedio()
        {
            Console.WriteLine("Escriba el numero de notas de un minimo de 0 y un maximo de 20");
            int notas = int.Parse(Console.ReadLine());
            double[] arreglo = new double[notas];
            int contador2 = 0; 
            int contandor1 = 0;
            if (notas>0 && notas<20)
            {
                for(int i=0; i < arreglo.Length; i++)
                {
                    Console.WriteLine("Ingrese la nota");
                    arreglo[i] = Convert.ToDouble(Console.ReadLine());
                }
                double suma1 = 0;
                for(int a=0; a<arreglo.Length; a++)
                {
                    if (arreglo[a] >= 6)
                    {
                        
                        suma1 += arreglo[a];
                        contandor1++;
                    }
                }
                double PromedioAprobado = suma1 / notas;
                double suma2 = 0;
                for(int b=0; b < arreglo.Length; b++)
                {
                    if (arreglo[b] < 6)
                    {
                        
                        suma2 += arreglo[b];
                        contador2++;
                    }
                }
                double PromedioDesaprobado = suma2 / notas;

                Console.WriteLine("El promedio de aprobados es: "+ PromedioAprobado);
                Console.WriteLine("El promedio de desaprobados es: "+ PromedioDesaprobado);
                Console.WriteLine("Cantidad de aprobados "+ contandor1);
                Console.WriteLine("Cantidad de aprobados "+ contador2);
            }
        }
    }
}
