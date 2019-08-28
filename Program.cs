using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Proyector pro = new Proyector();
            pro.marca = "S39";
            pro.modelo = "Epson";
            pro.peso = 2.7;
            pro.valor = 1379900;
            Console.WriteLine(pro.marca);
            Console.WriteLine(pro.modelo);
            Console.WriteLine(pro.peso);
            Console.WriteLine(pro.valor);
            Console.ReadLine();
            Proyector pro1 = new Proyector("Cinemac", "Mini YG-320");
            
            Console.WriteLine(pro1.marca);
            Console.WriteLine(pro1.modelo);
          
            Console.ReadLine();
            Proyector pro2 = new Proyector(3.5,1200200);
            Console.WriteLine(pro2.peso);
            Console.WriteLine(pro2.valor);
            Console.ReadLine();



            Console.WriteLine($"La marca es: {pro.marca} ");
            Console.WriteLine($"El modelo es: {pro.modelo} ");
            Console.WriteLine($"El peso es: {pro.peso} ");
            Console.WriteLine($"El valor es: {pro.valor} \n");

            Console.WriteLine($"La marca es: {pro1.marca}");
            Console.WriteLine($"El modelo es: {pro1.modelo} \n");

            Console.WriteLine($"El peso es: {pro2.peso} ");
            Console.WriteLine($"El valor es: {pro2.valor} \n");

            pro.IngresarProyector();
            pro.ImprimirProyector();
            pro.ModificarMarca("Brightside");
            pro.ImprimirProyector();

        }
    }
}
