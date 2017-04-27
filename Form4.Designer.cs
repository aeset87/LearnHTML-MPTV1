namespace MPTformVersion1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.html_instruction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.editor = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // html_instruction
            // 
            this.html_instruction.BackColor = System.Drawing.Color.Transparent;
            this.html_instruction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.html_instruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.html_instruction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.html_instruction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.html_instruction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.html_instruction.Location = new System.Drawing.Point(0, 0);
            this.html_instruction.MinimumSize = new System.Drawing.Size(0, 200);
            this.html_instruction.Name = "html_instruction";
            this.html_instruction.Size = new System.Drawing.Size(1448, 200);
            this.html_instruction.TabIndex = 0;
            this.html_instruction.Text = "Za prikazivanje paragrafa teksta koristimo <p> tag.";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.browser);
            this.panel1.Controls.Add(this.editor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1448, 196);
            this.panel1.TabIndex = 1;
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(650, 0);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(798, 196);
            this.browser.TabIndex = 1;
            // 
            // editor
            // 
            this.editor.AcceptsTab = true;
            this.editor.BackColor = System.Drawing.Color.Black;
            this.editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editor.Dock = System.Windows.Forms.DockStyle.Left;
            this.editor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.ForeColor = System.Drawing.SystemColors.Menu;
            this.editor.Location = new System.Drawing.Point(0, 0);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(650, 196);
            this.editor.TabIndex = 0;
            this.editor.Text = resources.GetString("editor.Text");
            this.editor.TextChanged += new System.EventHandler(this.editor_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1183, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "DALJE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1448, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.html_instruction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "NAUČI HTML - DODAVANJE PARAGRAFA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label html_instruction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox editor;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button button1;
    }
}