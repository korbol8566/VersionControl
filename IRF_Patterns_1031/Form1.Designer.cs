
namespace IRF_Patterns_1031
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonCAR = new System.Windows.Forms.Button();
            this.buttonBALL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCOLOR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 523);
            this.panel1.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // buttonCAR
            // 
            this.buttonCAR.Location = new System.Drawing.Point(17, 566);
            this.buttonCAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCAR.Name = "buttonCAR";
            this.buttonCAR.Size = new System.Drawing.Size(100, 28);
            this.buttonCAR.TabIndex = 1;
            this.buttonCAR.Text = "CAR";
            this.buttonCAR.UseVisualStyleBackColor = true;
            this.buttonCAR.Click += new System.EventHandler(this.buttonCAR_Click);
            // 
            // buttonBALL
            // 
            this.buttonBALL.Location = new System.Drawing.Point(125, 566);
            this.buttonBALL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBALL.Name = "buttonBALL";
            this.buttonBALL.Size = new System.Drawing.Size(100, 28);
            this.buttonBALL.TabIndex = 2;
            this.buttonBALL.Text = "BALL";
            this.buttonBALL.UseVisualStyleBackColor = true;
            this.buttonBALL.Click += new System.EventHandler(this.buttonBALL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 572);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming next";
            // 
            // buttonCOLOR
            // 
            this.buttonCOLOR.BackColor = System.Drawing.Color.Green;
            this.buttonCOLOR.Location = new System.Drawing.Point(125, 602);
            this.buttonCOLOR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCOLOR.Name = "buttonCOLOR";
            this.buttonCOLOR.Size = new System.Drawing.Size(100, 28);
            this.buttonCOLOR.TabIndex = 4;
            this.buttonCOLOR.UseVisualStyleBackColor = false;
            this.buttonCOLOR.Click += new System.EventHandler(this.buttonCOLOR_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 566);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "GIFT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCOLOR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBALL);
            this.Controls.Add(this.buttonCAR);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button buttonCAR;
        private System.Windows.Forms.Button buttonBALL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCOLOR;
        private System.Windows.Forms.Button button1;
    }
}

