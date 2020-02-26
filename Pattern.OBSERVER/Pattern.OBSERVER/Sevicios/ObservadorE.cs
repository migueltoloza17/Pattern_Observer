using Pattern.OBSERVER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OBSERVER.Sevicios
{
    public class ObservadorE : IObservador
    {
        public void Actualiza()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}
