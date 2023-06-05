namespace ProgettoAI.Puzzle8.FormApp
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
            this.tile0Btn = new System.Windows.Forms.Button();
            this.tile3Btn = new System.Windows.Forms.Button();
            this.tile6Btn = new System.Windows.Forms.Button();
            this.tile1Btn = new System.Windows.Forms.Button();
            this.tile2Btn = new System.Windows.Forms.Button();
            this.tile4Btn = new System.Windows.Forms.Button();
            this.tile5Btn = new System.Windows.Forms.Button();
            this.tile8Btn = new System.Windows.Forms.Button();
            this.tile7Btn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stateTextBox = new System.Windows.Forms.RichTextBox();
            this.stepBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tile0Btn
            // 
            this.tile0Btn.Location = new System.Drawing.Point(40, 40);
            this.tile0Btn.Name = "tile0Btn";
            this.tile0Btn.Size = new System.Drawing.Size(80, 80);
            this.tile0Btn.TabIndex = 0;
            this.tile0Btn.UseVisualStyleBackColor = true;
            // 
            // tile3Btn
            // 
            this.tile3Btn.Location = new System.Drawing.Point(40, 140);
            this.tile3Btn.Name = "tile3Btn";
            this.tile3Btn.Size = new System.Drawing.Size(80, 80);
            this.tile3Btn.TabIndex = 1;
            this.tile3Btn.UseVisualStyleBackColor = true;
            // 
            // tile6Btn
            // 
            this.tile6Btn.Location = new System.Drawing.Point(40, 240);
            this.tile6Btn.Name = "tile6Btn";
            this.tile6Btn.Size = new System.Drawing.Size(80, 80);
            this.tile6Btn.TabIndex = 2;
            this.tile6Btn.UseVisualStyleBackColor = true;
            // 
            // tile1Btn
            // 
            this.tile1Btn.Location = new System.Drawing.Point(150, 40);
            this.tile1Btn.Name = "tile1Btn";
            this.tile1Btn.Size = new System.Drawing.Size(80, 80);
            this.tile1Btn.TabIndex = 3;
            this.tile1Btn.UseVisualStyleBackColor = true;
            // 
            // tile2Btn
            // 
            this.tile2Btn.Location = new System.Drawing.Point(260, 40);
            this.tile2Btn.Name = "tile2Btn";
            this.tile2Btn.Size = new System.Drawing.Size(80, 80);
            this.tile2Btn.TabIndex = 4;
            this.tile2Btn.UseVisualStyleBackColor = true;
            // 
            // tile4Btn
            // 
            this.tile4Btn.Location = new System.Drawing.Point(150, 140);
            this.tile4Btn.Name = "tile4Btn";
            this.tile4Btn.Size = new System.Drawing.Size(80, 80);
            this.tile4Btn.TabIndex = 5;
            this.tile4Btn.UseVisualStyleBackColor = true;
            // 
            // tile5Btn
            // 
            this.tile5Btn.Location = new System.Drawing.Point(260, 140);
            this.tile5Btn.Name = "tile5Btn";
            this.tile5Btn.Size = new System.Drawing.Size(80, 80);
            this.tile5Btn.TabIndex = 6;
            this.tile5Btn.UseVisualStyleBackColor = true;
            // 
            // tile8Btn
            // 
            this.tile8Btn.Location = new System.Drawing.Point(260, 240);
            this.tile8Btn.Name = "tile8Btn";
            this.tile8Btn.Size = new System.Drawing.Size(80, 80);
            this.tile8Btn.TabIndex = 7;
            this.tile8Btn.UseVisualStyleBackColor = true;
            // 
            // tile7Btn
            // 
            this.tile7Btn.Location = new System.Drawing.Point(150, 240);
            this.tile7Btn.Name = "tile7Btn";
            this.tile7Btn.Size = new System.Drawing.Size(80, 80);
            this.tile7Btn.TabIndex = 8;
            this.tile7Btn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(393, 268);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(194, 52);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(393, 54);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(194, 52);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(634, 40);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(216, 275);
            this.stateTextBox.TabIndex = 13;
            this.stateTextBox.Text = "";
            // 
            // stepBtn
            // 
            this.stepBtn.Enabled = false;
            this.stepBtn.Location = new System.Drawing.Point(393, 122);
            this.stepBtn.Name = "stepBtn";
            this.stepBtn.Size = new System.Drawing.Size(194, 52);
            this.stepBtn.TabIndex = 15;
            this.stepBtn.Text = "Step";
            this.stepBtn.UseVisualStyleBackColor = true;
            this.stepBtn.Click += new System.EventHandler(this.stepBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.stepBtn);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.tile7Btn);
            this.Controls.Add(this.tile8Btn);
            this.Controls.Add(this.tile5Btn);
            this.Controls.Add(this.tile4Btn);
            this.Controls.Add(this.tile2Btn);
            this.Controls.Add(this.tile1Btn);
            this.Controls.Add(this.tile6Btn);
            this.Controls.Add(this.tile3Btn);
            this.Controls.Add(this.tile0Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button tile0Btn;
        private Button tile3Btn;
        private Button tile6Btn;
        private Button tile1Btn;
        private Button tile2Btn;
        private Button tile4Btn;
        private Button tile5Btn;
        private Button tile8Btn;
        private Button tile7Btn;
        private Button resetBtn;
        private Button startBtn;
        private RichTextBox stateTextBox;
        private Button stepBtn;
    }
}