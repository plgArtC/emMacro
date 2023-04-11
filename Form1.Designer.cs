namespace emMacro
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
            this.components = new System.ComponentModel.Container();
            this.stateText = new System.Windows.Forms.Label();
            this.startStopButton = new System.Windows.Forms.Button();
            this.GenTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.IntoMacroKey = new System.Windows.Forms.TextBox();
            this.timeText = new System.Windows.Forms.Label();
            this.plusMin = new System.Windows.Forms.Button();
            this.decMin = new System.Windows.Forms.Button();
            this.SecPlus = new System.Windows.Forms.Button();
            this.decSec = new System.Windows.Forms.Button();
            this.DefaultBtn = new System.Windows.Forms.Button();
            this.DelayText = new System.Windows.Forms.Label();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stateText
            // 
            this.stateText.AutoSize = true;
            this.stateText.ForeColor = System.Drawing.SystemColors.Desktop;
            this.stateText.Location = new System.Drawing.Point(103, 174);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(31, 15);
            this.stateText.TabIndex = 0;
            this.stateText.Text = "false";
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(12, 6);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 35);
            this.startStopButton.TabIndex = 1;
            this.startStopButton.Text = "START";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // GenTimer
            // 
            this.GenTimer.Enabled = true;
            this.GenTimer.Interval = 50;
            this.GenTimer.Tick += new System.EventHandler(this.GenTimer_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // IntoMacroKey
            // 
            this.IntoMacroKey.Location = new System.Drawing.Point(103, 13);
            this.IntoMacroKey.Name = "IntoMacroKey";
            this.IntoMacroKey.Size = new System.Drawing.Size(46, 23);
            this.IntoMacroKey.TabIndex = 2;
            this.IntoMacroKey.TextChanged += new System.EventHandler(this.IntoMacroKey_TextChanged);
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.timeText.Location = new System.Drawing.Point(80, 118);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(45, 15);
            this.timeText.TabIndex = 4;
            this.timeText.Text = "Delay : ";
            // 
            // plusMin
            // 
            this.plusMin.Location = new System.Drawing.Point(58, 87);
            this.plusMin.Name = "plusMin";
            this.plusMin.Size = new System.Drawing.Size(57, 28);
            this.plusMin.TabIndex = 5;
            this.plusMin.Text = "+Min";
            this.plusMin.UseVisualStyleBackColor = true;
            this.plusMin.Click += new System.EventHandler(this.plusMin_Click);
            // 
            // decMin
            // 
            this.decMin.Location = new System.Drawing.Point(121, 87);
            this.decMin.Name = "decMin";
            this.decMin.Size = new System.Drawing.Size(57, 28);
            this.decMin.TabIndex = 6;
            this.decMin.Text = "-Min";
            this.decMin.UseVisualStyleBackColor = true;
            this.decMin.Click += new System.EventHandler(this.decMin_Click);
            // 
            // SecPlus
            // 
            this.SecPlus.Location = new System.Drawing.Point(58, 53);
            this.SecPlus.Name = "SecPlus";
            this.SecPlus.Size = new System.Drawing.Size(57, 28);
            this.SecPlus.TabIndex = 7;
            this.SecPlus.Text = "+Sec";
            this.SecPlus.UseVisualStyleBackColor = true;
            this.SecPlus.Click += new System.EventHandler(this.SecPlus_Click);
            // 
            // decSec
            // 
            this.decSec.Location = new System.Drawing.Point(121, 53);
            this.decSec.Name = "decSec";
            this.decSec.Size = new System.Drawing.Size(57, 28);
            this.decSec.TabIndex = 8;
            this.decSec.Text = "-Sec";
            this.decSec.UseVisualStyleBackColor = true;
            this.decSec.Click += new System.EventHandler(this.decSec_Click);
            // 
            // DefaultBtn
            // 
            this.DefaultBtn.Location = new System.Drawing.Point(80, 136);
            this.DefaultBtn.Name = "DefaultBtn";
            this.DefaultBtn.Size = new System.Drawing.Size(75, 23);
            this.DefaultBtn.TabIndex = 9;
            this.DefaultBtn.Text = "Default";
            this.DefaultBtn.UseVisualStyleBackColor = true;
            this.DefaultBtn.Click += new System.EventHandler(this.DefaultBtn_Click);
            // 
            // DelayText
            // 
            this.DelayText.AutoSize = true;
            this.DelayText.Location = new System.Drawing.Point(123, 118);
            this.DelayText.Name = "DelayText";
            this.DelayText.Size = new System.Drawing.Size(32, 15);
            this.DelayText.TabIndex = 10;
            this.DelayText.Text = "1 Sn.";
            // 
            // ClearBTN
            // 
            this.ClearBTN.Location = new System.Drawing.Point(155, 13);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(75, 23);
            this.ClearBTN.TabIndex = 11;
            this.ClearBTN.Text = "Clear";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 198);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.DelayText);
            this.Controls.Add(this.DefaultBtn);
            this.Controls.Add(this.decSec);
            this.Controls.Add(this.SecPlus);
            this.Controls.Add(this.decMin);
            this.Controls.Add(this.plusMin);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.IntoMacroKey);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.stateText);
            this.Name = "Form1";
            this.Text = "emMacro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label stateText;
        private Button startStopButton;
        private System.Windows.Forms.Timer GenTimer;
        private System.Windows.Forms.Timer timer2;
        private TextBox IntoMacroKey;
        private Label timeText;
        private Button plusMin;
        private Button decMin;
        private Button SecPlus;
        private Button decSec;
        private Button DefaultBtn;
        private Label DelayText;
        private Button ClearBTN;
    }
}