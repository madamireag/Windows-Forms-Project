namespace Tema1
{
    partial class EditarePariuri
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
            this.tbCotaCastig = new System.Windows.Forms.TextBox();
            this.tbOponent = new System.Windows.Forms.TextBox();
            this.tbJucator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpMeci = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCastigator = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCotaCastig
            // 
            this.tbCotaCastig.Location = new System.Drawing.Point(63, 313);
            this.tbCotaCastig.Name = "tbCotaCastig";
            this.tbCotaCastig.Size = new System.Drawing.Size(234, 22);
            this.tbCotaCastig.TabIndex = 27;
            // 
            // tbOponent
            // 
            this.tbOponent.Location = new System.Drawing.Point(63, 223);
            this.tbOponent.Name = "tbOponent";
            this.tbOponent.Size = new System.Drawing.Size(234, 22);
            this.tbOponent.TabIndex = 31;
            // 
            // tbJucator
            // 
            this.tbJucator.Location = new System.Drawing.Point(64, 178);
            this.tbJucator.Name = "tbJucator";
            this.tbJucator.Size = new System.Drawing.Size(233, 22);
            this.tbJucator.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Suma pariu\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Oponent";
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(63, 41);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(234, 22);
            this.tbSuma.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Jucator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sport";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "FOTBAL",
            "TENIS",
            "SNOOKER",
            "BASCHET",
            "VOLEI"});
            this.cbTip.Location = new System.Drawing.Point(63, 86);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(234, 24);
            this.cbTip.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cota aferenta";
            // 
            // dtpMeci
            // 
            this.dtpMeci.Location = new System.Drawing.Point(64, 133);
            this.dtpMeci.Name = "dtpMeci";
            this.dtpMeci.Size = new System.Drawing.Size(233, 22);
            this.dtpMeci.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Castigatorul meciului";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data meciului";
            // 
            // tbCastigator
            // 
            this.tbCastigator.Location = new System.Drawing.Point(64, 268);
            this.tbCastigator.Name = "tbCastigator";
            this.tbCastigator.Size = new System.Drawing.Size(233, 22);
            this.tbCastigator.TabIndex = 23;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Image = global::Tema1.Properties.Resources.arrows;
            this.btnConfirma.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirma.Location = new System.Drawing.Point(64, 365);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(112, 55);
            this.btnConfirma.TabIndex = 33;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Image = global::Tema1.Properties.Resources._interface;
            this.btnAnuleaza.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnuleaza.Location = new System.Drawing.Point(181, 365);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(116, 55);
            this.btnAnuleaza.TabIndex = 32;
            this.btnAnuleaza.Text = "Anuleaza\r\n";
            this.btnAnuleaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // EditarePariuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 488);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.tbCotaCastig);
            this.Controls.Add(this.tbOponent);
            this.Controls.Add(this.tbJucator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpMeci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCastigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarePariuri";
            this.Text = "Editare Pariu";
            this.Load += new System.EventHandler(this.EditarePariuri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCotaCastig;
        private System.Windows.Forms.TextBox tbOponent;
        private System.Windows.Forms.TextBox tbJucator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpMeci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCastigator;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnConfirma;
    }
}