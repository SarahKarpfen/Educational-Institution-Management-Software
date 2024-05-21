using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOOPtr
{
    public partial class BnotTzion_HighSchool : Form
    {
        public BnotTzion_HighSchool()
        {
            InitializeComponent();
        }

        private void btnStudentMenag_Click(object sender, EventArgs e)
        {
            StudentsMenagForm smf= new StudentsMenagForm();
            this.Hide();
            smf.ShowDialog();
        }

        private void BnotTzion_HighSchool_Load(object sender, EventArgs e)
        {

        }

        private void btnTeamMenag_Click(object sender, EventArgs e)
        {
            TeamMenagForm tmf= new TeamMenagForm();
            this.Hide();
            tmf.ShowDialog();
        }
    }
}
