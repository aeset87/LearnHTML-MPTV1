namespace MPTformVersion1
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.pitanje = new System.Windows.Forms.GroupBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.odgovor4 = new System.Windows.Forms.RadioButton();
            this.odgovor3 = new System.Windows.Forms.RadioButton();
            this.odgovor2 = new System.Windows.Forms.RadioButton();
            this.odgovor1 = new System.Windows.Forms.RadioButton();
            this.pitanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // pitanje
            // 
            this.pitanje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pitanje.AutoSize = true;
            this.pitanje.BackColor = System.Drawing.Color.Transparent;
            this.pitanje.Controls.Add(this.btn_ok);
            this.pitanje.Controls.Add(this.odgovor4);
            this.pitanje.Controls.Add(this.odgovor3);
            this.pitanje.Controls.Add(this.odgovor2);
            this.pitanje.Controls.Add(this.odgovor1);
            this.pitanje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitanje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pitanje.Location = new System.Drawing.Point(77, 17);
            this.pitanje.Name = "pitanje";
            this.pitanje.Padding = new System.Windows.Forms.Padding(50);
            this.pitanje.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pitanje.Size = new System.Drawing.Size(521, 407);
            this.pitanje.TabIndex = 0;
            this.pitanje.TabStop = false;
            this.pitanje.Text = "Šta je HTML?";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Black;
            this.btn_ok.Location = new System.Drawing.Point(234, 259);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(73, 34);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // odgovor4
            // 
            this.odgovor4.AutoSize = true;
            this.odgovor4.Location = new System.Drawing.Point(98, 222);
            this.odgovor4.Name = "odgovor4";
            this.odgovor4.Size = new System.Drawing.Size(143, 25);
            this.odgovor4.TabIndex = 3;
            this.odgovor4.TabStop = true;
            this.odgovor4.Text = "programski jezik";
            this.odgovor4.UseVisualStyleBackColor = true;
            // 
            // odgovor3
            // 
            this.odgovor3.AutoSize = true;
            this.odgovor3.Location = new System.Drawing.Point(97, 177);
            this.odgovor3.Name = "odgovor3";
            this.odgovor3.Size = new System.Drawing.Size(165, 25);
            this.odgovor3.TabIndex = 2;
            this.odgovor3.TabStop = true;
            this.odgovor3.Text = "hypertext biblioteka";
            this.odgovor3.UseVisualStyleBackColor = true;
            // 
            // odgovor2
            // 
            this.odgovor2.AutoSize = true;
            this.odgovor2.Location = new System.Drawing.Point(96, 135);
            this.odgovor2.Name = "odgovor2";
            this.odgovor2.Size = new System.Drawing.Size(117, 25);
            this.odgovor2.TabIndex = 1;
            this.odgovor2.TabStop = true;
            this.odgovor2.Text = "markup jezik";
            this.odgovor2.UseVisualStyleBackColor = true;
            this.odgovor2.CheckedChanged += new System.EventHandler(this.odgovor2_CheckedChanged);
            // 
            // odgovor1
            // 
            this.odgovor1.AutoSize = true;
            this.odgovor1.Location = new System.Drawing.Point(96, 92);
            this.odgovor1.Name = "odgovor1";
            this.odgovor1.Size = new System.Drawing.Size(101, 25);
            this.odgovor1.TabIndex = 0;
            this.odgovor1.TabStop = true;
            this.odgovor1.Text = "script jezik";
            this.odgovor1.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pitanje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEST - Pitanje 3";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.pitanje.ResumeLayout(false);
            this.pitanje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pitanje;
        private System.Windows.Forms.RadioButton odgovor4;
        private System.Windows.Forms.RadioButton odgovor3;
        private System.Windows.Forms.RadioButton odgovor2;
        private System.Windows.Forms.RadioButton odgovor1;
        private System.Windows.Forms.Button btn_ok;
    }
}