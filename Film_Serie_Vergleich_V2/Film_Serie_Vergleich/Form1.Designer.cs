namespace Film_Serie_Vergleich
{
    partial class frmStart
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnHinzuf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnzFilm = new System.Windows.Forms.Label();
            this.lblAnzSerie = new System.Windows.Forms.Label();
            this.txtLinks = new System.Windows.Forms.TextBox();
            this.txtRechts = new System.Windows.Forms.TextBox();
            this.btnVergleich = new System.Windows.Forms.Button();
            this.txtFilmeing = new System.Windows.Forms.TextBox();
            this.txtSerieeing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmraktualisieren = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHinzuf
            // 
            this.btnHinzuf.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHinzuf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHinzuf.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinzuf.Location = new System.Drawing.Point(12, 12);
            this.btnHinzuf.Name = "btnHinzuf";
            this.btnHinzuf.Size = new System.Drawing.Size(93, 32);
            this.btnHinzuf.TabIndex = 0;
            this.btnHinzuf.Text = "Hinzufügen";
            this.btnHinzuf.UseVisualStyleBackColor = false;
            this.btnHinzuf.Click += new System.EventHandler(this.btnHinzuf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anzahl Filme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anzahl Serien: ";
            // 
            // lblAnzFilm
            // 
            this.lblAnzFilm.AutoSize = true;
            this.lblAnzFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzFilm.Location = new System.Drawing.Point(111, 56);
            this.lblAnzFilm.Name = "lblAnzFilm";
            this.lblAnzFilm.Size = new System.Drawing.Size(14, 13);
            this.lblAnzFilm.TabIndex = 3;
            this.lblAnzFilm.Text = "0";
            // 
            // lblAnzSerie
            // 
            this.lblAnzSerie.AutoSize = true;
            this.lblAnzSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzSerie.Location = new System.Drawing.Point(111, 73);
            this.lblAnzSerie.Name = "lblAnzSerie";
            this.lblAnzSerie.Size = new System.Drawing.Size(14, 13);
            this.lblAnzSerie.TabIndex = 4;
            this.lblAnzSerie.Text = "0";
            // 
            // txtLinks
            // 
            this.txtLinks.Location = new System.Drawing.Point(11, 148);
            this.txtLinks.Multiline = true;
            this.txtLinks.Name = "txtLinks";
            this.txtLinks.ReadOnly = true;
            this.txtLinks.Size = new System.Drawing.Size(214, 296);
            this.txtLinks.TabIndex = 5;
            // 
            // txtRechts
            // 
            this.txtRechts.Location = new System.Drawing.Point(300, 148);
            this.txtRechts.Multiline = true;
            this.txtRechts.Name = "txtRechts";
            this.txtRechts.ReadOnly = true;
            this.txtRechts.Size = new System.Drawing.Size(214, 296);
            this.txtRechts.TabIndex = 6;
            // 
            // btnVergleich
            // 
            this.btnVergleich.BackColor = System.Drawing.Color.AliceBlue;
            this.btnVergleich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVergleich.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVergleich.Location = new System.Drawing.Point(206, 450);
            this.btnVergleich.Name = "btnVergleich";
            this.btnVergleich.Size = new System.Drawing.Size(112, 39);
            this.btnVergleich.TabIndex = 7;
            this.btnVergleich.Text = "Vergleichen";
            this.btnVergleich.UseVisualStyleBackColor = false;
            this.btnVergleich.Click += new System.EventHandler(this.btnVergleich_Click);
            // 
            // txtFilmeing
            // 
            this.txtFilmeing.Location = new System.Drawing.Point(11, 122);
            this.txtFilmeing.Name = "txtFilmeing";
            this.txtFilmeing.Size = new System.Drawing.Size(214, 20);
            this.txtFilmeing.TabIndex = 8;
            // 
            // txtSerieeing
            // 
            this.txtSerieeing.Location = new System.Drawing.Point(300, 122);
            this.txtSerieeing.Name = "txtSerieeing";
            this.txtSerieeing.Size = new System.Drawing.Size(214, 20);
            this.txtSerieeing.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Film / Serie eingeben";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro Light", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Film / Serie eingeben";
            // 
            // tmraktualisieren
            // 
            this.tmraktualisieren.Enabled = true;
            this.tmraktualisieren.Interval = 5;
            this.tmraktualisieren.Tick += new System.EventHandler(this.tmraktualisieren_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(170, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vergleiche Filme und Serien";
            // 
            // frmStart
            // 
            this.AcceptButton = this.btnVergleich;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(528, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSerieeing);
            this.Controls.Add(this.txtFilmeing);
            this.Controls.Add(this.btnVergleich);
            this.Controls.Add(this.txtRechts);
            this.Controls.Add(this.txtLinks);
            this.Controls.Add(this.lblAnzSerie);
            this.Controls.Add(this.lblAnzFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHinzuf);
            this.MaximizeBox = false;
            this.Name = "frmStart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vergleiche Filme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHinzuf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAnzFilm;
        private System.Windows.Forms.Label lblAnzSerie;
        private System.Windows.Forms.TextBox txtLinks;
        private System.Windows.Forms.TextBox txtRechts;
        private System.Windows.Forms.Button btnVergleich;
        private System.Windows.Forms.TextBox txtFilmeing;
        private System.Windows.Forms.TextBox txtSerieeing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmraktualisieren;
        private System.Windows.Forms.Label label5;
    }
}

