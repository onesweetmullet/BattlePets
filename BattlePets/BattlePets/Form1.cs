using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattlePets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtSeed.Text == "")
            {
                txtResult.Text = net.graphicintegrity.battlepets.framework.Utilities.RNG.GetRandomNumber(int.Parse(txtMinValue.Text), int.Parse(txtMaxValue.Text)).ToString();
            }
            else
            {
                txtResult.Text = net.graphicintegrity.battlepets.framework.Utilities.RNG.GetRandomNumber(int.Parse(txtMinValue.Text), int.Parse(txtMaxValue.Text), int.Parse(txtSeed.Text)).ToString();
            }            
        }
    }
}
