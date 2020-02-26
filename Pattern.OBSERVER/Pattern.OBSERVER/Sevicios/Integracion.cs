using Pattern.OBSERVER.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OBSERVER.Sevicios
{
    public class Integracion : IPublicador
    {
        private IList<IObservador> observdares = new List<IObservador>();
       
        public void Subscribe(IObservador Observador)
        {
            observdares.Add(Observador);
        }

        public void Notifica()
        {
            foreach (IObservador item in observdares)
            {
                item.Actualiza();
            }
        }        
    }
}
