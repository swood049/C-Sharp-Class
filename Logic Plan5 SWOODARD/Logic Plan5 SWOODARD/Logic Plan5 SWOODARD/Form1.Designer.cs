namespace Logic_Plan5_SWOODARD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.distanceListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Speed in MPH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours Traveled:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(150, 25);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 2;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(150, 52);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursTextBox.TabIndex = 3;
            // 
            // distanceListBox
            // 
            this.distanceListBox.FormattingEnabled = true;
            this.distanceListBox.Location = new System.Drawing.Point(29, 89);
            this.distanceListBox.Name = "distanceListBox";
            this.distanceListBox.Size = new System.Drawing.Size(230, 108);
            this.distanceListBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(329, 67);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.toolTip1.SetToolTip(this.calculateButton, "Calculate the total distance traveled");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(329, 130);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Close the program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 252);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.distanceListBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distance Calculator -SWOODARD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.ListBox distanceListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

