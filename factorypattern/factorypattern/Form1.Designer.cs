namespace factorypattern
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblNext = new System.Windows.Forms.Label();
            this.ballselectBTN = new System.Windows.Forms.Button();
            this.carselectBTN = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 203);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(709, 235);
            this.mainPanel.TabIndex = 0;
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(215, 12);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(68, 13);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            // 
            // ballselectBTN
            // 
            this.ballselectBTN.Location = new System.Drawing.Point(108, 12);
            this.ballselectBTN.Name = "ballselectBTN";
            this.ballselectBTN.Size = new System.Drawing.Size(75, 41);
            this.ballselectBTN.TabIndex = 1;
            this.ballselectBTN.Text = "Ball";
            this.ballselectBTN.UseVisualStyleBackColor = true;
            this.ballselectBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // carselectBTN
            // 
            this.carselectBTN.Location = new System.Drawing.Point(12, 12);
            this.carselectBTN.Name = "carselectBTN";
            this.carselectBTN.Size = new System.Drawing.Size(75, 41);
            this.carselectBTN.TabIndex = 0;
            this.carselectBTN.Text = "Car";
            this.carselectBTN.UseVisualStyleBackColor = true;
            this.carselectBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTime
            // 
            this.conveyorTime.Enabled = true;
            this.conveyorTime.Interval = 10;
            this.conveyorTime.Tick += new System.EventHandler(this.conveyorTime_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 18);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.ballselectBTN);
            this.Controls.Add(this.carselectBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTime;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button ballselectBTN;
        private System.Windows.Forms.Button carselectBTN;
        private System.Windows.Forms.Button button1;
    }
}

