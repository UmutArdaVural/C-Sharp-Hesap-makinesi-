using System.Collections.Specialized;
// UMUT ARDA VURAL SAKARYA B�LG�S�YAR M�HEND�SL��� 2.D�NEM HESAP MAK�NES�  // 
namespace hesapMakinesi
{

    public partial class Form1 : Form
    {
        double ilksay� = 0;
        double ikincisay� = 0;
        double sonu� = 0;

        string islem;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 9
 )
            {
                textBox1.Font = new Font("Arial", 30);
            }
            else if (textBox1.TextLength == 18)
            {
                textBox1.Font = new Font("Arial", 20);

            }
            else if (textBox1.TextLength == 0 || textBox1.TextLength == 1)
            {
                textBox1.Font = new Font("Arial",48 );

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ilksay� = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            islem = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ilksay� = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            islem = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ilksay� = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            islem = "x";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ilksay� = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            islem = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            ilksay� = 0;
            ikincisay� = 0;
            islem = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                ikincisay� = Convert.ToDouble(textBox1.Text);

                sonu� = ilksay� + ikincisay�;
                textBox1.Text = Convert.ToString(sonu�);
            }
            else if (islem == "-")
            {
                ikincisay� = Convert.ToDouble(textBox1.Text);

                sonu� = ilksay� - ikincisay�;
                textBox1.Text = Convert.ToString(sonu�);
            }
            else if (islem == "/")
            {
                ikincisay� = Convert.ToDouble(textBox1.Text);
                if (ikincisay� == 0)
                {
                    textBox1.Text = "HATA";

                }
                else
                {
                    sonu� = ilksay� / ikincisay�;
                    textBox1.Text = Convert.ToString(sonu�);
                }
            }
            else if (islem == "x")
            {
                ikincisay� = Convert.ToDouble(textBox1.Text);

                sonu� = ilksay� * ikincisay�;
                textBox1.Text = Convert.ToString(sonu�);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
