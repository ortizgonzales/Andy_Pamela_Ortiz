namespace ejercicio2
{
    partial class arreglo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guardarbutton2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nombretextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edadtextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guardarbutton2
            // 
            this.guardarbutton2.Location = new System.Drawing.Point(347, 30);
            this.guardarbutton2.Name = "guardarbutton2";
            this.guardarbutton2.Size = new System.Drawing.Size(75, 49);
            this.guardarbutton2.TabIndex = 1;
            this.guardarbutton2.Text = "Guardar Datos";
            this.guardarbutton2.UseVisualStyleBackColor = true;
            this.guardarbutton2.Click += new System.EventHandler(this.guardarbutton2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(30, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(420, 94);
            this.listBox1.TabIndex = 3;
            // 
            // nombretextBox1
            // 
            this.nombretextBox1.Location = new System.Drawing.Point(191, 27);
            this.nombretextBox1.Name = "nombretextBox1";
            this.nombretextBox1.Size = new System.Drawing.Size(133, 23);
            this.nombretextBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese nombre del estudiante: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese edad : ";
            // 
            // edadtextBox2
            // 
            this.edadtextBox2.Location = new System.Drawing.Point(191, 56);
            this.edadtextBox2.Name = "edadtextBox2";
            this.edadtextBox2.Size = new System.Drawing.Size(133, 23);
            this.edadtextBox2.TabIndex = 7;
            // 
            // arreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(531, 257);
            this.Controls.Add(this.edadtextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombretextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.guardarbutton2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "arreglo";
            this.Text = "arreglo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button guardarbutton2;
        private ListBox listBox1;
        private TextBox nombretextBox1;
        private Label label1;
        private Label label2;
        private TextBox edadtextBox2;
    }
}