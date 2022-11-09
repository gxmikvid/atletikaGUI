namespace atletikaGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.OrszagokListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.szamokListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.versenyszamNUD = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nevLabel = new System.Windows.Forms.Label();
            this.eredmenyLabel = new System.Windows.Forms.Label();
            this.nemzetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.versenyszamNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranyérmet szerzett nemzetek:";
            // 
            // OrszagokListBox
            // 
            this.OrszagokListBox.FormattingEnabled = true;
            this.OrszagokListBox.Location = new System.Drawing.Point(16, 34);
            this.OrszagokListBox.Name = "OrszagokListBox";
            this.OrszagokListBox.Size = new System.Drawing.Size(265, 524);
            this.OrszagokListBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(16, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "aranyos - nemzetek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(353, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Válassza ki a versenyszámot:";
            // 
            // szamokListBox
            // 
            this.szamokListBox.FormattingEnabled = true;
            this.szamokListBox.Location = new System.Drawing.Point(356, 34);
            this.szamokListBox.Name = "szamokListBox";
            this.szamokListBox.Size = new System.Drawing.Size(250, 121);
            this.szamokListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(353, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Válassza ki a versenyszámot:";
            // 
            // versenyszamNUD
            // 
            this.versenyszamNUD.Location = new System.Drawing.Point(356, 238);
            this.versenyszamNUD.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.versenyszamNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.versenyszamNUD.Name = "versenyszamNUD";
            this.versenyszamNUD.Size = new System.Drawing.Size(46, 20);
            this.versenyszamNUD.TabIndex = 6;
            this.versenyszamNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(406, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Keresés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(353, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Versenyző adatai:";
            // 
            // nevLabel
            // 
            this.nevLabel.AutoSize = true;
            this.nevLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nevLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.nevLabel.Location = new System.Drawing.Point(403, 443);
            this.nevLabel.Name = "nevLabel";
            this.nevLabel.Size = new System.Drawing.Size(54, 18);
            this.nevLabel.TabIndex = 9;
            this.nevLabel.Text = "neve:";
            // 
            // eredmenyLabel
            // 
            this.eredmenyLabel.AutoSize = true;
            this.eredmenyLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eredmenyLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.eredmenyLabel.Location = new System.Drawing.Point(352, 494);
            this.eredmenyLabel.Name = "eredmenyLabel";
            this.eredmenyLabel.Size = new System.Drawing.Size(105, 18);
            this.eredmenyLabel.TabIndex = 10;
            this.eredmenyLabel.Text = "eredménye:";
            // 
            // nemzetLabel
            // 
            this.nemzetLabel.AutoSize = true;
            this.nemzetLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nemzetLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.nemzetLabel.Location = new System.Drawing.Point(371, 548);
            this.nemzetLabel.Name = "nemzetLabel";
            this.nemzetLabel.Size = new System.Drawing.Size(86, 18);
            this.nemzetLabel.TabIndex = 11;
            this.nemzetLabel.Text = "nemzete:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.nemzetLabel);
            this.Controls.Add(this.eredmenyLabel);
            this.Controls.Add(this.nevLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.versenyszamNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.szamokListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrszagokListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.versenyszamNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox OrszagokListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox szamokListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown versenyszamNUD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nevLabel;
        private System.Windows.Forms.Label eredmenyLabel;
        private System.Windows.Forms.Label nemzetLabel;
    }
}

