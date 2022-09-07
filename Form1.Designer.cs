namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panEnterWord = new System.Windows.Forms.Panel();
            this.confirmWord = new System.Windows.Forms.Button();
            this.setWord = new System.Windows.Forms.TextBox();
            this.lbWord = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTestLetter = new System.Windows.Forms.Button();
            this.tbGuessLetter = new System.Windows.Forms.TextBox();
            this.instruLetter = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbGuessWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestWord = new System.Windows.Forms.Button();
            this.labLives = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.panEnterWord.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panEnterWord
            // 
            this.panEnterWord.Controls.Add(this.confirmWord);
            this.panEnterWord.Controls.Add(this.setWord);
            this.panEnterWord.Location = new System.Drawing.Point(182, 310);
            this.panEnterWord.Name = "panEnterWord";
            this.panEnterWord.Size = new System.Drawing.Size(200, 55);
            this.panEnterWord.TabIndex = 0;
            // 
            // confirmWord
            // 
            this.confirmWord.Location = new System.Drawing.Point(62, 32);
            this.confirmWord.Name = "confirmWord";
            this.confirmWord.Size = new System.Drawing.Size(75, 23);
            this.confirmWord.TabIndex = 1;
            this.confirmWord.Text = "Confirm";
            this.confirmWord.UseVisualStyleBackColor = true;
            this.confirmWord.Click += new System.EventHandler(this.confirmWord_Click);
            // 
            // setWord
            // 
            this.setWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.setWord.Location = new System.Drawing.Point(0, 0);
            this.setWord.Name = "setWord";
            this.setWord.Size = new System.Drawing.Size(200, 20);
            this.setWord.TabIndex = 0;
            this.setWord.Text = "Enter Word Here";
            // 
            // lbWord
            // 
            this.lbWord.FormattingEnabled = true;
            this.lbWord.Location = new System.Drawing.Point(182, 67);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(200, 212);
            this.lbWord.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(311, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(62, 13);
            this.title.TabIndex = 2;
            this.title.Text = "HANGMAN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHint);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(466, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 283);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labLives);
            this.panel2.Controls.Add(this.btnTestLetter);
            this.panel2.Controls.Add(this.tbGuessLetter);
            this.panel2.Controls.Add(this.instruLetter);
            this.panel2.Location = new System.Drawing.Point(0, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 7;
            // 
            // btnTestLetter
            // 
            this.btnTestLetter.Location = new System.Drawing.Point(48, 58);
            this.btnTestLetter.Name = "btnTestLetter";
            this.btnTestLetter.Size = new System.Drawing.Size(102, 23);
            this.btnTestLetter.TabIndex = 5;
            this.btnTestLetter.Text = "Confirm Letter";
            this.btnTestLetter.UseVisualStyleBackColor = true;
            this.btnTestLetter.Click += new System.EventHandler(this.btnTestLetter_Click);
            // 
            // tbGuessLetter
            // 
            this.tbGuessLetter.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbGuessLetter.Location = new System.Drawing.Point(0, 13);
            this.tbGuessLetter.Name = "tbGuessLetter";
            this.tbGuessLetter.Size = new System.Drawing.Size(200, 20);
            this.tbGuessLetter.TabIndex = 4;
            // 
            // instruLetter
            // 
            this.instruLetter.AutoSize = true;
            this.instruLetter.Dock = System.Windows.Forms.DockStyle.Top;
            this.instruLetter.Location = new System.Drawing.Point(0, 0);
            this.instruLetter.Name = "instruLetter";
            this.instruLetter.Size = new System.Drawing.Size(90, 13);
            this.instruLetter.TabIndex = 3;
            this.instruLetter.Text = "Guess One Letter";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTestWord);
            this.panel3.Controls.Add(this.tbGuessWord);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 9;
            // 
            // tbGuessWord
            // 
            this.tbGuessWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbGuessWord.Location = new System.Drawing.Point(0, 13);
            this.tbGuessWord.Name = "tbGuessWord";
            this.tbGuessWord.Size = new System.Drawing.Size(200, 20);
            this.tbGuessWord.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Guess The Word";
            // 
            // btnTestWord
            // 
            this.btnTestWord.Location = new System.Drawing.Point(48, 53);
            this.btnTestWord.Name = "btnTestWord";
            this.btnTestWord.Size = new System.Drawing.Size(102, 23);
            this.btnTestWord.TabIndex = 7;
            this.btnTestWord.Text = "Confirm Word";
            this.btnTestWord.UseVisualStyleBackColor = true;
            this.btnTestWord.Click += new System.EventHandler(this.btnTestWord_Click);
            // 
            // labLives
            // 
            this.labLives.AutoSize = true;
            this.labLives.Location = new System.Drawing.Point(83, 40);
            this.labLives.Name = "labLives";
            this.labLives.Size = new System.Drawing.Size(35, 13);
            this.labLives.TabIndex = 6;
            this.labLives.Text = "label2";
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(63, 240);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(75, 23);
            this.btnHint.TabIndex = 10;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.panEnterWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panEnterWord.ResumeLayout(false);
            this.panEnterWord.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panEnterWord;
        private System.Windows.Forms.Button confirmWord;
        private System.Windows.Forms.TextBox setWord;
        private System.Windows.Forms.ListBox lbWord;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTestWord;
        private System.Windows.Forms.TextBox tbGuessWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTestLetter;
        private System.Windows.Forms.TextBox tbGuessLetter;
        private System.Windows.Forms.Label instruLetter;
        private System.Windows.Forms.Label labLives;
        private System.Windows.Forms.Button btnHint;
    }
}

