using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encuesta
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialog1.Filter = "ficheros txt (*.txt)|*.txt";
            //crear_txt();


        }

        //private void crear_txt()
        //{
        //    //string ruta = @"C:\encuesta.txt";
        //    string ruta = @"C:\Users\CLIENTE\Desktop";


        //    if (!File.Exists(ruta))
        //    {
        //        //StreamReader file = new StreamReader(ruta);
        //        StreamWriter file = new StreamWriter(ruta, true);
        //        file.WriteLine("cantidad");

        //    }
            

        //        //StreamWriter mylogs = File.AppendText(ruta);
              

        //}

        private void encuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            FormEncuesta formEncuesta = new FormEncuesta();
            formEncuesta.MdiParent = this;
            //formEncuesta.WindowState.Maximize

            formEncuesta.Show();
        }

        private void guardarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stream file;
            //SaveFileDialog dlGuardar = new SaveFileDialog();
            //dlGuardar.Title = "Guardar Encuestas";
            ////dlGuardar.InitialDirectory("c:\\");
            ////dlGuardar.Filter = "(*.txt)";
            //dlGuardar.Filter = "ficheros txt (*.txt)|*.txt";
            //dlGuardar.FilterIndex = 0;
            //dlGuardar.RestoreDirectory = true;

            //string texto = dlGuardar.FileName;
            //if (dlGuardar.ShowDialog() == DialogResult.OK)
            //{
            //    file = dlGuardar.OpenFile();
            //    if (file != null)
            //    {
            //        //escribi el codigo aqui

            //        //file.BeginWrite(buffer: 1024,);

            //        StreamWriter textoguardar = File.CreateText(texto);
            //        textoguardar.Write(clase_compartida.lista);
            //        textoguardar.Flush();
            //        textoguardar.Close();


            //    file.Close();
            //    }
            //    else
            //    {
            //        StreamWriter textoguardar = File.CreateText(texto);
            //        textoguardar.Write(clase_compartida.lista);
            //        textoguardar.Flush();
            //        textoguardar.Close();


            //        file.Close();
            //    }
            //}

            //////////////////////////////////////////////////////////////
            TextWriter textWriter = new StreamWriter("encuesta.txt");

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName)) 
                    {
                        string filename = saveFileDialog.FileName;
                        StreamWriter textSave = File.CreateText(filename);


                    foreach (var dato in clase_compartida.lista)
                    {
                        textSave.Write(dato);
                    }



                    textSave.Flush();
                        textSave.Close();
                    } 
                    else
                    {
                        string filename = saveFileDialog.FileName;
                        StreamWriter textSave = File.CreateText(filename);

                    foreach (var dato in clase_compartida.lista)
                    {
                        textSave.Write(dato);
                    }

                    textSave.Flush();
                        textSave.Close();
                    }
                }

              
            

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
