using System.Windows.Forms;

namespace PointAndRectangle
{
    public partial class PointAndRectangle : Form
    {
        public PointAndRectangle()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Draw();
        }
        private void Draw()
        {
            var x1 = this.numericUpDownX1.Value;
            var y1 = this.numericUpDownY1.Value;
            var x2 = this.numericUpDownX2.Value;
            var y2 = this.numericUpDownY2.Value;
            var x = this.numericUpDownX.Value;
            var y = this.numericUpDownY.Value;

            var left = Math.Min(x1, x2);
            var right = Math.Max(x1, x2);
            var up = Math.Min(y1, y2);
            var down = Math.Max(y1, y2);

            if (x < left && x < right && y > up && y > down)
            {
                this.labelInside.Text = "Inside";
                this.labelInside.BackColor = Color.LightGreen;
            }
            else if (x < left || x > right || y < up || y > down)
            {
                this.labelInside.Text = "Outside";
                this.labelInside.BackColor = Color.OrangeRed;
            }
            else if (((x == left) || (x == right)) &&
                ((y == up) || (y == down)))
            {
                this.labelInside.Text = "Corner";
                this.labelInside.BackColor = Color.Coral;
            }
            else
            {
                this.labelInside.Text = "Border";
                this.labelInside.BackColor = Color.LightBlue;
            }
            Visualize();

        }

        private void Visualize()
        {
            // Get the rectangle and point coordinates from the form
            var x1 = this.numericUpDownX1.Value;
            var y1 = this.numericUpDownY1.Value;
            var x2 = this.numericUpDownX2.Value;
            var y2 = this.numericUpDownY2.Value;
            var x = this.numericUpDownX.Value;
            var y = this.numericUpDownY.Value;



            // Calculate the scale factor (ratio) for the diagram holding the
            // rectangle and point in order to fit them well in the picture box
            var minx1 = Math.Min(x1, x2);
            var minX = Math.Min(minx1, x);
            var maxX1 = Math.Max(x1, x2);
            var maxX = Math.Max(maxX1, x);
            var minY1 = Math.Max(y1, y2);
            var minY = Math.Min(minY1, y);
            var maxY1 = Math.Max(y1, y2);
            var maxY = Math.Max(maxY1, y);
            var diagramWidth = maxX - minX;
            var diagramHeight = maxY - minY;
            var ratio = 1.0m;
            var offset = 10;
            if (diagramWidth != 0 && diagramHeight != 0)
            {
                var ratioX = (pictureBox.Width - 2 * offset - 1) / diagramWidth;
                var ratioY = (pictureBox.Height - 2 * offset - 1) / diagramHeight;
                ratio = Math.Min(ratioX, ratioY);
            }

            // Calculate the scaled rectangle coordinates
            var rectLeft = offset + (int)Math.Round((Math.Min(x1, x2) - minX) * ratio);
            var rectTop = offset + (int)Math.Round((Math.Min(y1, y2) - minY) * ratio);
            var rectWidth = (int)Math.Round(Math.Abs(x2 - x1) * ratio);
            var rectHeight = (int)Math.Round(Math.Abs(y2 - y1) * ratio);
            var rect = new Rectangle(rectLeft, rectTop, rectWidth, rectHeight);

            // Calculate the scalled point coordinates
            var pointX = (int)Math.Round(offset + (x - minX) * ratio);
            var pointY = (int)Math.Round(offset + (y - minY) * ratio);
            var pointRect = new Rectangle(pointX - 2, pointY - 2, 5, 5);

            // Draw the rectangle and point
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                // Draw diagram background (white area)
                g.Clear(Color.White);

                // Draw the rectangle (scalled to the picture box size)
                var pen = new Pen(Color.Blue, 3);
                g.DrawRectangle(pen, rect);

                // Draw the point (scalled to the picture box size)
                pen = new Pen(Color.DarkBlue, 5);
                g.DrawEllipse(pen, pointRect);
            }
        }

        private void numericUpDownX1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownX2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void PointAndRectangle_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void PointAndRectangle_Resize(object sender, EventArgs e)
        {
            Draw();
        }
    }
}