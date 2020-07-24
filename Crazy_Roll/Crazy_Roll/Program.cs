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
            Console.Write("Ingrese el valor de la apuesta: ");
            valor = Int32.Parse(Console.ReadLine());

            Apuesta j = new Apuesta(valor, cantidad);
            j.obtener_jugadores();
            j.bienvenida();
            j.ronda();
            


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
            this.jugadores = jugadores;
        }
        public void obtener_jugadores()
        {
            nombre = new string[jugadores];
            for (int i = 0; i < jugadores; i++)
            {
                Console.Write("Ingrese el nombre del jugador #{0}:", i);
                nombre[i] = Console.ReadLine();
            }
            Console.WriteLine("Listo");
        }
        public void apostar()
        {
            apuesta = new int[nombre.Length];
            for (int i = 0; i < jugadores; i++)
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

        public void ronda()
        {
            Random num = new Random();
            int auxiliar, d;
            d = total;
            int p = jugadores--;
            int conteo=0;
            int i = 0;
            do
            {
                if (nombre[i] == null) { }
                else
                {
                    Console.WriteLine("Ronda      Jugadores     Valor Maximo    Valor obtenido");
                    Console.WriteLine("{0}            {1}               {2}                {3}", rondas, nombre[i], d, d = num.Next(1, d));
                    auxiliar = d;
                    Console.WriteLine("i = {0}", i);
                }
                if (i < jugadores) { i++; }
                    else { i = 0; }
                    if (d == 1)
                    {
                        rondas++;
                        d = total;
                        nombre[i] = null;
                        conteo++;
                    }
            }
            while (conteo < jugadores);

            Console.WriteLine("El ganador es:....",);
        }


    }
}
