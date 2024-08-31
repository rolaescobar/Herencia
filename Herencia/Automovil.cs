using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Automovil : Vehiculo

    {
        public int NumeroDePuertas { get; set; }

        public Automovil(string marca, string modelo,int numeroDePuertas) : base(marca, modelo)
        {
            NumeroDePuertas = numeroDePuertas;

        }

        public void MostrarDetallesCompleto()
        {
            MostrarDetalles();
            Console.WriteLine($"Numero de puertas: {NumeroDePuertas}");
        
        }


    }
}
