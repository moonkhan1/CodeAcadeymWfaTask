using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAAppCodeAcademy
{
    public partial class Form1 : Form
    {
        int lifes = 5;
        List<PictureBox> pictureList = new List<PictureBox>();
        public Form1()
        {
            
            InitializeComponent();
            faultText.Visible = false;
            pictureList = new List<PictureBox>{
                pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5
            };
            Random_Generate();

        }

        public void Random_Generate()
        {
            Random random = new Random();
            int r_n = random.Next(10000000, 99999999);
            kodlar.Text = r_n.ToString();


        }
        private void MainText_Click(object sender, EventArgs e)
        {
           
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == kodlar.Text)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                Random_Generate();
                TxtBox.Clear();
                TxtBox.Select();
                pictureList[pictureList.Count - lifes].Visible = false;
                lifes--;
            }

            if (pictureList[4].Visible == false && lifes == 0)
            {
                LoginButton.Enabled = false;
                kodlar.Text = "********";
                MessageBox.Show("Numarayı doğru girmediniz. Şansınız tükendi!");
                this.Close();
            }

        }

        private void SecondText_Click(object sender, EventArgs e)
        {

        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (TxtBox.Text != kodlar.Text)
            {
                faultText.Visible = true;
                faultText.Text = "Numarayı doğru giriniz!";
                faultText.BackColor = Color.Maroon;

            }
                if (TxtBox.Text == kodlar.Text) 
                {
                    faultText.Text = "Numara doğru girildi!";
                    faultText.BackColor = Color.Green;
            }
             if (String.IsNullOrEmpty(TxtBox.Text))
            {
                faultText.Visible = false;
            }
            if (!String.IsNullOrEmpty(TxtBox.Text))
            {
                LoginButton.Enabled = true;
            }

        }

        private void ThirdText_Click(object sender, EventArgs e)
        {

        }

        private void kodlar_Click(object sender, EventArgs e)
        {

        }
    }
}
