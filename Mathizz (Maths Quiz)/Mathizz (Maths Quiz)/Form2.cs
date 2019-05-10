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
    public partial class Form2 : Form
    {
        public enum Topic {Addition, Subtraction, Multipication, Division, Null};
        public static bool checkedB = false;
        public static Topic topic;
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (topic != Topic.Null)
            {
                switch (topic)
                {
                    case Topic.Addition:
                        AdditionForm additionForm = new AdditionForm();
                        additionForm.ShowDialog();
                        break;
                    case Topic.Subtraction:
                        SubtractionForm subtractionForm = new SubtractionForm();
                        subtractionForm.ShowDialog();
                        break;
                    case Topic.Multipication:
                        MultipicationForm multipicationForm = new MultipicationForm();
                        multipicationForm.ShowDialog();
                        break;
                    case Topic.Division:
                        DivisionForm divisionForm = new DivisionForm();
                        divisionForm.ShowDialog();
                        break;
                }
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !checkedB)
            {
                checkedB = true;
                topic = Topic.Addition;
            }
            else if (!radioButton1.Checked && checkedB)
            {
                checkedB = false;
                topic = Topic.Null;
            }
            else if(radioButton1.Checked && checkedB)
            {
                radioButton1.Checked = false;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && !checkedB)
            {
                checkedB = true;
                topic = Topic.Subtraction;
            }
            else if (!radioButton2.Checked && checkedB)
            {
                checkedB = false;
                topic = Topic.Null;
            }
            else if (radioButton2.Checked && checkedB)
            {
                radioButton2.Checked = false;
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && !checkedB)
            {
                checkedB = true;
                topic = Topic.Multipication;
            }
            else if (!radioButton3.Checked && checkedB)
            {
                checkedB = false;
                topic = Topic.Null;
            }
            else if (radioButton3.Checked && checkedB)
            {
                radioButton3.Checked = false;
            }
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && !checkedB)
            {
                checkedB = true;
                topic = Topic.Division;
            }
            else if (!radioButton4.Checked && checkedB)
            {
                checkedB = false;
                topic = Topic.Null;
            }
            else if (radioButton4.Checked && checkedB)
            {
                radioButton4.Checked = false;
            }
        }
    }
}
