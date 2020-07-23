using System;

namespace Crazy_Roll
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor=0;
            int cantidad = 0;
            Console.WriteLine("---------------------Bienvenido a Crazy Roll---------------------");
            Console.Write("Ingrese el numero de jugadores: ");
            cantidad=Int32.Parse (Console.ReadLine());

            Apuesta j = new Apuesta();
            j.obtener_jugadores(cantidad);
            


            Console.ReadKey();
        }

    }

    class Apuesta
    {
        private int rondas = 1;
        private int valor, total, jugadores;
        String[] nombre;
        int[] apuesta;
        public Apuesta(int valor, int jugadores)
        {
            this.valor = valor;
            this.total = valor * jugadores;
        }
        public void obtener_jugadores(int x)
        {
            nombre = new string[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write("Ingrese el nombre del jugador #{0}:", i);
                nombre[i] = Console.ReadLine();
            }
            Console.WriteLine("Listo");
        }
        public void apostar(int x)
        {
            apuesta = new int[nombre.Length];
            for (int i = 0; i < x; i++)
            {
                Console.Write("Apuesta del jugador {0}:", nombre[i]);
                apuesta[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Listo");
        }
        public void bienvenida()
        {
            Console.WriteLine("Apuesta creada con exito");
            Console.WriteLine("Cantidad de jugadores: {0}", jugadores);
            Console.WriteLine("Valor de la apuesta: {0}", valor);
            Console.WriteLine("Apuesta total: {0}", total);
        }

        public void ronda(String[] players)
        {
            Random num = new Random();
            int auxiliar, d;
            d = valor;
            for (int i = 0; i < 2, i++) {
                Console.WriteLine("Ronda      Jugadores     Valor Maximo    Valor obtenido");
                Console.WriteLine("{0}        {1}           {2}             {3}", rondas, nombre[i], d, d=num.Next(1, d));
                auxiliar = d;s
            }
        }


    }
}
