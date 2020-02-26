using Pattern.OBSERVER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OBSERVER.Sevicios
{
    public class ObservadorA : IObservador
    {   
        public void Actualiza()
        {
            Console.WriteLine("Commit de código de la versión 1.1");
        }
    }
}
