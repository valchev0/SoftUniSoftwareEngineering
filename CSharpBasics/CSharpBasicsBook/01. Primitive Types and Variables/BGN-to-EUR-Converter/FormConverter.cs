namespace BGN_to_EUR_Converter
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }

        void Convert()
        {
            var amount = this.numericUpDownAmount.Value;
            var amountInEuro = amount / 1.95583m;
            this.labelResult.Text =
                amount + " BGN = " +
                Math.Round(amountInEuro, 2) + " EUR";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Convert();
        }

        private void FormConverter_KeyUp(object sender, KeyEventArgs e)
        {
            Convert();
        }
    }
}