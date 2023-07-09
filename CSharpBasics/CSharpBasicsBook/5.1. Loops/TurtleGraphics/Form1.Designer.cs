namespace TurtleGraphics
{
    partial class Form
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
            buttonDraw = new Button();
            buttonReset = new Button();
            buttonShowHideTurtle = new Button();
            buttonTornado = new Button();
            buttonTriangle = new Button();
            buttonTriangleLine = new Button();
            SuspendLayout();
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(24, 18);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(99, 55);
            buttonDraw.TabIndex = 0;
            buttonDraw.Text = "Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(24, 79);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(99, 55);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonShowHideTurtle
            // 
            buttonShowHideTurtle.Location = new Point(23, 140);
            buttonShowHideTurtle.Name = "buttonShowHideTurtle";
            buttonShowHideTurtle.Size = new Size(99, 55);
            buttonShowHideTurtle.TabIndex = 2;
            buttonShowHideTurtle.Text = "Show / Hide Turtle";
            buttonShowHideTurtle.UseVisualStyleBackColor = true;
            buttonShowHideTurtle.Click += button1_Click;
            // 
            // buttonTornado
            // 
            buttonTornado.Location = new Point(24, 201);
            buttonTornado.Name = "buttonTornado";
            buttonTornado.Size = new Size(99, 55);
            buttonTornado.TabIndex = 3;
            buttonTornado.Text = "Tornado";
            buttonTornado.UseVisualStyleBackColor = true;
            buttonTornado.Click += button1_Click_1;
            // 
            // buttonTriangle
            // 
            buttonTriangle.Location = new Point(24, 262);
            buttonTriangle.Name = "buttonTriangle";
            buttonTriangle.Size = new Size(99, 55);
            buttonTriangle.TabIndex = 4;
            buttonTriangle.Text = "Triangle";
            buttonTriangle.UseVisualStyleBackColor = true;
            buttonTriangle.Click += button1_Click_2;
            // 
            // buttonTriangleLine
            // 
            buttonTriangleLine.Location = new Point(24, 323);
            buttonTriangleLine.Name = "buttonTriangleLine";
            buttonTriangleLine.Size = new Size(99, 55);
            buttonTriangleLine.TabIndex = 5;
            buttonTriangleLine.Text = "TriangleLine";
            buttonTriangleLine.UseVisualStyleBackColor = true;
            buttonTriangleLine.Click += button1_Click_3;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 626);
            Controls.Add(buttonTriangleLine);
            Controls.Add(buttonTriangle);
            Controls.Add(buttonTornado);
            Controls.Add(buttonShowHideTurtle);
            Controls.Add(buttonReset);
            Controls.Add(buttonDraw);
            Name = "Form";
            Text = " ";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDraw;
        private Button buttonReset;
        private Button buttonShowHideTurtle;
        private Button buttonTornado;
        private Button buttonTriangle;
        private Button buttonTriangleLine;
    }
}