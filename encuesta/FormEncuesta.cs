using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encuesta
{
    public partial class FormEncuesta : Form
    {
        public FormEncuesta()
        {
            InitializeComponent();
            //labelnombre.Text = checkBox1.Text;
            
        }

        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            //else if ((e.KeyChar) == 8)
            //    e.Handled = false;

            //int numero = e.KeyChar;
            //labelchange.Text = numero.ToString();



        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //clase_compartida.counter++;
            //clase_compartida.lista.Add(clase_compartida.counter.ToString());
            ////clase_compartida.lista.Add(";");
            //clase_compartida.lista.Add(textBoxID.Text);
            ////clase_compartida.lista.Add(";");
            //clase_compartida.lista.Add(textBoxID.Text);
            ////clase_compartida.lista.Add(";");
            //clase_compartida.lista.Add(textBoxEdad.Text);
            ////clase_compartida.lista.Add(";");
            //if (radioButtonF.Checked == true)
            //    clase_compartida.lista.Add("femenino ");
            //else
            //    clase_compartida.lista.Add("masculino ");
            //clase_compartida.lista.Add(";");

            //Persona persona = new Persona(Convert.ToInt32(textBoxID.Text),textBoxCiudad.Text, Convert.ToInt32(textBoxEdad.Text));

            //Clase_compartida.lista.Add(persona); 

            Persona persona = new Persona();
            Clase_compartida.couter += 1;
            persona.counter = Clase_compartida.couter;
            persona._ID = Convert.ToInt32(textBoxID.Text);
            persona._ciudad = textBoxCiudad.Text;
            persona._edad = Convert.ToInt32(textBoxEdad.Text);
            

            if (checkBoxFace.Checked == true)
                persona._redSocial += "Facebook ";
            else if (checkBoxTwitter.Checked == true)
                persona._redSocial += "Twitter";
            else if (checkBoxInstagram.Checked == true)
                persona._redSocial += "Instragram";
            else if (checkBoxOtro.Checked == true)
                persona._redSocial += "Otro";
            

            Clase_compartida.lista.Add(persona);

            this.Close();


        }
    }
}
