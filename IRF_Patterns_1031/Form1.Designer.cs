
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 425);
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
            this.buttonCAR.Location = new System.Drawing.Point(13, 460);
            this.buttonCAR.Name = "buttonCAR";
            this.buttonCAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCAR.TabIndex = 1;
            this.buttonCAR.Text = "CAR";
            this.buttonCAR.UseVisualStyleBackColor = true;
            this.buttonCAR.Click += new System.EventHandler(this.buttonCAR_Click);
            // 
            // buttonBALL
            // 
            this.buttonBALL.Location = new System.Drawing.Point(94, 460);
            this.buttonBALL.Name = "buttonBALL";
            this.buttonBALL.Size = new System.Drawing.Size(75, 23);
            this.buttonBALL.TabIndex = 2;
            this.buttonBALL.Text = "BALL";
            this.buttonBALL.UseVisualStyleBackColor = true;
            this.buttonBALL.Click += new System.EventHandler(this.buttonBALL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming next";
            // 
            // buttonCOLOR
            // 
            this.buttonCOLOR.BackColor = System.Drawing.Color.Green;
            this.buttonCOLOR.Location = new System.Drawing.Point(94, 489);
            this.buttonCOLOR.Name = "buttonCOLOR";
            this.buttonCOLOR.Size = new System.Drawing.Size(75, 23);
            this.buttonCOLOR.TabIndex = 4;
            this.buttonCOLOR.UseVisualStyleBackColor = false;
            this.buttonCOLOR.Click += new System.EventHandler(this.buttonCOLOR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.buttonCOLOR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBALL);
            this.Controls.Add(this.buttonCAR);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}

