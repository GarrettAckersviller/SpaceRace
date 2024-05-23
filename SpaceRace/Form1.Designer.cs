namespace SpaceRace
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
            this.spaceTimer = new System.Windows.Forms.Timer(this.components);
            this.tLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // spaceTimer
            // 
            this.spaceTimer.Interval = 14;
            this.spaceTimer.Tick += new System.EventHandler(this.spaceTimer_Tick_1);
            // 
            // tLabel
            // 
            this.tLabel.AutoSize = true;
            this.tLabel.BackColor = System.Drawing.Color.Transparent;
            this.tLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tLabel.Location = new System.Drawing.Point(43, 9);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(24, 20);
            this.tLabel.TabIndex = 1;
            this.tLabel.Text = "...";
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.BackColor = System.Drawing.Color.Transparent;
            this.sLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sLabel.Location = new System.Drawing.Point(582, 9);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(24, 20);
            this.sLabel.TabIndex = 3;
            this.sLabel.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Black;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startLabel.Location = new System.Drawing.Point(218, 178);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(205, 24);
            this.startLabel.TabIndex = 5;
            this.startLabel.Text = "Press Space To Start";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(672, 382);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.tLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer spaceraceTimer;
        private System.Windows.Forms.Timer spaceTimer;
        private System.Windows.Forms.Label tLabel;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startLabel;
    }
}

