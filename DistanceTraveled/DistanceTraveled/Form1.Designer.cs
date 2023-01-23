
namespace DistanceTraveled
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
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.fiveHourButton = new System.Windows.Forms.Button();
            this.twelveHourButton = new System.Windows.Forms.Button();
            this.eightHourButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate how far you traveled after entering speed";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(92, 59);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(125, 13);
            this.speedLabel.TabIndex = 1;
            this.speedLabel.Text = "Enter your speed in MPH";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(106, 84);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 2;
            // 
            // fiveHourButton
            // 
            this.fiveHourButton.Location = new System.Drawing.Point(26, 125);
            this.fiveHourButton.Name = "fiveHourButton";
            this.fiveHourButton.Size = new System.Drawing.Size(75, 23);
            this.fiveHourButton.TabIndex = 3;
            this.fiveHourButton.Text = "5 Hours";
            this.fiveHourButton.UseVisualStyleBackColor = true;
            this.fiveHourButton.Click += new System.EventHandler(this.fiveHourButton_Click);
            // 
            // twelveHourButton
            // 
            this.twelveHourButton.Location = new System.Drawing.Point(223, 125);
            this.twelveHourButton.Name = "twelveHourButton";
            this.twelveHourButton.Size = new System.Drawing.Size(75, 23);
            this.twelveHourButton.TabIndex = 4;
            this.twelveHourButton.Text = "12 Hours";
            this.twelveHourButton.UseVisualStyleBackColor = true;
            this.twelveHourButton.Click += new System.EventHandler(this.twelveHourButton_Click);
            // 
            // eightHourButton
            // 
            this.eightHourButton.Location = new System.Drawing.Point(123, 125);
            this.eightHourButton.Name = "eightHourButton";
            this.eightHourButton.Size = new System.Drawing.Size(75, 23);
            this.eightHourButton.TabIndex = 5;
            this.eightHourButton.Text = "8 Hours";
            this.eightHourButton.UseVisualStyleBackColor = true;
            this.eightHourButton.Click += new System.EventHandler(this.eightHourButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(66, 197);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(168, 197);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 258);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.eightHourButton);
            this.Controls.Add(this.twelveHourButton);
            this.Controls.Add(this.fiveHourButton);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distance Traveled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Button fiveHourButton;
        private System.Windows.Forms.Button twelveHourButton;
        private System.Windows.Forms.Button eightHourButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

