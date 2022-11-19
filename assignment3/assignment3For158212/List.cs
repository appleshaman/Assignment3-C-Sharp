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
    public partial class ListOfPOrT : Form
    {
        private bool mode = false; //To see which mode, false means display the list of player and true means displaye a list of players
        private bool subForm = false;//To see if this is a sub-form, true: it is subform, false; it is not a subform. Sub-form means the form that display the list after you click the element in the original list, e.g: click team in the team list to display pleayers in this team.

        public ListOfPOrT()
        {
            InitializeComponent();
        }

        public ListOfPOrT(List<Team> teams)//mode = true, display team list
        {
            InitializeComponent();
            ListNameLable.Text = "List of all teams";
            mode = true;
            subForm = false;
            ListViewForTOrP.Columns[0].Text = "Name";
            ListViewForTOrP.Columns[1].Text = "Number of players";
            ListViewForTOrP.Columns[2].Text = "Coach";
            ListViewForTOrP.Columns[3].Text = "Founded year";
            ListViewForTOrP.Columns[4].Text = "Ground";

            foreach(var p in teams)
            {
                var row = new string[] { p.GetName(), p.GetNumberOfPlayer().ToString(), p.GetCoach(), p.GetFoundedYear().ToString(), p.GetGround() };
                var lvi = new ListViewItem(row);
                lvi.Tag = p;// store the team infomation in the row of that team
                ListViewForTOrP.Items.Add(lvi);
            }
        }


        public ListOfPOrT(List<Player> players, List<Team> teams)//mode = false, display all players
        {
            InitializeComponent();
            ListNameLable.Text = "List of all players";

            mode = false;
            subForm = false;
            ListViewForTOrP.Columns[0].Text = "Name";
            ListViewForTOrP.Columns[1].Text = "ID";
            ListViewForTOrP.Columns[2].Text = "Team";
            ListViewForTOrP.Columns[3].Text = "Date of birth";
            ListViewForTOrP.Columns[4].Text = "Place of birth";

            foreach(var p in players)
            {
                var row = new string[] { p.GetName(),p.GetID().ToString(), p.GetTeam(), p.GetBirthdate(), p.GetPlaceOfBirth() };
                var lvi = new ListViewItem(row);
                ListViewForTOrP.Items.Add(lvi);
                int temp = teams.FindIndex((Team T) => T.GetName() == p.GetTeam());
                lvi.Tag = teams[temp];// store the team infomation in the row of that player signed in

            }
        }

        public ListOfPOrT(List<Player> players)// display players in a team, subform = true, is a sub-form
        {
            InitializeComponent();
            ListNameLable.Text = "List of all players in this team";

            subForm = true;
            ListViewForTOrP.Columns[0].Text = "Name";
            ListViewForTOrP.Columns[1].Text = "ID";
            ListViewForTOrP.Columns[2].Text = "Team";
            ListViewForTOrP.Columns[3].Text = "Date of birth";
            ListViewForTOrP.Columns[4].Text = "Place of birth";

            foreach (var p in players)
            {
                var row = new string[] { p.GetName(), p.GetID().ToString(), p.GetTeam(), p.GetBirthdate(), p.GetPlaceOfBirth() };
                var lvi = new ListViewItem(row);
                ListViewForTOrP.Items.Add(lvi);
            }
        }

        public ListOfPOrT(Team team)// display information of this team, subform = true, is a sub-form
        {
            InitializeComponent();
            ListNameLable.Text = "Team infomation of this player";

            subForm = true;
            ListViewForTOrP.Columns[0].Text = "Name";
            ListViewForTOrP.Columns[1].Text = "Number of players";
            ListViewForTOrP.Columns[2].Text = "Coach";
            ListViewForTOrP.Columns[3].Text = "Founded year";
            ListViewForTOrP.Columns[4].Text = "Ground";

           
                var row = new string[] { team.GetName(), team.GetNumberOfPlayer().ToString(), team.GetCoach(), team.GetFoundedYear().ToString(), team.GetGround()};
                var lvi = new ListViewItem(row);
                ListViewForTOrP.Items.Add(lvi);

        }





        private void ListViewForTOrP_SelectedIndexChanged(object sender, EventArgs e)// two cases of sub-form
        {
            if ((mode)&&(!subForm))//select a row of team to display player
            {
                if (ListViewForTOrP.SelectedItems.Count == 1)
                {
                    var selectedItem = (Team)ListViewForTOrP.SelectedItems[0].Tag;
                    if (selectedItem != null)
                    {
                        if (selectedItem.GetPlayer().Count() > 0)
                        {
                            ListOfPOrT listOfPOrT = new ListOfPOrT(selectedItem.GetPlayer());// print all contains players on the sub-form list
                            listOfPOrT.ShowDialog();
                        }
                    }
                }
            }
            else if ((!mode)&&(!subForm))//select a row of player to display team
            {
                if (ListViewForTOrP.SelectedItems.Count == 1)
                {
                    var selectedItem = (Team)ListViewForTOrP.SelectedItems[0].Tag;
                    if (selectedItem != null)
                    {
                        ListOfPOrT listOfPOrT = new ListOfPOrT(selectedItem);// print this team on the sub-form list
                        listOfPOrT.ShowDialog();
                    }
                }
            }
            
        }
    }
}
