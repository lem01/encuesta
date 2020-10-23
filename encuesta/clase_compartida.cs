using encuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encuesta
{
    public  class Clase_compartida
    {
        //public static List<string> lista;
        //public static string lista;
        public static List<Persona> lista = new List<Persona>();
        public static int couter = 0;

        

        //public static List<string> lista
        //{
        //    get { return _lista; }
        //    set { _lista = value; }
        //}
    }


    public class Persona
    {
        public int counter;
        public int _ID;
        public string _ciudad;
        public  int _edad;
        public string _redSocial;
       

        //public Persona(int ID, string ciudad, int edad)
        //{
        //    _ID = ID;
        //    _ciudad = ciudad;
        //    _edad = edad;
        //}

    }


   

}



//clase_compartida.lista.Add();


