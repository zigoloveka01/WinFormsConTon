namespace WinFormsConTon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Click(object sender, EventArgs e)
        {

            Random rm = new Random();
            int r = rm.Next(0, 255);
            int g = rm.Next(0, 255);
            int b = rm.Next(0, 255);

            this.BackColor = Color.FromArgb(r, g, b);
            this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดจิงหรือไม่", "แนะใจนะ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightSeaGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightYellow;
        }

        private void มหาวิทยาลัยราชภัฏอุดร(object sender, EventArgs e)
        {
            if (label1.Text == "มหาลัยราชภัฏอุดรธานี")
            {
                label1.Text = "Udonthani Rajabhat University";
            }
            else
            {
                label1.Text = "มหาลัยราชภัฏอุดรธานี";
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightSeaGreen;
            label1.Text = "Udonthani Rajabhat University";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightYellow;
            label1.Text = "มหาลัยราชภัฏอุดรธานี";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;

            Random rm = new Random();
            int r = rm.Next(0, 255);
            int g = rm.Next(0, 255);
            int b = rm.Next(0, 255);
            label1.ForeColor = Color.FromArgb(r, g, b);
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //textBox1.Text = string.Empty;
            //textBox1.Text = null;
        }
    }

}
