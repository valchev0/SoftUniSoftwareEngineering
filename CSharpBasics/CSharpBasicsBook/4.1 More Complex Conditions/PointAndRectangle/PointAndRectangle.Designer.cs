namespace PointAndRectangle
{
    partial class PointAndRectangle
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
            labelRectangle = new Label();
            labelX1 = new Label();
            numericUpDownX1 = new NumericUpDown();
            numericUpDownX2 = new NumericUpDown();
            labelX2 = new Label();
            numericUpDownY2 = new NumericUpDown();
            labelY2 = new Label();
            numericUpDownY1 = new NumericUpDown();
            labelY1 = new Label();
            numericUpDownY = new NumericUpDown();
            labelY = new Label();
            numericUpDownX = new NumericUpDown();
            labelX = new Label();
            labelPoint = new Label();
            buttonDraw = new Button();
            labelInside = new Label();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // labelRectangle
            // 
            labelRectangle.AutoSize = true;
            labelRectangle.Location = new Point(43, 35);
            labelRectangle.Name = "labelRectangle";
            labelRectangle.Size = new Size(96, 20);
            labelRectangle.TabIndex = 0;
            labelRectangle.Text = "Rectangle:";
            // 
            // labelX1
            // 
            labelX1.AutoSize = true;
            labelX1.Location = new Point(58, 71);
            labelX1.Name = "labelX1";
            labelX1.Size = new Size(47, 20);
            labelX1.TabIndex = 1;
            labelX1.Text = "x1 = ";
            // 
            // numericUpDownX1
            // 
            numericUpDownX1.DecimalPlaces = 2;
            numericUpDownX1.Location = new Point(120, 66);
            numericUpDownX1.Margin = new Padding(2);
            numericUpDownX1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownX1.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            numericUpDownX1.Name = "numericUpDownX1";
            numericUpDownX1.Size = new Size(82, 26);
            numericUpDownX1.TabIndex = 2;
            numericUpDownX1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownX1.ValueChanged += numericUpDownX1_ValueChanged;
            // 
            // numericUpDownX2
            // 
            numericUpDownX2.DecimalPlaces = 2;
            numericUpDownX2.Location = new Point(120, 167);
            numericUpDownX2.Margin = new Padding(2);
            numericUpDownX2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownX2.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            numericUpDownX2.Name = "numericUpDownX2";
            numericUpDownX2.Size = new Size(82, 26);
            numericUpDownX2.TabIndex = 4;
            numericUpDownX2.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownX2.ValueChanged += numericUpDownX2_ValueChanged;
            // 
            // labelX2
            // 
            labelX2.AutoSize = true;
            labelX2.Location = new Point(58, 169);
            labelX2.Name = "labelX2";
            labelX2.Size = new Size(47, 20);
            labelX2.TabIndex = 3;
            labelX2.Text = "x2 = ";
            // 
            // numericUpDownY2
            // 
            numericUpDownY2.DecimalPlaces = 2;
            numericUpDownY2.Location = new Point(120, 217);
            numericUpDownY2.Margin = new Padding(2);
            numericUpDownY2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownY2.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            numericUpDownY2.Name = "numericUpDownY2";
            numericUpDownY2.Size = new Size(82, 26);
            numericUpDownY2.TabIndex = 8;
            numericUpDownY2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownY2.ValueChanged += numericUpDownY2_ValueChanged;
            // 
            // labelY2
            // 
            labelY2.AutoSize = true;
            labelY2.Location = new Point(58, 219);
            labelY2.Name = "labelY2";
            labelY2.Size = new Size(47, 20);
            labelY2.TabIndex = 7;
            labelY2.Text = "y2 = ";
            // 
            // numericUpDownY1
            // 
            numericUpDownY1.DecimalPlaces = 2;
            numericUpDownY1.Location = new Point(120, 121);
            numericUpDownY1.Margin = new Padding(2);
            numericUpDownY1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownY1.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            numericUpDownY1.Name = "numericUpDownY1";
            numericUpDownY1.Size = new Size(82, 26);
            numericUpDownY1.TabIndex = 6;
            numericUpDownY1.Value = new decimal(new int[] { 3, 0, 0, int.MinValue });
            numericUpDownY1.ValueChanged += numericUpDownY1_ValueChanged;
            // 
            // labelY1
            // 
            labelY1.AutoSize = true;
            labelY1.Location = new Point(58, 123);
            labelY1.Name = "labelY1";
            labelY1.Size = new Size(47, 20);
            labelY1.TabIndex = 5;
            labelY1.Text = "y1 = ";
            // 
            // numericUpDownY
            // 
            numericUpDownY.DecimalPlaces = 2;
            numericUpDownY.Location = new Point(120, 361);
            numericUpDownY.Margin = new Padding(2);
            numericUpDownY.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownY.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(82, 26);
            numericUpDownY.TabIndex = 13;
            numericUpDownY.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDownY.ValueChanged += numericUpDownY_ValueChanged;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(58, 363);
            labelY.Name = "labelY";
            labelY.Size = new Size(37, 20);
            labelY.TabIndex = 12;
            labelY.Text = "y = ";
            // 
            // numericUpDownX
            // 
            numericUpDownX.DecimalPlaces = 2;
            numericUpDownX.Location = new Point(120, 312);
            numericUpDownX.Margin = new Padding(2);
            numericUpDownX.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownX.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(82, 26);
            numericUpDownX.TabIndex = 11;
            numericUpDownX.Value = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownX.ValueChanged += numericUpDownX_ValueChanged;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(58, 314);
            labelX.Name = "labelX";
            labelX.Size = new Size(37, 20);
            labelX.TabIndex = 10;
            labelX.Text = "x = ";
            // 
            // labelPoint
            // 
            labelPoint.AutoSize = true;
            labelPoint.Location = new Point(43, 272);
            labelPoint.Name = "labelPoint";
            labelPoint.Size = new Size(55, 20);
            labelPoint.TabIndex = 9;
            labelPoint.Text = "Point:";
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(42, 410);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(163, 44);
            buttonDraw.TabIndex = 14;
            buttonDraw.Text = "Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // labelInside
            // 
            labelInside.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInside.Location = new Point(49, 471);
            labelInside.Name = "labelInside";
            labelInside.Size = new Size(153, 46);
            labelInside.TabIndex = 15;
            labelInside.Text = "Result";
            labelInside.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Location = new Point(240, 36);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(637, 451);
            pictureBox.TabIndex = 16;
            pictureBox.TabStop = false;
            // 
            // PointAndRectangle
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 531);
            Controls.Add(pictureBox);
            Controls.Add(labelInside);
            Controls.Add(buttonDraw);
            Controls.Add(numericUpDownY);
            Controls.Add(labelY);
            Controls.Add(numericUpDownX);
            Controls.Add(labelX);
            Controls.Add(labelPoint);
            Controls.Add(numericUpDownY2);
            Controls.Add(labelY2);
            Controls.Add(numericUpDownY1);
            Controls.Add(labelY1);
            Controls.Add(numericUpDownX2);
            Controls.Add(labelX2);
            Controls.Add(numericUpDownX1);
            Controls.Add(labelX1);
            Controls.Add(labelRectangle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(950, 570);
            Name = "PointAndRectangle";
            Text = "PointAndRectangle";
            Load += PointAndRectangle_Load;
            Resize += PointAndRectangle_Resize;
            ((System.ComponentModel.ISupportInitialize)numericUpDownX1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRectangle;
        private Label labelX1;
        private NumericUpDown numericUpDownX1;
        private NumericUpDown numericUpDownX2;
        private Label labelX2;
        private NumericUpDown numericUpDownY2;
        private Label labelY2;
        private NumericUpDown numericUpDownY1;
        private Label labelY1;
        private NumericUpDown numericUpDownY;
        private Label labelY;
        private NumericUpDown numericUpDownX;
        private Label labelX;
        private Label labelPoint;
        private Button buttonDraw;
        private Label labelInside;
        private PictureBox pictureBox;
    }
}