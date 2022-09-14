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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Tick += delegate {
                this.Close();
            };
            timer.Interval = 3000; 
            timer.Start();

        }
       

        private void SecondFormText_Click(object sender, EventArgs e)
        {

        }
    }
}
