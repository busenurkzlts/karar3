namespace karar3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte sayi1, sayi2;
            sayi1 = Convert.ToByte(textBox1.Text);
            sayi2 = Convert.ToByte(textBox2.Text);
            if (sayi1 > sayi2)
            {
                MessageBox.Show("1.say� 2.say�dan b�y�kt�r");
            }
            if (sayi1 == sayi2)
            {
                MessageBox.Show("say�lar birbirine e�ittir");
            }
            if (sayi1 < sayi2)
            {
                MessageBox.Show("2.say� 1.say�dan b�y�kt�r");
            }
        }
    }
}