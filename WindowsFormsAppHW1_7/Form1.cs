using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHW1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                if (radioButtonYear.Checked)
                {
                    labelTimeUntilDate.Text = ((DateTime.Parse(textBoxDate.Text) - dateTime).TotalDays / 365.0).ToString() + " years";
                }
                else if (radioButtonMonth.Checked)
                {
                    labelTimeUntilDate.Text = ((DateTime.Parse(textBoxDate.Text) - dateTime).TotalDays / 30.0).ToString() + " months";
                }
                else if (radioButtonDay.Checked)
                {
                    labelTimeUntilDate.Text = (DateTime.Parse(textBoxDate.Text) - dateTime).Days.ToString() + " days";
                }
                else if (radioButtonMinute.Checked)
                {
                    labelTimeUntilDate.Text = (Convert.ToInt64((DateTime.Parse(textBoxDate.Text) - dateTime).TotalMinutes)).ToString() + " minutes";
                }
                else if (radioButtonSecond.Checked)
                {
                    labelTimeUntilDate.Text = (Convert.ToInt64((DateTime.Parse(textBoxDate.Text) - dateTime).TotalSeconds)).ToString() + " seconds";
                }
                else
                {
                    radioButtonYear.Checked = true;
                    labelTimeUntilDate.Text = ((DateTime.Parse(textBoxDate.Text) - dateTime).TotalDays / 365.0).ToString() + " years";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try to type a different date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
