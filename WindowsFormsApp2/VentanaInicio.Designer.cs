namespace WindowsFormsApp2
{
    partial class VentanaInicio
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
            this.txtcom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botIng = new System.Windows.Forms.Button();
            this.botvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcom
            // 
            this.txtcom.FormattingEnabled = true;
            this.txtcom.Items.AddRange(new object[] {
            "Alumno",
            "Profesor",
            "Bibliotecario"});
            this.txtcom.Location = new System.Drawing.Point(137, 68);
            this.txtcom.Name = "txtcom";
            this.txtcom.Size = new System.Drawing.Size(121, 21);
            this.txtcom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usted es:";
            // 
            // botIng
            // 
            this.botIng.Location = new System.Drawing.Point(49, 156);
            this.botIng.Name = "botIng";
            this.botIng.Size = new System.Drawing.Size(75, 23);
            this.botIng.TabIndex = 3;
            this.botIng.Text = "Ingreso";
            this.botIng.UseVisualStyleBackColor = true;
            this.botIng.Click += new System.EventHandler(this.botIng_Click);
            // 
            // botvolver
            // 
            this.botvolver.Location = new System.Drawing.Point(183, 156);
            this.botvolver.Name = "botvolver";
            this.botvolver.Size = new System.Drawing.Size(75, 23);
            this.botvolver.TabIndex = 4;
            this.botvolver.Text = "Volver";
            this.botvolver.UseVisualStyleBackColor = true;
            this.botvolver.Click += new System.EventHandler(this.botvolver_Click);
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 231);
            this.Controls.Add(this.botvolver);
            this.Controls.Add(this.botIng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcom);
            this.Name = "VentanaInicio";
            this.Text = "VentanaInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtcom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botIng;
        private System.Windows.Forms.Button botvolver;
    }
}