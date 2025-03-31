using System.Diagnostics.CodeAnalysis;
using System.Security.Permissions;

namespace Task3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxBase.Text = "0";
            textBoxExpo.Text = "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public int PowerFunc(int Base, int Expo)
        {
            if (Expo == 0) 
            {
                return 1; 
            }
            else 
            {
                return Base * PowerFunc(Base, Expo - 1);    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               int Base = Convert.ToInt32(textBoxBase.Text);
               int Expo = Convert.ToInt32(textBoxExpo.Text);

               int Res = PowerFunc(Base, Expo);
                MessageBox.Show($"The Result is: {Res}");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Something Went Wrong");
            }
        }
    }
}
