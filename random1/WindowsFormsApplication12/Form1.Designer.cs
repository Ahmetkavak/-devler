namespace WindowsFormsApplication12
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.A_DEĞERİ = new System.Windows.Forms.ListBox();
            this.B_DEĞERİ = new System.Windows.Forms.ListBox();
            this.TOPLAM = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A_DEĞERİ
            // 
            this.A_DEĞERİ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.A_DEĞERİ.ForeColor = System.Drawing.Color.DarkRed;
            this.A_DEĞERİ.FormattingEnabled = true;
            this.A_DEĞERİ.Location = new System.Drawing.Point(22, 96);
            this.A_DEĞERİ.Name = "A_DEĞERİ";
            this.A_DEĞERİ.Size = new System.Drawing.Size(69, 134);
            this.A_DEĞERİ.TabIndex = 0;
            // 
            // B_DEĞERİ
            // 
            this.B_DEĞERİ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.B_DEĞERİ.ForeColor = System.Drawing.Color.DarkRed;
            this.B_DEĞERİ.FormattingEnabled = true;
            this.B_DEĞERİ.Location = new System.Drawing.Point(106, 96);
            this.B_DEĞERİ.Name = "B_DEĞERİ";
            this.B_DEĞERİ.Size = new System.Drawing.Size(68, 134);
            this.B_DEĞERİ.TabIndex = 1;
            // 
            // TOPLAM
            // 
            this.TOPLAM.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TOPLAM.ForeColor = System.Drawing.Color.DarkRed;
            this.TOPLAM.FormattingEnabled = true;
            this.TOPLAM.Location = new System.Drawing.Point(190, 96);
            this.TOPLAM.Name = "TOPLAM";
            this.TOPLAM.Size = new System.Drawing.Size(68, 134);
            this.TOPLAM.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(106, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "TOPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TOPLAM);
            this.Controls.Add(this.B_DEĞERİ);
            this.Controls.Add(this.A_DEĞERİ);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox A_DEĞERİ;
        private System.Windows.Forms.ListBox B_DEĞERİ;
        private System.Windows.Forms.ListBox TOPLAM;
        private System.Windows.Forms.Button button1;
    }
}

