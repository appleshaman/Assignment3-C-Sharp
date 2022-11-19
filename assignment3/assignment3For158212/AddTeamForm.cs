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
    public partial class AddTeamForm : Form
    {


        public AddTeamForm()
        {
            InitializeComponent();
            FoundedNumericUpDown.Maximum = DateTime.Now.Date.Year;
            SkipLable.Visible = false;
            AddNoTeam.Visible = false;
        }

        List<Team> teams = new List<Team>();

        public AddTeamForm(List<Team> teams)// normal situation that user clicked add team button or the system ask the user to add a team for the player who has no team and ID is duplicated
        {
            InitializeComponent();
            FoundedNumericUpDown.Maximum = DateTime.Now.Date.Year;
            SkipLable.Visible = false;
            AddNoTeam.Visible = false;
            this.teams = teams;
        }

        public AddTeamForm(string noTeam, List<Team> teams)// first situation ask user to add team when the player he added has no team
        {
            InitializeComponent();
            FoundedNumericUpDown.Maximum = DateTime.Now.Date.Year;
            SkipLable.Visible = false;
            AddNoTeam.Visible = false;
            NameTextBox.Text = noTeam;
            NameTextBox.Enabled = false;
            this.teams = teams;
        }

        private List<string[]> noTeamPlayer = new List<string[]>();

        public AddTeamForm(List<string[]> noTeamPlayer, List<Team> teams)// for the situation that player who has no team after reading the file, their ID is not duplicated in this case
        {
            InitializeComponent();
            this.noTeamPlayer = noTeamPlayer;
            AddNoTeam.Text = "You are creating team for player: " + "\n" + noTeamPlayer[noTeamPlayer.Count - 1][1].Trim();// show this player's name
            SkipLable.Visible = true;
            this.teams = teams;
            NameTextBox.Text = noTeamPlayer[noTeamPlayer.Count - 1][2].Trim();
            NameTextBox.Enabled = false;
        }


        private bool yesOrNo;

        private Team addedTeam;


        private Player tempPlayer;
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if ((NameTextBox.Text == String.Empty) || (GroundTextBox.Text == String.Empty) || (FoundedNumericUpDown.Value == 0) || (CoachTextBox.Text == String.Empty) || (RegionTextBox.Text == String.Empty))// makesure the user fill all the empty text box, otherwise the tip will comes out
            {
                if (NameTextBox.Text == String.Empty)
                {
                    StarLabel1.Visible = true;
                    EmptyTip.Visible = true;
                }
                else
                {
                    StarLabel1.Visible = false;
                    EmptyTip.Visible = false;
                }

                if (GroundTextBox.Text == String.Empty)
                {
                    StarLabel2.Visible = true;
                    EmptyTip.Visible = true;
                }
                else
                {
                    StarLabel2.Visible = false;
                    EmptyTip.Visible = false;
                }

                if (FoundedNumericUpDown.Value == 0)
                {
                    StarLabel3.Visible = true;
                    EmptyTip.Visible = true;
                }
                else
                {
                    StarLabel3.Visible = false;
                    EmptyTip.Visible = false;
                }

                if (CoachTextBox.Text == String.Empty)
                {
                    StarLabel4.Visible = true;
                    EmptyTip.Visible = true;
                }
                else
                {
                    StarLabel4.Visible = false;
                    EmptyTip.Visible = false;
                }

                if (RegionTextBox.Text == String.Empty)
                {
                    StarLabel5.Visible = true;
                    EmptyTip.Visible = true;
                }
                else
                {
                    StarLabel5.Visible = false;
                    EmptyTip.Visible = false;
                }
            }

            else if (teams.Exists((Team T) => T.GetName() == NameTextBox.Text))// if the team name is duolicated
            {
                StarLabel1.Visible = true;
                EmptyTip.Visible = true;

            }
            else
            {
                StarLabel1.Visible = false;// set the red stars invisiable because all the empty is been fiiled and no team name is duplicated
                StarLabel2.Visible = false;
                StarLabel3.Visible = false;
                StarLabel4.Visible = true;
                StarLabel5.Visible = false;
                EmptyTip.Visible = false;

                if (noTeamPlayer.Count() != 0)// for the situation with noteamplayer
                {
                    addedTeam = new Team(NameTextBox.Text, GroundTextBox.Text, CoachTextBox.Text, short.Parse(FoundedNumericUpDown.Value.ToString()), RegionTextBox.Text);
                    tempPlayer = new Player(int.Parse(noTeamPlayer[noTeamPlayer.Count - 1][0].Trim()), noTeamPlayer[noTeamPlayer.Count - 1][1].Trim(), noTeamPlayer[noTeamPlayer.Count - 1][2].Trim(), noTeamPlayer[noTeamPlayer.Count - 1][3].Trim(), byte.Parse(noTeamPlayer[noTeamPlayer.Count - 1][4].Trim()), byte.Parse(noTeamPlayer[noTeamPlayer.Count - 1][5].Trim()), noTeamPlayer[noTeamPlayer.Count - 1][6].Trim());
                    addedTeam.AddPlayer(tempPlayer);
                    yesOrNo = true;
                    this.Close();
                }
                else// normal situation
                {
                    addedTeam = new Team(NameTextBox.Text, GroundTextBox.Text, CoachTextBox.Text, short.Parse(FoundedNumericUpDown.Value.ToString()), RegionTextBox.Text);
                    yesOrNo = true;
                    this.Close();
                }
            }




        }

        public bool GetYesOrNo()
        {
            return yesOrNo;
        }

        public Team GetTeam()
        {
            return addedTeam;
        }

        public Player GetPlayer()
        {
            return tempPlayer;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            yesOrNo = false;
            this.Close();
        }
    }
}
