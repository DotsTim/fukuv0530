namespace fukuv0530
{

    public partial class Form1 : Form
    {
        int vx = 5;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Left -= vx;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "kurebayashi";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
        }
    }
}
