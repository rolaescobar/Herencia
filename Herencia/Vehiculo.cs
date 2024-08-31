using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Vehiculo
    {

        public string? Marca { get; set; }
        public string? Modelo { get; set;}

        public Vehiculo(string marca,string modelo) 
        { 
        
            Marca = marca;
            Modelo = modelo;
        
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}. Modelo: {Modelo}");

         

        }


    }
}
