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
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            net.graphicintegrity.battlepets.framework.Workflows.Player.UpdatePlayer(txtUserName.Text, txtPlayerName.Text);
            net.graphicintegrity.battlepets.framework.Workflows.Player.UpdatePlayerActive(txtUserName.Text, 1);
        }
    }
}
