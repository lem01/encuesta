using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encuesta
{
    public partial class FormResultado : Form
    {
        public List<Persona> listpersona = new List<Persona>();
        public FormResultado()
        {
            InitializeComponent();
            extraerDatos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.chart1.Series['Redes Sociales'].Points.AddXY()
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                cargarEdad();
            if(comboBox1.SelectedIndex == 1)
                cargarRedes(); ;
           
        }
        private void cargarEdad() 
        {
            int edad1 = 0, edad2 = 0;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var value in listpersona)
            {
                if (value._edad >= 16 && value._edad <= 30)
                    edad1++;
                else if (value._edad >= 31 && value._edad <= 50)
                    edad2++;
            }

            dic.Add("16-30 años", edad1);
            dic.Add("31-50 años", edad2);


            foreach (KeyValuePair<string, int> d in dic)
            {
                this.chart1.Series["Edad"].Points.AddXY(d.Key, d.Value);
            } 

        }
        private void cargarRedes()
        {
            int face = 0, twit = 0, insta = 0, otra =0;
            //string iterador;

            Dictionary<string, int> dic = new Dictionary<string, int>();


           
            foreach(var value in listpersona)
            {

                foreach (var extraeRedes in value._redSocial)
                {
                    if (extraeRedes == "Facebook")
                        face++;
                    if (extraeRedes == "Twitter")
                        twit++;
                    if (extraeRedes == "Instagram")
                        insta++;
                    if (extraeRedes == "Otra")
                        otra++;
                }
                //iterador = value._ciudad;
                //MessageBox.Show(value._redSocial.ToString());
               
            }

            //agregamos listersona en dic
            dic.Add("Facebook", face);
            dic.Add("Twitter", twit);
            dic.Add("Instagram", insta);
            dic.Add("Otra", otra);

            foreach (KeyValuePair<string, int> d in dic)
            {
                this.chart1.Series["Redes Sociales"].Points.AddXY(d.Key, d.Value);
            }
        }

        //este metodo carga los datos de la encuesta en una lista para ser usados en la grafica
        public void extraerDatos()
        {
    

        StreamReader leer = new StreamReader(@"C:\Users\CLIENTE\OneDrive\Documentos\encuesta.txt");

      

            //lee todo el texto del archivo
          string totalText =   leer.ReadToEnd();
            leer.Close();
          
           
          char count = ' ';
            string auxCiudad = "";
             string auxEdad = "", auxID = "";
            string face = "", twit = "", insta = "", otra = "";

            //me ayuda con sabir si coun tiene caracter entero
            int valorNumerico = 0;
            //me cuenta las comas
          int cuentaPuntoComa = 0;


          

            for(int i = 0; i < totalText.Length; i++)
            {
                count = totalText[i];
              
                //valido si hay comas
                
                if (count == ';')
                {
                    cuentaPuntoComa++;
                }
                //guardar el ID
                if (cuentaPuntoComa == 1 && int.TryParse(count.ToString(), out valorNumerico) && count != '\n')
                {
                    //aux += Convert.ToString(count);
                    //auxID += auxID + int.Parse(count.ToString());
                    auxID += count;

                }
                //guardar ciudad
                else if (cuentaPuntoComa == 2 && count != ';' && count != '\n')
                {
                    auxCiudad += count;
                }
                //guardar edad
                else if (cuentaPuntoComa == 3 && int.TryParse(count.ToString(), out valorNumerico))
                {
                    //auxEdad += auxEdad + int.Parse(count.ToString());
                    auxEdad += count;
                }
                //guardar red social
                else if (cuentaPuntoComa == 4 && count != ';' && count != '\n')
                    face += count;
                else if (cuentaPuntoComa == 5 && count != ';' && count != '\n')
                    twit += count;
                else if (cuentaPuntoComa == 6 && count != ';' && count != '\n')
                    insta += count;
                else if (cuentaPuntoComa == 7 && count != ';' && count != '\n')
                    otra += count;

                //aqui guardaremos el dato en el objeto persona en la lista de personas
                if (count == '\n' && auxID != "")
                {
                    Persona persona = new Persona();

                    persona._ID = int.Parse(auxID);
                    persona._ciudad = auxCiudad;
                    persona._edad = int.Parse(auxEdad);

                    
                     //siempre inicializar la lista antes de usarla
                    persona._redSocial = new List<string>();
                    if(face != "")
                    persona._redSocial.Add(face);
                    if (twit != "")
                        persona._redSocial.Add(twit);
                    if (insta != "")
                        persona._redSocial.Add(insta);
                    if (otra != "")
                        persona._redSocial.Add(otra);


                    //cargamos persona dentro de la lista de tipo persona
                    //if(persona._ID == 0)
                    listpersona.Add(persona);

                    //reiniciamos todo 
                    persona = null;
                    cuentaPuntoComa = 0;
                    auxID = "";
                    auxCiudad = "";
                    auxEdad = "";
                    face = "";
                    twit = "";
                    insta = "";
                    otra = "";

                }



            }
            //fin del for

         
        

        }
          

        }

   

}
