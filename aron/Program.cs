using System;

namespace preubas_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int pre_i, cant, des, pre_fin, pre_ca, nom;
            string nom_pr, linea;
            // Console.WriteLine("dijite el nombre del producto");
            // nom_pr = Console.ReadLine();

            Console.WriteLine("dijite el nombre ");
            linea = Console.ReadLine();

            Console.WriteLine("dijitela cantidad de productos");
            linea = Console.ReadLine();
            cant = int.Parse(linea);

            Console.WriteLine("dijite el precio del producto");
            linea = Console.ReadLine();
            pre_i = int.Parse(linea);
            pre_ca = (cant * pre_i);
            Console.WriteLine("tu producto es");
            Console.WriteLine(nom_pr);
            Console.WriteLine(cant);
            Console.WriteLine(pre_i);
            Console.WriteLine(pre_ca);







        }
    }
}