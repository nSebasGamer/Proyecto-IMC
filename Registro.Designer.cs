namespace IMC__Login_
{
    partial class Registro
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.mBtn = new System.Windows.Forms.RadioButton();
            this.HBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(146, 363);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(235, 22);
            this.txtcontra.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(146, 259);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(235, 22);
            this.txtuser.TabIndex = 5;
            // 
            // mBtn
            // 
            this.mBtn.AutoSize = true;
            this.mBtn.Location = new System.Drawing.Point(183, 461);
            this.mBtn.Name = "mBtn";
            this.mBtn.Size = new System.Drawing.Size(61, 20);
            this.mBtn.TabIndex = 10;
            this.mBtn.TabStop = true;
            this.mBtn.Text = "Mujer";
            this.mBtn.UseVisualStyleBackColor = true;
            this.mBtn.CheckedChanged += new System.EventHandler(this.mBtn_CheckedChanged);
            // 
            // HBtn
            // 
            this.HBtn.AutoSize = true;
            this.HBtn.Location = new System.Drawing.Point(278, 461);
            this.HBtn.Name = "HBtn";
            this.HBtn.Size = new System.Drawing.Size(77, 20);
            this.HBtn.TabIndex = 11;
            this.HBtn.TabStop = true;
            this.HBtn.Text = "Hombre";
            this.HBtn.UseVisualStyleBackColor = true;
            this.HBtn.CheckedChanged += new System.EventHandler(this.HBtn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sexo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMC__Login_.Properties.Resources.Registro;
            this.ClientSize = new System.Drawing.Size(527, 698);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HBtn);
            this.Controls.Add(this.mBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuser);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.RadioButton mBtn;
        private System.Windows.Forms.RadioButton HBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}