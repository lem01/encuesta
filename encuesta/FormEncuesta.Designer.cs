namespace encuesta
{
    partial class FormEncuesta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlEncuesta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFace = new System.Windows.Forms.CheckBox();
            this.checkBoxTwitter = new System.Windows.Forms.CheckBox();
            this.checkBoxInstagram = new System.Windows.Forms.CheckBox();
            this.checkBoxOtro = new System.Windows.Forms.CheckBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.tabControlEncuesta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEncuesta
            // 
            this.tabControlEncuesta.Controls.Add(this.tabPage1);
            this.tabControlEncuesta.Controls.Add(this.tabPage2);
            this.tabControlEncuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEncuesta.Location = new System.Drawing.Point(0, 0);
            this.tabControlEncuesta.Name = "tabControlEncuesta";
            this.tabControlEncuesta.SelectedIndex = 0;
            this.tabControlEncuesta.Size = new System.Drawing.Size(501, 402);
            this.tabControlEncuesta.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBoxEdad);
            this.tabPage1.Controls.Add(this.textBoxCiudad);
            this.tabPage1.Controls.Add(this.textBoxID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnGuardar);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos de Redes Sociales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(178, 143);
            this.textBoxEdad.MaxLength = 2;
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(33, 22);
            this.textBoxEdad.TabIndex = 12;
            this.textBoxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(178, 98);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(100, 22);
            this.textBoxCiudad.TabIndex = 11;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(178, 53);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingrese su edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccionar Ciudad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID de Encuesta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonM);
            this.groupBox1.Controls.Add(this.radioButtonF);
            this.groupBox1.Location = new System.Drawing.Point(59, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el sexo:";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Checked = true;
            this.radioButtonF.Location = new System.Drawing.Point(34, 37);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(91, 21);
            this.radioButtonF.TabIndex = 0;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "Femenino";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(159, 37);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(92, 21);
            this.radioButtonM.TabIndex = 1;
            this.radioButtonM.Text = "Masculino";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxOtro);
            this.groupBox2.Controls.Add(this.checkBoxInstagram);
            this.groupBox2.Controls.Add(this.checkBoxTwitter);
            this.groupBox2.Controls.Add(this.checkBoxFace);
            this.groupBox2.Location = new System.Drawing.Point(45, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 225);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione las redes sociales que utiliza:";
            // 
            // checkBoxFace
            // 
            this.checkBoxFace.AutoSize = true;
            this.checkBoxFace.Location = new System.Drawing.Point(35, 44);
            this.checkBoxFace.Name = "checkBoxFace";
            this.checkBoxFace.Size = new System.Drawing.Size(92, 21);
            this.checkBoxFace.TabIndex = 0;
            this.checkBoxFace.Text = "Facebook";
            this.checkBoxFace.UseVisualStyleBackColor = true;
            // 
            // checkBoxTwitter
            // 
            this.checkBoxTwitter.AutoSize = true;
            this.checkBoxTwitter.Location = new System.Drawing.Point(35, 80);
            this.checkBoxTwitter.Name = "checkBoxTwitter";
            this.checkBoxTwitter.Size = new System.Drawing.Size(72, 21);
            this.checkBoxTwitter.TabIndex = 1;
            this.checkBoxTwitter.Text = "Twitter";
            this.checkBoxTwitter.UseVisualStyleBackColor = true;
            // 
            // checkBoxInstagram
            // 
            this.checkBoxInstagram.AutoSize = true;
            this.checkBoxInstagram.Location = new System.Drawing.Point(35, 116);
            this.checkBoxInstagram.Name = "checkBoxInstagram";
            this.checkBoxInstagram.Size = new System.Drawing.Size(97, 21);
            this.checkBoxInstagram.TabIndex = 2;
            this.checkBoxInstagram.Text = "Instragram";
            this.checkBoxInstagram.UseVisualStyleBackColor = true;
            // 
            // checkBoxOtro
            // 
            this.checkBoxOtro.AutoSize = true;
            this.checkBoxOtro.Location = new System.Drawing.Point(35, 152);
            this.checkBoxOtro.Name = "checkBoxOtro";
            this.checkBoxOtro.Size = new System.Drawing.Size(58, 21);
            this.checkBoxOtro.TabIndex = 3;
            this.checkBoxOtro.Text = "Otra";
            this.checkBoxOtro.UseVisualStyleBackColor = true;
            this.checkBoxOtro.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(128, 293);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(212, 41);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar Encuesta";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FormEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 402);
            this.Controls.Add(this.tabControlEncuesta);
            this.Name = "FormEncuesta";
            this.Text = "FormEncuesta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlEncuesta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEncuesta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxFace;
        private System.Windows.Forms.CheckBox checkBoxOtro;
        private System.Windows.Forms.CheckBox checkBoxInstagram;
        private System.Windows.Forms.CheckBox checkBoxTwitter;
        private System.Windows.Forms.Button BtnGuardar;
    }
}