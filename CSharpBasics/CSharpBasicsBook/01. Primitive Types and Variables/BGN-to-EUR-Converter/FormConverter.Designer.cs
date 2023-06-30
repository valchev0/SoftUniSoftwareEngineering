namespace BGN_to_EUR_Converter
{
    partial class FormConverter
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
            numericUpDownAmount = new NumericUpDown();
            labelChange = new Label();
            labelResult = new Label();
            labelBGNtoEUR = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.DecimalPlaces = 2;
            numericUpDownAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownAmount.Location = new Point(78, 28);
            numericUpDownAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(114, 23);
            numericUpDownAmount.TabIndex = 0;
            numericUpDownAmount.TextAlign = HorizontalAlignment.Right;
            numericUpDownAmount.ValueChanged += numericUpDownAmount_ValueChanged;
            // 
            // labelChange
            // 
            labelChange.AutoSize = true;
            labelChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelChange.Location = new Point(12, 30);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(52, 15);
            labelChange.TabIndex = 1;
            labelChange.Text = "Convert";
            labelChange.TextAlign = ContentAlignment.MiddleCenter;
            labelChange.Click += label1_Click;
            // 
            // labelResult
            // 
            labelResult.BackColor = SystemColors.ActiveCaption;
            labelResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelResult.Location = new Point(8, 66);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(269, 23);
            labelResult.TabIndex = 2;
            labelResult.Text = "4700 BGN = 3500 EUR";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBGNtoEUR
            // 
            labelBGNtoEUR.AutoSize = true;
            labelBGNtoEUR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBGNtoEUR.Location = new Point(208, 30);
            labelBGNtoEUR.Name = "labelBGNtoEUR";
            labelBGNtoEUR.Size = new Size(74, 15);
            labelBGNtoEUR.TabIndex = 3;
            labelBGNtoEUR.Text = "BGN to EUR";
            labelBGNtoEUR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 97);
            Controls.Add(labelBGNtoEUR);
            Controls.Add(labelResult);
            Controls.Add(labelChange);
            Controls.Add(numericUpDownAmount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConverter";
            ShowIcon = false;
            Text = "BGN-to-EUR-Converter ";
            Load += Form_Load;
            KeyUp += FormConverter_KeyUp;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownAmount;
        private Label labelChange;
        private Label labelResult;
        private Label labelBGNtoEUR;
    }
}