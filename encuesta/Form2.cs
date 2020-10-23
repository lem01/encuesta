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
    public partial class FormResultado : Form
    {
        public FormResultado()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.chart1.Series['Redes Sociales'].Points.AddXY()
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
                cargarRedes();
            else cargarEdad();
           
        }

        private void cargarRedes()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Facebook", 1);
            dic.Add("Twitter", 50);
            dic.Add("Instagram", 3);
            dic.Add("Orta", 10);
           
            foreach (KeyValuePair<string, int> d in dic)
            {
                this.chart1.Series["Redes Sociales"].Points.AddXY(d.Key, d.Value);
            }
        }

        private void cargarEdad() { }
    }
}
