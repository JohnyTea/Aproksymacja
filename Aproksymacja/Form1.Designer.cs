namespace Aproksymacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.x_textBox = new System.Windows.Forms.TextBox();
            this.y_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopien1_RB = new System.Windows.Forms.RadioButton();
            this.stopien2_RB = new System.Windows.Forms.RadioButton();
            this.stopien3_RB = new System.Windows.Forms.RadioButton();
            this.szukanyx_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wynik_TextBox = new System.Windows.Forms.TextBox();
            this.licz_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x_textBox
            // 
            this.x_textBox.Location = new System.Drawing.Point(12, 33);
            this.x_textBox.Name = "x_textBox";
            this.x_textBox.Size = new System.Drawing.Size(287, 20);
            this.x_textBox.TabIndex = 0;
            this.x_textBox.Text = "1,05 1,95 2,1 3,5 4,05";
            // 
            // y_TextBox
            // 
            this.y_TextBox.Location = new System.Drawing.Point(12, 86);
            this.y_TextBox.Name = "y_TextBox";
            this.y_TextBox.Size = new System.Drawing.Size(287, 20);
            this.y_TextBox.TabIndex = 1;
            this.y_TextBox.Text = "-0,15 1 2 3,2 4,4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "y:";
            // 
            // stopien1_RB
            // 
            this.stopien1_RB.AutoSize = true;
            this.stopien1_RB.Location = new System.Drawing.Point(305, 33);
            this.stopien1_RB.Name = "stopien1_RB";
            this.stopien1_RB.Size = new System.Drawing.Size(68, 17);
            this.stopien1_RB.TabIndex = 4;
            this.stopien1_RB.TabStop = true;
            this.stopien1_RB.Text = "stopień 1";
            this.stopien1_RB.UseVisualStyleBackColor = true;
            // 
            // stopien2_RB
            // 
            this.stopien2_RB.AutoSize = true;
            this.stopien2_RB.Location = new System.Drawing.Point(305, 56);
            this.stopien2_RB.Name = "stopien2_RB";
            this.stopien2_RB.Size = new System.Drawing.Size(68, 17);
            this.stopien2_RB.TabIndex = 5;
            this.stopien2_RB.TabStop = true;
            this.stopien2_RB.Text = "stopień 2";
            this.stopien2_RB.UseVisualStyleBackColor = true;
            // 
            // stopien3_RB
            // 
            this.stopien3_RB.AutoSize = true;
            this.stopien3_RB.Location = new System.Drawing.Point(305, 79);
            this.stopien3_RB.Name = "stopien3_RB";
            this.stopien3_RB.Size = new System.Drawing.Size(68, 17);
            this.stopien3_RB.TabIndex = 6;
            this.stopien3_RB.TabStop = true;
            this.stopien3_RB.Text = "stopień 3";
            this.stopien3_RB.UseVisualStyleBackColor = true;
            // 
            // szukanyx_TextBox
            // 
            this.szukanyx_TextBox.Location = new System.Drawing.Point(12, 135);
            this.szukanyx_TextBox.Name = "szukanyx_TextBox";
            this.szukanyx_TextBox.Size = new System.Drawing.Size(76, 20);
            this.szukanyx_TextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Szukany x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wynik:";
            // 
            // wynik_TextBox
            // 
            this.wynik_TextBox.Location = new System.Drawing.Point(12, 174);
            this.wynik_TextBox.Name = "wynik_TextBox";
            this.wynik_TextBox.Size = new System.Drawing.Size(76, 20);
            this.wynik_TextBox.TabIndex = 9;
            // 
            // licz_button
            // 
            this.licz_button.Location = new System.Drawing.Point(94, 119);
            this.licz_button.Name = "licz_button";
            this.licz_button.Size = new System.Drawing.Size(205, 75);
            this.licz_button.TabIndex = 11;
            this.licz_button.Text = "Licz To!";
            this.licz_button.UseVisualStyleBackColor = true;
            this.licz_button.Click += new System.EventHandler(this.licz_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 205);
            this.Controls.Add(this.licz_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wynik_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.szukanyx_TextBox);
            this.Controls.Add(this.stopien3_RB);
            this.Controls.Add(this.stopien2_RB);
            this.Controls.Add(this.stopien1_RB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y_TextBox);
            this.Controls.Add(this.x_textBox);
            this.Name = "Form1";
            this.Text = "Aproksymacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x_textBox;
        private System.Windows.Forms.TextBox y_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton stopien1_RB;
        private System.Windows.Forms.RadioButton stopien2_RB;
        private System.Windows.Forms.RadioButton stopien3_RB;
        private System.Windows.Forms.TextBox szukanyx_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wynik_TextBox;
        private System.Windows.Forms.Button licz_button;
    }
}

