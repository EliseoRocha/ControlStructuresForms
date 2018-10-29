using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlStructuresForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sum = 0;
        private void AddNumberButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(UserNumberText.Text);
            
            sum += number;

            //c# string (interpolated string)
            MessageBox.Show($"You have: {sum}");
        }
    }
}
