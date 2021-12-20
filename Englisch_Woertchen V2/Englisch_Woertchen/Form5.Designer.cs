namespace Englisch_Woertchen
{
    partial class Form5
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
            this.lblFalschW = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbDeutsch = new System.Windows.Forms.RadioButton();
            this.rdbEnglisch = new System.Windows.Forms.RadioButton();
            this.lblWortAnzahl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFalsch = new System.Windows.Forms.Label();
            this.btnEingabe = new System.Windows.Forms.Button();
            this.txtLoesung = new System.Windows.Forms.TextBox();
            this.txtGesucht = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFalschW
            // 
            this.lblFalschW.AutoSize = true;
            this.lblFalschW.Location = new System.Drawing.Point(420, 217);
            this.lblFalschW.Name = "lblFalschW";
            this.lblFalschW.Size = new System.Drawing.Size(13, 13);
            this.lblFalschW.TabIndex = 24;
            this.lblFalschW.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Anzahl Falsche Wörter:";
            // 
            // rdbDeutsch
            // 
            this.rdbDeutsch.AutoSize = true;
            this.rdbDeutsch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDeutsch.Location = new System.Drawing.Point(277, 10);
            this.rdbDeutsch.Name = "rdbDeutsch";
            this.rdbDeutsch.Size = new System.Drawing.Size(137, 20);
            this.rdbDeutsch.TabIndex = 22;
            this.rdbDeutsch.TabStop = true;
            this.rdbDeutsch.Text = "Deutsch schreiben";
            this.rdbDeutsch.UseVisualStyleBackColor = true;
            this.rdbDeutsch.CheckedChanged += new System.EventHandler(this.rdbDeutsch_CheckedChanged);
            // 
            // rdbEnglisch
            // 
            this.rdbEnglisch.AutoSize = true;
            this.rdbEnglisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnglisch.Location = new System.Drawing.Point(80, 10);
            this.rdbEnglisch.Name = "rdbEnglisch";
            this.rdbEnglisch.Size = new System.Drawing.Size(139, 20);
            this.rdbEnglisch.TabIndex = 21;
            this.rdbEnglisch.TabStop = true;
            this.rdbEnglisch.Text = "Englisch schreiben";
            this.rdbEnglisch.UseVisualStyleBackColor = true;
            this.rdbEnglisch.CheckedChanged += new System.EventHandler(this.rdbEnglisch_CheckedChanged);
            // 
            // lblWortAnzahl
            // 
            this.lblWortAnzahl.AutoSize = true;
            this.lblWortAnzahl.Location = new System.Drawing.Point(230, 217);
            this.lblWortAnzahl.Name = "lblWortAnzahl";
            this.lblWortAnzahl.Size = new System.Drawing.Size(0, 13);
            this.lblWortAnzahl.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "von";
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.AutoSize = true;
            this.lblAnzahl.Location = new System.Drawing.Point(154, 217);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.Size = new System.Drawing.Size(13, 13);
            this.lblAnzahl.TabIndex = 18;
            this.lblAnzahl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Anzahl Richtige Wörter:";
            // 
            // lblFalsch
            // 
            this.lblFalsch.AutoSize = true;
            this.lblFalsch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalsch.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFalsch.Location = new System.Drawing.Point(77, 159);
            this.lblFalsch.Name = "lblFalsch";
            this.lblFalsch.Size = new System.Drawing.Size(0, 18);
            this.lblFalsch.TabIndex = 16;
            // 
            // btnEingabe
            // 
            this.btnEingabe.Location = new System.Drawing.Point(339, 115);
            this.btnEingabe.Name = "btnEingabe";
            this.btnEingabe.Size = new System.Drawing.Size(75, 26);
            this.btnEingabe.TabIndex = 15;
            this.btnEingabe.Text = "Eingabe";
            this.btnEingabe.UseVisualStyleBackColor = true;
            this.btnEingabe.Click += new System.EventHandler(this.btnEingabe_Click);
            // 
            // txtLoesung
            // 
            this.txtLoesung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoesung.Location = new System.Drawing.Point(80, 115);
            this.txtLoesung.Name = "txtLoesung";
            this.txtLoesung.Size = new System.Drawing.Size(253, 26);
            this.txtLoesung.TabIndex = 14;
            // 
            // txtGesucht
            // 
            this.txtGesucht.BackColor = System.Drawing.SystemColors.Control;
            this.txtGesucht.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGesucht.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGesucht.Location = new System.Drawing.Point(80, 78);
            this.txtGesucht.Name = "txtGesucht";
            this.txtGesucht.Size = new System.Drawing.Size(334, 31);
            this.txtGesucht.TabIndex = 13;
            // 
            // Form5
            // 
            this.AcceptButton = this.btnEingabe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 241);
            this.Controls.Add(this.lblFalschW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbDeutsch);
            this.Controls.Add(this.rdbEnglisch);
            this.Controls.Add(this.lblWortAnzahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAnzahl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFalsch);
            this.Controls.Add(this.btnEingabe);
            this.Controls.Add(this.txtLoesung);
            this.Controls.Add(this.txtGesucht);
            this.Name = "Form5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schreiben Alle Unit 4 Wörter";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFalschW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbDeutsch;
        private System.Windows.Forms.RadioButton rdbEnglisch;
        private System.Windows.Forms.Label lblWortAnzahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFalsch;
        private System.Windows.Forms.Button btnEingabe;
        private System.Windows.Forms.TextBox txtLoesung;
        private System.Windows.Forms.TextBox txtGesucht;
    }
}