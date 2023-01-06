using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Singleton
{
    public class Cuaderno
    {
        private readonly static Cuaderno _instance = new Cuaderno();
        private string path = "cuaderno.txt";

        public static Cuaderno Instance
        {
            get
            {
                return _instance;
            }
        }
        private Cuaderno()
        {

        }
        public void guardarNota(string nota)
        {
            File.AppendAllText(path, nota + Environment.NewLine);

        }
    }
}
