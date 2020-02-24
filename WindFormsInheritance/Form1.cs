using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindFormsInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetNumCheckedBoxesChecked();
        }

        /// <summary>
        /// Get number of checked boxes checked on the form.
        /// </summary>
        /// <returns></returns>
        private void GetNumCheckedBoxesChecked()
        {
            int countChecked = 0;
            foreach (Control c in this.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox currBox = c as CheckBox;
                    if (currBox.Checked)
                    {
                        countChecked++;
                    }
                }
            }
            MessageBox.Show($"You checked {countChecked}");
        }
    }
}
