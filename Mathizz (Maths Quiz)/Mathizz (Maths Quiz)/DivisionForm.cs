using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathizz__Maths_Quiz_
{
    public partial class DivisionForm : Form
    {
        public static List<int> backNums = new List<int>();
        public static List<int> frontNums = new List<int>();
        public DivisionForm()
        {
            InitializeComponent();
        }

        private void AdditionForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (int i in new int[] { 1, 2, 3, 4, 5 })
            {
                int backNum = random.Next(1000);
                int frontNum = random.Next(100);
                while (backNum % 2 != 0)
                    backNum = random.Next(1000);
                while (frontNum % 2 != 0 && frontNum != 0)  
                    frontNum = random.Next(100);
                backNums.Add(backNum);
                frontNums.Add(frontNum);
                listBox1.Items.Add($"{backNum} / {frontNum}");
            }
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && textBox1.Text != null)
            {
                if (backNums[listBox1.SelectedIndex] / frontNums[listBox1.SelectedIndex] == int.Parse(textBox1.Text))
                {
                    MessageBox.Show("You are right");
                }
                else
                {
                    MessageBox.Show("You are wrong");
                }
            }
        }
    }
}
