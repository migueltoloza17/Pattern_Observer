using Pattern.OBSERVER.Interfaces;
using Pattern.OBSERVER.Sevicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OBSERVER
{
    class Program
    {
        public static void Main(string[] args)
        {
            int iTipoTarea = (int)decimal.Zero;
            IPublicador svrIPublicador = new Integracion();
            IObservador _IObservador;
            GeneraCadenaTareasEjecutar();
            Console.WriteLine("Seleccione una tarea a ejecutar");
            iTipoTarea = Convert.ToInt32(Console.ReadLine());

            while (iTipoTarea != 0)

            {
                _IObservador = new ObservadorA();
                switch (iTipoTarea)
                {
                    case 1:
                        _IObservador = new ObservadorA();
                        break;
                    case 2:
                        _IObservador = new ObservadorB();
                        break;
                    case 3:
                        _IObservador = new ObservadorC();
                        break;
                    case 4:
                        _IObservador = new ObservadorD();
                        break;
                    case 5:
                        _IObservador = new ObservadorE();
                        break;
                }

                svrIPublicador.Subscribe(_IObservador);
                if (iTipoTarea == 1)
                    svrIPublicador.Notifica();
                Console.WriteLine("Seleccione una tarea a ejecutar");
                iTipoTarea = Convert.ToInt32(Console.ReadLine());
            }             

            Console.ReadKey();
        }


        public static void GeneraCadenaTareasEjecutar()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("* Tareas a Ejecutar                                *");
            Console.WriteLine("*    1 => Subir código                             *");
            Console.WriteLine("*    2 => Compilar                                 *");
            Console.WriteLine("*    3 => Ejecución de pruebas unitaria            *");
            Console.WriteLine("*    4 => Instalar versión                         *");
            Console.WriteLine("*    5 => Correo de notificación                   *");
            Console.WriteLine("****************************************************");
        }     
    }
}
