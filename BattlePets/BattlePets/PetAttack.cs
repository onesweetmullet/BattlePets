using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using net.graphicintegrity.battlepets.framework.Workflows;

namespace BattlePets
{
    public partial class PetAttack : Form
    {
        public PetAttack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            txtResult.Text = AttackAction.Attack
                (
                    int.Parse(txtPlayerID.Text),
                    int.Parse(txtPetInstanceID.Text),
                    int.Parse(txtPetSkillID.Text),
                    int.Parse(txtOpponentPetID.Text),
                    int.Parse(txtOpponentPetLevel.Text)
                ).ToString();
        }
    }
}
