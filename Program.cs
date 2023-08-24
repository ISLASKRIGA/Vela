using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vela
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int valorDeVela = random.Next(100, 801); // Generar valor aleatorio entre 100 y 800
            Console.WriteLine(valorDeVela);

            if (valorDeVela >= 400)
            {
                Console.WriteLine("La vela está encendida.");
            }
            else
            {
                Console.WriteLine("La vela está apagada.");
            }
            Console.ReadLine();

        }
    }
}
