using Pattern.OBSERVER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OBSERVER.Sevicios
{
    public class ObservadorC : IObservador
    {   
        public void Actualiza()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}
