using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Singleton
{
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        public static Singleton Instance //Creamos el acceso al atributo _instance
        {
            get { return _instance; }
        }
        private Singleton()  //Constructyor private para no se puedan crear objetos de esta clase
        {

        }
    }
}
