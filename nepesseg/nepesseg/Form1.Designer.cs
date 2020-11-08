namespace nepesseg
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
            this.csvpathtxt = new System.Windows.Forms.TextBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zaroev = new System.Windows.Forms.NumericUpDown();
            this.eredmenytxt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.zaroev)).BeginInit();
            this.SuspendLayout();
            // 
            // csvpathtxt
            // 
            this.csvpathtxt.Location = new System.Drawing.Point(262, 8);
            this.csvpathtxt.Margin = new System.Windows.Forms.Padding(2);
            this.csvpathtxt.Multiline = true;
            this.csvpathtxt.Name = "csvpathtxt";
            this.csvpathtxt.Size = new System.Drawing.Size(123, 56);
            this.csvpathtxt.TabIndex = 13;
            // 
            // browsebtn
            // 
            this.browsebtn.Location = new System.Drawing.Point(389, 10);
            this.browsebtn.Margin = new System.Windows.Forms.Padding(2);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(93, 54);
            this.browsebtn.TabIndex = 12;
            this.browsebtn.Text = "Browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(487, 8);
            this.startbtn.Margin = new System.Windows.Forms.Padding(2);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(95, 55);
            this.startbtn.TabIndex = 10;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(178, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Population file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "End year";
            // 
            // zaroev
            // 
            this.zaroev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaroev.Location = new System.Drawing.Point(11, 45);
            this.zaroev.Margin = new System.Windows.Forms.Padding(2);
            this.zaroev.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.zaroev.Name = "zaroev";
            this.zaroev.Size = new System.Drawing.Size(154, 19);
            this.zaroev.TabIndex = 7;
            this.zaroev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zaroev.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // eredmenytxt
            // 
            this.eredmenytxt.Location = new System.Drawing.Point(11, 69);
            this.eredmenytxt.Name = "eredmenytxt";
            this.eredmenytxt.Size = new System.Drawing.Size(571, 344);
            this.eredmenytxt.TabIndex = 14;
            this.eredmenytxt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 425);
            this.Controls.Add(this.eredmenytxt);
            this.Controls.Add(this.csvpathtxt);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zaroev);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.zaroev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox csvpathtxt;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown zaroev;
        private System.Windows.Forms.RichTextBox eredmenytxt;
    }
}

