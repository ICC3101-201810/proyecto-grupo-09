namespace WindowsFormsApp3
{
    partial class VentanaAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcom = new System.Windows.Forms.ComboBox();
            this.botaceptar = new System.Windows.Forms.Button();
            this.botvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Que desea hacer:";
            // 
            // txtcom
            // 
            this.txtcom.FormattingEnabled = true;
            this.txtcom.Items.AddRange(new object[] {
            "Ver salas disponibles",
            "Hacer reserva",
            "Ver estado"});
            this.txtcom.Location = new System.Drawing.Point(171, 71);
            this.txtcom.Name = "txtcom";
            this.txtcom.Size = new System.Drawing.Size(121, 21);
            this.txtcom.TabIndex = 2;
            // 
            // botaceptar
            // 
            this.botaceptar.Location = new System.Drawing.Point(48, 170);
            this.botaceptar.Name = "botaceptar";
            this.botaceptar.Size = new System.Drawing.Size(75, 23);
            this.botaceptar.TabIndex = 3;
            this.botaceptar.Text = "Aceptar";
            this.botaceptar.UseVisualStyleBackColor = true;
            this.botaceptar.Click += new System.EventHandler(this.botaceptar_Click);
            // 
            // botvolver
            // 
            this.botvolver.Location = new System.Drawing.Point(217, 170);
            this.botvolver.Name = "botvolver";
            this.botvolver.Size = new System.Drawing.Size(75, 23);
            this.botvolver.TabIndex = 4;
            this.botvolver.Text = "Volver";
            this.botvolver.UseVisualStyleBackColor = true;
            this.botvolver.Click += new System.EventHandler(this.botvolver_Click);
            // 
            // VentanaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 258);
            this.Controls.Add(this.botvolver);
            this.Controls.Add(this.botaceptar);
            this.Controls.Add(this.txtcom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaAlumno";
            this.Text = "VentanaAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtcom;
        private System.Windows.Forms.Button botaceptar;
        private System.Windows.Forms.Button botvolver;
    }
}