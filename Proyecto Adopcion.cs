using System;    
class Program
    {
        static void Main(string[] args)
        {
            int animal = 0;
            string nombre;
            string apellidoP;
            string apellidoM;
            string telefono;
            string direccion;

            do
            {
                Console.WriteLine("Centro de Adopción");
                Console.WriteLine("Elige el número de acuerdo al compañero que buscas?");
                Console.WriteLine("Perro        ->  1");
                Console.WriteLine("Gato         ->  2");
                Console.WriteLine("Conejo       ->  3");
                Console.WriteLine("Hamster      ->  4");
                Console.WriteLine("Hurón        ->  5");
                Console.WriteLine("Ave          ->  6");
                Console.WriteLine("Pez          ->  7");
                animal = Convert.ToInt32(Console.ReadLine());
            }
            
            while ((animal < 1) || (animal > 7));
            string nombreanimal = null;
            switch (animal)
            {
                case 1:
                    {
                        nombreanimal = "Perro";
                        break;
                    }
                case 2:
                    {
                        nombreanimal = "Gato";
                        break;
                    }
                case 3:
                    {
                        nombreanimal = "Conejo";
                        break;
                    }
                case 4:
                    {
                        nombreanimal = "Hamster";
                        break;
                    }
                case 5:
                    {
                        nombreanimal = "Hurón";
                        break;
                    }
                case 6:
                    {
                        nombreanimal = "Ave";
                        break;
                    }
                case 7:
                    {
                        nombreanimal = "Pez";
                        break;
                    }
            }
            
            Console.WriteLine("Necesitamos tu registro");
            Console.WriteLine("Escribe tu nombre, por favor");
            nombre = Console.ReadLine();

            Console.WriteLine("Aquí tu apellido paterno");
            apellidoP = Console.ReadLine();

            Console.WriteLine("Aquí tu apellido materno");
            apellidoM = Console.ReadLine();

            Console.WriteLine("Necesitamos tu teléfono");
            telefono = Console.ReadLine();

            Console.WriteLine("Por último, tu dirección");
            direccion = Console.ReadLine();

            Console.WriteLine("Gracias por adquirir a tu nuevo compañero {0}", nombre); 
            Console.WriteLine("Tu nuevo compañero es un {0} ", nombreanimal);
            Console.ReadLine();
        }
}
