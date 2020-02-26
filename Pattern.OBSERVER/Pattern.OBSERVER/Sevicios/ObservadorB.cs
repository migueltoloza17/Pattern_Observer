using Pattern.OBSERVER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OBSERVER.Sevicios
{
    public class ObservadorB : IObservador
    {
        public void Actualiza()
        {
            Console.WriteLine("Compilación de código correcto");
        }
    }
}
