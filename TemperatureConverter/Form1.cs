namespace TemperatureConverter
{
    public partial class temperatureConverter : Form
    {
        public temperatureConverter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celcious = Double.Parse(celciusTextBox.Text);
            double results = (celcious * 9 / 5) + 32;
            farenHeitTextBox.Text = results.ToString();
        }
    }
}