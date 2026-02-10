namespace Random_Number_File_Writer
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
            buttonSave = new Button();
            buttonExit = new Button();
            labelDesc = new Label();
            numericInput = new NumericUpDown();
            saveFile = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)numericInput).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(83, 148);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(180, 148);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Close";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Location = new Point(68, 43);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(203, 30);
            labelDesc.TabIndex = 2;
            labelDesc.Text = "How many random numbers to save:\r\n(Decimals will be rounded!!!)\r\n";
            labelDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // numericInput
            // 
            numericInput.Location = new Point(109, 85);
            numericInput.Name = "numericInput";
            numericInput.Size = new Size(120, 23);
            numericInput.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 224);
            Controls.Add(numericInput);
            Controls.Add(labelDesc);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonExit;
        private Label labelDesc;
        private NumericUpDown numericInput;
        private SaveFileDialog saveFile;
    }
}
