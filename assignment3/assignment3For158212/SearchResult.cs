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
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        private List<Player> player = new List<Player>();

        public SearchResult(List<Player> player)// import the list of player
        {
            InitializeComponent();
            this.player = player;
        }


        private List<Player> matchedPlayer = new List<Player>();// store the imported player list.

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ListOfPlayer.Items.Clear(); //clean the listview every time user clicked the search button and reset each coloum.

            matchedPlayer = null;
            if (SearchTextBox.Text.Trim() == String.Empty)// if user entered nothing but still clicked search
            {
                MessageBox.Show("The left text box can not be empty!", "Tip!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!IsNotNumeric(SearchTextBox.Text.Trim()))// the user entered an age
                {
                    if (player.Exists((Player P) => P.GetAge() == int.Parse(SearchTextBox.Text.Trim())))
                    {
                        matchedPlayer = player.FindAll((Player P) => P.GetAge() == int.Parse(SearchTextBox.Text.Trim()));
                    } 
                }
                else if (IsNotNumeric(SearchTextBox.Text.Trim()))// the user entered an born place
                {
                    matchedPlayer = (from c in player where c.GetPlaceOfBirth().ToLower().Contains(SearchTextBox.Text.Trim().ToLower()) select c).ToList();// searching support fuzzy search and user does not have to worry about the upper case or lower case
                }
                if ((matchedPlayer == null)||(matchedPlayer.Count() == 0))// if did not find any player matches the reslt
                {
                    MessageBox.Show("No players founded!", "Tip!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (matchedPlayer != null)// if find the players, then print them on the list
                {
                    foreach (var p in matchedPlayer)
                    {
                        
                        var players = new string[] { p.GetName(),p.GetTeam(), p.GetID().ToString(), p.GetAge().ToString(), p.GetPlaceOfBirth(), p.GetWeight().ToString(), p.GetHeight().ToString() };
                        var lvi = new ListViewItem(players);
                        ListOfPlayer.Items.Add(lvi);
                    }
                }
            }
        }

        private bool IsNotNumeric(string Str)// dertermin if the string is digit, even one leter can make the string be considered as a non digit string.
        {
            bool notDigit = false;
            for (int i = 0; i < Str.Length; i++)
            {
                if (!Char.IsDigit(Str[i]))
                {
                    notDigit = true;
                }
            }
            return notDigit;
        }


    }





}
