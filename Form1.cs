namespace c_sharp_tipo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "работает ура!!!";
            pictureBox1.Image = Properties.Resources.z71V50maosI;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dev;
        }
    }
}