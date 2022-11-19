using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryForAssignment3;

namespace assignment3For158212
{
    public partial class Tip : Form
    {
        public Tip()
        {
            InitializeComponent();
        }
 
        public Tip( List<string[]> noTeamPlayer)
        {
            InitializeComponent();
            Tip1OfTip.Text = "There is still " + noTeamPlayer.Count() + " player(s) has no team(s)," +"\n" + "Do you want to add them?";
        }

        public void SetMessage(string Message)
        {
            Tip1OfTip.Text = Message;
        }

        private bool yesOrNo;// To show if the user click yes or no

        private void YesButton_Click(object sender, EventArgs e)
        {
            yesOrNo = true;
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            yesOrNo = false;
            this.Close();
        }

        public bool GetYesOrNo()// To show if the user click yes or no
        {
            return yesOrNo;
        }

    }
}
