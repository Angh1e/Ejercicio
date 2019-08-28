using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Proyector
    {
        #region Propiedades
        public string marca { get; set; }
        public string modelo { get; set; }
        public double peso { get; set; }
        public int valor { get; set; }

        #endregion

        #region Constructor
        public Proyector()
        {

        }

        public Proyector(string mar,string mod)
        {
            marca = mar;
            modelo = mod;
        }

        public Proyector(double pes, int val)
        {
            peso = pes;
            valor = val;
        }
        #endregion
        #region Metodos
        public void IngresarProyector()
        {
            Console.WriteLine("Ingresar la marca del proyector");
            marca = Console.ReadLine();
            Console.WriteLine("Ingresar el modelo del proyector");
            modelo = Console.ReadLine();
            Console.WriteLine("Ingresar el peso del proyector");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el valor del proyector");
            valor = int.Parse(Console.ReadLine());

        }
        public void ImprimirProyector()
        {
            Console.WriteLine($"Marca:  {marca}");
            Console.WriteLine($"Modelo:  {modelo}");
            Console.WriteLine($"Peso:  {peso}");
            Console.WriteLine($"Valor:  {valor}");
        }
        public void ModificarMarca(string ma)
        {
            marca = ma;
        }
        #endregion
    }
}
