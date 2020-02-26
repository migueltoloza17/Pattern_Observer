using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OBSERVER.Interfaces
{
    public interface IPublicador
    {        
        void Subscribe(IObservador Observador);
        void Notifica();

    }
}
