namespace Film_Serie_Vergleich
{
    partial class Hinzufuegen
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
            this.rdbFilm = new System.Windows.Forms.RadioButton();
            this.rdbSerie = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEintrag = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJahr = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtAnzSta = new System.Windows.Forms.TextBox();
            this.txtAnzFolg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbFilm
            // 
            this.rdbFilm.AutoSize = true;
            this.rdbFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFilm.Location = new System.Drawing.Point(79, 23);
            this.rdbFilm.Name = "rdbFilm";
            this.rdbFilm.Size = new System.Drawing.Size(70, 29);
            this.rdbFilm.TabIndex = 0;
            this.rdbFilm.TabStop = true;
            this.rdbFilm.Text = "Film";
            this.rdbFilm.UseVisualStyleBackColor = true;
            this.rdbFilm.CheckedChanged += new System.EventHandler(this.rdbFilm_CheckedChanged);
            // 
            // rdbSerie
            // 
            this.rdbSerie.AutoSize = true;
            this.rdbSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSerie.Location = new System.Drawing.Point(262, 23);
            this.rdbSerie.Name = "rdbSerie";
            this.rdbSerie.Size = new System.Drawing.Size(80, 29);
            this.rdbSerie.TabIndex = 1;
            this.rdbSerie.TabStop = true;
            this.rdbSerie.Text = "Serie";
            this.rdbSerie.UseVisualStyleBackColor = true;
            this.rdbSerie.CheckedChanged += new System.EventHandler(this.rdbSerie_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jahr*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Anzahl Staffeln:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Durchschnittliche Folgen pro Staffel:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(-2, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(449, 2);
            this.label7.TabIndex = 8;
            // 
            // btnEintrag
            // 
            this.btnEintrag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEintrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEintrag.Location = new System.Drawing.Point(335, 246);
            this.btnEintrag.Name = "btnEintrag";
            this.btnEintrag.Size = new System.Drawing.Size(98, 35);
            this.btnEintrag.TabIndex = 9;
            this.btnEintrag.Text = "Eintragen";
            this.btnEintrag.UseVisualStyleBackColor = true;
            this.btnEintrag.Click += new System.EventHandler(this.btnEintrag_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(207, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 22);
            this.txtName.TabIndex = 10;
            // 
            // txtJahr
            // 
            this.txtJahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJahr.Location = new System.Drawing.Point(357, 107);
            this.txtJahr.Name = "txtJahr";
            this.txtJahr.Size = new System.Drawing.Size(76, 22);
            this.txtJahr.TabIndex = 11;
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(262, 135);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(171, 22);
            this.txtGenre.TabIndex = 12;
            // 
            // txtAnzSta
            // 
            this.txtAnzSta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnzSta.Location = new System.Drawing.Point(400, 177);
            this.txtAnzSta.Name = "txtAnzSta";
            this.txtAnzSta.Size = new System.Drawing.Size(33, 22);
            this.txtAnzSta.TabIndex = 13;
            // 
            // txtAnzFolg
            // 
            this.txtAnzFolg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnzFolg.Location = new System.Drawing.Point(400, 207);
            this.txtAnzFolg.Name = "txtAnzFolg";
            this.txtAnzFolg.Size = new System.Drawing.Size(33, 22);
            this.txtAnzFolg.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "*: Muss ausgefüllt sein";
            // 
            // Hinzufuegen
            // 
            this.AcceptButton = this.btnEintrag;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 288);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAnzFolg);
            this.Controls.Add(this.txtAnzSta);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtJahr);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnEintrag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbSerie);
            this.Controls.Add(this.rdbFilm);
            this.MaximizeBox = false;
            this.Name = "Hinzufuegen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hinzufuegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbFilm;
        private System.Windows.Forms.RadioButton rdbSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEintrag;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJahr;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtAnzSta;
        private System.Windows.Forms.TextBox txtAnzFolg;
        private System.Windows.Forms.Label label8;
    }
}