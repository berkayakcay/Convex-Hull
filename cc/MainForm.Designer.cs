namespace cc
{
    partial class MainForm
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
            this.drawAreaPictureBox = new System.Windows.Forms.PictureBox();
            this.ch2Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.ch2NoFirstButton = new System.Windows.Forms.Button();
            this.pboxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawAreaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawAreaPictureBox
            // 
            this.drawAreaPictureBox.BackColor = System.Drawing.Color.White;
            this.drawAreaPictureBox.Location = new System.Drawing.Point(12, 12);
            this.drawAreaPictureBox.Name = "drawAreaPictureBox";
            this.drawAreaPictureBox.Size = new System.Drawing.Size(500, 500);
            this.drawAreaPictureBox.TabIndex = 0;
            this.drawAreaPictureBox.TabStop = false;
            this.drawAreaPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawAreaPictureBox_MouseMove);
            // 
            // ch2Button
            // 
            this.ch2Button.Location = new System.Drawing.Point(518, 441);
            this.ch2Button.Name = "ch2Button";
            this.ch2Button.Size = new System.Drawing.Size(156, 33);
            this.ch2Button.TabIndex = 1;
            this.ch2Button.Text = "Convex Hull";
            this.ch2Button.UseVisualStyleBackColor = true;
            this.ch2Button.Click += new System.EventHandler(this.ch2Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(518, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(162, 336);
            this.textBox1.TabIndex = 2;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(518, 402);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(156, 33);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate Points";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // ch2NoFirstButton
            // 
            this.ch2NoFirstButton.Location = new System.Drawing.Point(518, 480);
            this.ch2NoFirstButton.Name = "ch2NoFirstButton";
            this.ch2NoFirstButton.Size = new System.Drawing.Size(156, 33);
            this.ch2NoFirstButton.TabIndex = 4;
            this.ch2NoFirstButton.Text = "Remove 1st";
            this.ch2NoFirstButton.UseVisualStyleBackColor = true;
            this.ch2NoFirstButton.Click += new System.EventHandler(this.ch2NoFirstButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(518, 354);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "N/A";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ch2NoFirstButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ch2Button);
            this.Controls.Add(this.drawAreaPictureBox);
            this.Name = "MainForm";
            this.Text = "Convex Hull - Gift Wrapping - Berkay AKÇAY";
            ((System.ComponentModel.ISupportInitialize)(this.drawAreaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawAreaPictureBox;
        private System.Windows.Forms.Button ch2Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button ch2NoFirstButton;
        private System.Windows.Forms.ToolTip pboxToolTip;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}

