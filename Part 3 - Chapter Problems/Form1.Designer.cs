namespace Part_3___Chapter_Problems
{
    partial class BasicInput
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNameVariable = new System.Windows.Forms.Label();
            this.lblAgeVariable = new System.Windows.Forms.Label();
            this.lblHeightVariable = new System.Windows.Forms.Label();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.txtAgeInput = new System.Windows.Forms.TextBox();
            this.txtHeightInput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(112, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(126, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the program!";
            // 
            // lblNameVariable
            // 
            this.lblNameVariable.AutoSize = true;
            this.lblNameVariable.Location = new System.Drawing.Point(12, 39);
            this.lblNameVariable.Name = "lblNameVariable";
            this.lblNameVariable.Size = new System.Drawing.Size(84, 13);
            this.lblNameVariable.TabIndex = 1;
            this.lblNameVariable.Text = "Enter you name:";
            // 
            // lblAgeVariable
            // 
            this.lblAgeVariable.AutoSize = true;
            this.lblAgeVariable.Location = new System.Drawing.Point(12, 73);
            this.lblAgeVariable.Name = "lblAgeVariable";
            this.lblAgeVariable.Size = new System.Drawing.Size(79, 13);
            this.lblAgeVariable.TabIndex = 2;
            this.lblAgeVariable.Text = "Enter your age:";
            // 
            // lblHeightVariable
            // 
            this.lblHeightVariable.AutoSize = true;
            this.lblHeightVariable.Location = new System.Drawing.Point(12, 105);
            this.lblHeightVariable.Name = "lblHeightVariable";
            this.lblHeightVariable.Size = new System.Drawing.Size(111, 13);
            this.lblHeightVariable.TabIndex = 3;
            this.lblHeightVariable.Text = "Enter your height (M) :";
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(124, 36);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(193, 20);
            this.txtNameInput.TabIndex = 4;
            this.txtNameInput.TextChanged += new System.EventHandler(this.txtNameInput_TextChanged);
            // 
            // txtAgeInput
            // 
            this.txtAgeInput.Location = new System.Drawing.Point(124, 70);
            this.txtAgeInput.Name = "txtAgeInput";
            this.txtAgeInput.Size = new System.Drawing.Size(193, 20);
            this.txtAgeInput.TabIndex = 5;
            this.txtAgeInput.TextChanged += new System.EventHandler(this.txtAgeInput_TextChanged);
            // 
            // txtHeightInput
            // 
            this.txtHeightInput.Location = new System.Drawing.Point(124, 102);
            this.txtHeightInput.Name = "txtHeightInput";
            this.txtHeightInput.Size = new System.Drawing.Size(193, 20);
            this.txtHeightInput.TabIndex = 6;
            this.txtHeightInput.TextChanged += new System.EventHandler(this.txtHeightInput_TextChanged);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(61, 128);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(256, 23);
            this.btnOutput.TabIndex = 7;
            this.btnOutput.Text = "Click Here For Results";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(-2, 154);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(368, 81);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BasicInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 235);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtHeightInput);
            this.Controls.Add(this.txtAgeInput);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.lblHeightVariable);
            this.Controls.Add(this.lblAgeVariable);
            this.Controls.Add(this.lblNameVariable);
            this.Controls.Add(this.lblWelcome);
            this.Name = "BasicInput";
            this.Text = "Basic Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNameVariable;
        private System.Windows.Forms.Label lblAgeVariable;
        private System.Windows.Forms.Label lblHeightVariable;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.TextBox txtAgeInput;
        private System.Windows.Forms.TextBox txtHeightInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lblOutput;
    }
}

