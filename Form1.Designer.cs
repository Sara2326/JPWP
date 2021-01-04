
namespace JPWP
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Letter1 = new System.Windows.Forms.Label();
            this.Letter2 = new System.Windows.Forms.Label();
            this.Letter3 = new System.Windows.Forms.Label();
            this.Letter4 = new System.Windows.Forms.Label();
            this.Letter5 = new System.Windows.Forms.Label();
            this.Letter6 = new System.Windows.Forms.Label();
            this.LetterDisplay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(517, 64);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 20);
            this.Input.TabIndex = 2;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Letter1
            // 
            this.Letter1.AutoSize = true;
            this.Letter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter1.Location = new System.Drawing.Point(226, 266);
            this.Letter1.Name = "Letter1";
            this.Letter1.Size = new System.Drawing.Size(16, 24);
            this.Letter1.TabIndex = 3;
            this.Letter1.Text = "-";
            this.Letter1.Click += new System.EventHandler(this.Letter1_Click);
            // 
            // Letter2
            // 
            this.Letter2.AutoSize = true;
            this.Letter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter2.Location = new System.Drawing.Point(255, 266);
            this.Letter2.Name = "Letter2";
            this.Letter2.Size = new System.Drawing.Size(16, 24);
            this.Letter2.TabIndex = 4;
            this.Letter2.Text = "-";
            this.Letter2.Click += new System.EventHandler(this.Letter2_Click);
            // 
            // Letter3
            // 
            this.Letter3.AutoSize = true;
            this.Letter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter3.Location = new System.Drawing.Point(284, 266);
            this.Letter3.Name = "Letter3";
            this.Letter3.Size = new System.Drawing.Size(16, 24);
            this.Letter3.TabIndex = 5;
            this.Letter3.Text = "-";
            this.Letter3.Click += new System.EventHandler(this.Letter3_Click);
            // 
            // Letter4
            // 
            this.Letter4.AutoSize = true;
            this.Letter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter4.Location = new System.Drawing.Point(313, 266);
            this.Letter4.Name = "Letter4";
            this.Letter4.Size = new System.Drawing.Size(16, 24);
            this.Letter4.TabIndex = 6;
            this.Letter4.Text = "-";
            this.Letter4.Click += new System.EventHandler(this.Letter4_Click);
            // 
            // Letter5
            // 
            this.Letter5.AutoSize = true;
            this.Letter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter5.Location = new System.Drawing.Point(342, 266);
            this.Letter5.Name = "Letter5";
            this.Letter5.Size = new System.Drawing.Size(16, 24);
            this.Letter5.TabIndex = 7;
            this.Letter5.Text = "-";
            this.Letter5.Click += new System.EventHandler(this.Letter5_Click);
            // 
            // Letter6
            // 
            this.Letter6.AutoSize = true;
            this.Letter6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter6.Location = new System.Drawing.Point(371, 266);
            this.Letter6.Name = "Letter6";
            this.Letter6.Size = new System.Drawing.Size(16, 24);
            this.Letter6.TabIndex = 8;
            this.Letter6.Text = "-";
            this.Letter6.Click += new System.EventHandler(this.Letter6_Click);
            // 
            // LetterDisplay
            // 
            this.LetterDisplay.AutoSize = true;
            this.LetterDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LetterDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LetterDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LetterDisplay.Location = new System.Drawing.Point(159, 49);
            this.LetterDisplay.Name = "LetterDisplay";
            this.LetterDisplay.Size = new System.Drawing.Size(0, 24);
            this.LetterDisplay.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(517, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 279);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LetterDisplay);
            this.Controls.Add(this.Letter6);
            this.Controls.Add(this.Letter5);
            this.Controls.Add(this.Letter4);
            this.Controls.Add(this.Letter3);
            this.Controls.Add(this.Letter2);
            this.Controls.Add(this.Letter1);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label Letter1;
        private System.Windows.Forms.Label Letter2;
        private System.Windows.Forms.Label Letter3;
        private System.Windows.Forms.Label Letter4;
        private System.Windows.Forms.Label Letter5;
        private System.Windows.Forms.Label Letter6;
        private System.Windows.Forms.Label LetterDisplay;
        private System.Windows.Forms.Panel panel1;
    }
}

