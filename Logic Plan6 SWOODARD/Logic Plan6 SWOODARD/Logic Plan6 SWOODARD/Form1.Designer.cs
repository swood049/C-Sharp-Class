namespace Logic_Plan6_SWOODARD
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
            this.retailPriceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.wholesaleTextBox = new System.Windows.Forms.TextBox();
            this.markupPercentTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wholesale Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Markup Percentage(%):";
            // 
            // retailPriceTextBox
            // 
            this.retailPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.retailPriceTextBox.Location = new System.Drawing.Point(38, 177);
            this.retailPriceTextBox.Name = "retailPriceTextBox";
            this.retailPriceTextBox.ReadOnly = true;
            this.retailPriceTextBox.Size = new System.Drawing.Size(181, 32);
            this.retailPriceTextBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.calculateButton.Location = new System.Drawing.Point(309, 140);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(98, 46);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.toolTip1.SetToolTip(this.calculateButton, "Calculate retail price");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button2.Location = new System.Drawing.Point(309, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.toolTip1.SetToolTip(this.button2, "Close the program");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wholesaleTextBox
            // 
            this.wholesaleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.wholesaleTextBox.Location = new System.Drawing.Point(259, 32);
            this.wholesaleTextBox.Name = "wholesaleTextBox";
            this.wholesaleTextBox.Size = new System.Drawing.Size(100, 32);
            this.wholesaleTextBox.TabIndex = 5;
            // 
            // markupPercentTextBox
            // 
            this.markupPercentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.markupPercentTextBox.Location = new System.Drawing.Point(259, 83);
            this.markupPercentTextBox.Name = "markupPercentTextBox";
            this.markupPercentTextBox.Size = new System.Drawing.Size(100, 32);
            this.markupPercentTextBox.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.clearButton.Location = new System.Drawing.Point(106, 226);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(98, 42);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.toolTip1.SetToolTip(this.clearButton, "Clear all fields");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 318);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.markupPercentTextBox);
            this.Controls.Add(this.wholesaleTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.retailPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Retail Price SWOODARD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox retailPriceTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox wholesaleTextBox;
        private System.Windows.Forms.TextBox markupPercentTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button clearButton;
    }
}

