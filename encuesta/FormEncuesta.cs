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
            
            
        }

        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {


            Persona persona = new Persona();
            Clase_compartida.couter += 1;
            persona.counter = Clase_compartida.couter;
            persona._ID = Convert.ToInt32(textBoxID.Text);
            persona._ciudad = textBoxCiudad.Text;
            persona._edad = Convert.ToInt32(textBoxEdad.Text);

            persona._redSocial = new List<string>();
            if (checkBoxFace.Checked == true)
                persona._redSocial.Add("Facebook" +";");
            if (checkBoxTwitter.Checked == true)
                persona._redSocial.Add("Twitter" +";");
            if (checkBoxInstagram.Checked == true)
                persona._redSocial.Add("Instragram" +";");
            if (checkBoxOtro.Checked == true)
                persona._redSocial.Add("Otra" + ";");

            persona._redSocial.Add("\n");
            Clase_compartida.lista.Add(persona);

            this.Close();


        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }
    }
}
