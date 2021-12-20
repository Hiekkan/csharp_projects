namespace JentzschCSharpWiki
{
    partial class Variablen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Variablen));
            this.TextBox_Var = new System.Windows.Forms.TextBox();
            this.Form_Title_Var = new System.Windows.Forms.Label();
            this.Button_Close_Var = new System.Windows.Forms.Button();
            this.Button_egg = new System.Windows.Forms.Button();
            this.PictureBox_Dat = new System.Windows.Forms.PictureBox();
            this.textBox_Var_2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Dat)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Var
            // 
            this.TextBox_Var.BackColor = System.Drawing.Color.DimGray;
            this.TextBox_Var.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Var.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TextBox_Var.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBox_Var.Location = new System.Drawing.Point(16, 44);
            this.TextBox_Var.Multiline = true;
            this.TextBox_Var.Name = "TextBox_Var";
            this.TextBox_Var.ReadOnly = true;
            this.TextBox_Var.Size = new System.Drawing.Size(346, 118);
            this.TextBox_Var.TabIndex = 0;
            this.TextBox_Var.Text = resources.GetString("TextBox_Var.Text");
            // 
            // Form_Title_Var
            // 
            this.Form_Title_Var.AutoSize = true;
            this.Form_Title_Var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_Title_Var.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Form_Title_Var.Location = new System.Drawing.Point(12, 9);
            this.Form_Title_Var.Name = "Form_Title_Var";
            this.Form_Title_Var.Size = new System.Drawing.Size(171, 20);
            this.Form_Title_Var.TabIndex = 1;
            this.Form_Title_Var.Text = "Variablen / Datentypen";
            // 
            // Button_Close_Var
            // 
            this.Button_Close_Var.BackColor = System.Drawing.Color.Silver;
            this.Button_Close_Var.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close_Var.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Close_Var.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Close_Var.Location = new System.Drawing.Point(1009, 402);
            this.Button_Close_Var.Name = "Button_Close_Var";
            this.Button_Close_Var.Size = new System.Drawing.Size(135, 40);
            this.Button_Close_Var.TabIndex = 2;
            this.Button_Close_Var.Text = "Schliessen";
            this.Button_Close_Var.UseVisualStyleBackColor = false;
            this.Button_Close_Var.Click += new System.EventHandler(this.Button_Close_Var_Click);
            // 
            // Button_egg
            // 
            this.Button_egg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_egg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_egg.ForeColor = System.Drawing.Color.DimGray;
            this.Button_egg.Location = new System.Drawing.Point(-1, 442);
            this.Button_egg.Name = "Button_egg";
            this.Button_egg.Size = new System.Drawing.Size(10, 12);
            this.Button_egg.TabIndex = 4;
            this.Button_egg.UseVisualStyleBackColor = true;
            this.Button_egg.Click += new System.EventHandler(this.Button_egg_Click);
            // 
            // PictureBox_Dat
            // 
            this.PictureBox_Dat.Image = global::JentzschCSharpWiki.Properties.Resources.datentypen;
            this.PictureBox_Dat.Location = new System.Drawing.Point(404, 44);
            this.PictureBox_Dat.Name = "PictureBox_Dat";
            this.PictureBox_Dat.Size = new System.Drawing.Size(706, 342);
            this.PictureBox_Dat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Dat.TabIndex = 3;
            this.PictureBox_Dat.TabStop = false;
            // 
            // textBox_Var_2
            // 
            this.textBox_Var_2.BackColor = System.Drawing.Color.DimGray;
            this.textBox_Var_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Var_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox_Var_2.Location = new System.Drawing.Point(16, 169);
            this.textBox_Var_2.Multiline = true;
            this.textBox_Var_2.Name = "textBox_Var_2";
            this.textBox_Var_2.ReadOnly = true;
            this.textBox_Var_2.Size = new System.Drawing.Size(346, 125);
            this.textBox_Var_2.TabIndex = 5;
            this.textBox_Var_2.Text = "Beispiele\r\nbyte ganze_Zahl = 5;\r\ndouble komma_Zahl = 23.66;\r\nbool Wahrheit = true" +
    ";\r\nchar Buchstabe = \"B\";\r\nstring Wort = \"Hallo\";";
            // 
            // Variablen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.Button_Close_Var;
            this.ClientSize = new System.Drawing.Size(1156, 454);
            this.Controls.Add(this.textBox_Var_2);
            this.Controls.Add(this.Button_egg);
            this.Controls.Add(this.PictureBox_Dat);
            this.Controls.Add(this.Button_Close_Var);
            this.Controls.Add(this.Form_Title_Var);
            this.Controls.Add(this.TextBox_Var);
            this.Name = "Variablen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Variablen";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Dat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Var;
        private System.Windows.Forms.Label Form_Title_Var;
        private System.Windows.Forms.Button Button_Close_Var;
        private System.Windows.Forms.PictureBox PictureBox_Dat;
        private System.Windows.Forms.Button Button_egg;
        private System.Windows.Forms.TextBox textBox_Var_2;
    }
}