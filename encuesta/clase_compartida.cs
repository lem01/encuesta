using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encuesta
{
    public class clase_compartida
    {
        //public static List<string> lista;
        //public static string lista;
        public static List<persona> lista = new List<persona>();

        

        //public static List<string> lista
        //{
        //    get { return _lista; }
        //    set { _lista = value; }
        //}
    }

    public class persona
    {
       private int _ID;
       private string _ciudad;
      private  int _edad;

        public persona(int ID, string ciudad, int edad)
        {
            _ID = ID;
            _ciudad = ciudad;
            _edad = edad;
        }

    }

}


