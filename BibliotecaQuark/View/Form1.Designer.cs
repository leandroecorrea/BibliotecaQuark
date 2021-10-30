
namespace BibliotecaQuark
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewLoan = new System.Windows.Forms.Button();
            this.btnSeeLoans = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.btnLoadBook = new System.Windows.Forms.Button();
            this.btnSeeCopies = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 142);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Linux Biolinum G", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca Quark";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewLoan
            // 
            this.btnNewLoan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewLoan.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewLoan.Location = new System.Drawing.Point(12, 298);
            this.btnNewLoan.Name = "btnNewLoan";
            this.btnNewLoan.Size = new System.Drawing.Size(186, 80);
            this.btnNewLoan.TabIndex = 1;
            this.btnNewLoan.Text = "Nuevo préstamo";
            this.btnNewLoan.UseVisualStyleBackColor = false;
            this.btnNewLoan.Click += new System.EventHandler(this.btnNewLoan_Click);
            // 
            // btnSeeLoans
            // 
            this.btnSeeLoans.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeeLoans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeeLoans.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeLoans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeeLoans.Location = new System.Drawing.Point(229, 298);
            this.btnSeeLoans.Name = "btnSeeLoans";
            this.btnSeeLoans.Size = new System.Drawing.Size(186, 80);
            this.btnSeeLoans.TabIndex = 2;
            this.btnSeeLoans.Text = "Consultar préstamos";
            this.btnSeeLoans.UseVisualStyleBackColor = false;
            this.btnSeeLoans.Click += new System.EventHandler(this.btnSeeLoans_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturnBook.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnBook.Location = new System.Drawing.Point(12, 423);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(186, 80);
            this.btnReturnBook.TabIndex = 3;
            this.btnReturnBook.Text = "Devolver libro";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateMember.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateMember.Location = new System.Drawing.Point(12, 178);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(186, 80);
            this.btnCreateMember.TabIndex = 4;
            this.btnCreateMember.Text = "Cargar Socio";
            this.btnCreateMember.UseVisualStyleBackColor = false;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // btnLoadBook
            // 
            this.btnLoadBook.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoadBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoadBook.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadBook.Location = new System.Drawing.Point(229, 178);
            this.btnLoadBook.Name = "btnLoadBook";
            this.btnLoadBook.Size = new System.Drawing.Size(186, 80);
            this.btnLoadBook.TabIndex = 5;
            this.btnLoadBook.Text = "Cargar ejemplar";
            this.btnLoadBook.UseVisualStyleBackColor = false;
            this.btnLoadBook.Click += new System.EventHandler(this.btnLoadBook_Click);
            // 
            // btnSeeCopies
            // 
            this.btnSeeCopies.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeeCopies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeeCopies.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeCopies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeeCopies.Location = new System.Drawing.Point(229, 423);
            this.btnSeeCopies.Name = "btnSeeCopies";
            this.btnSeeCopies.Size = new System.Drawing.Size(186, 80);
            this.btnSeeCopies.TabIndex = 6;
            this.btnSeeCopies.Text = "Consultar ejemplares";
            this.btnSeeCopies.UseVisualStyleBackColor = false;
            this.btnSeeCopies.Click += new System.EventHandler(this.btnSeeCopies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(427, 544);
            this.Controls.Add(this.btnSeeCopies);
            this.Controls.Add(this.btnLoadBook);
            this.Controls.Add(this.btnCreateMember);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnSeeLoans);
            this.Controls.Add(this.btnNewLoan);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewLoan;
        private System.Windows.Forms.Button btnSeeLoans;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.Button btnLoadBook;
        private System.Windows.Forms.Button btnSeeCopies;
    }
}

