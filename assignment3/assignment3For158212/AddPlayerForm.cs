using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryForAssignment3;

namespace assignment3For158212
{
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
            DateTimePicker.MaxDate = DateTime.Now;
        }

        public AddPlayerForm(List<Player> players)// handle normal situation, such as clicked the addplayer button
        {
            InitializeComponent();
            DateTimePicker.MaxDate = DateTime.Now;
            this.players = players;
            SuggestionLable.Text = null;
        }


        public AddPlayerForm(List<Player> players, string[] players2)// to handle the situation that player's ID is dupliicated but has team 
        {
            InitializeComponent();
            DateTimePicker.MaxDate = DateTime.Now;
            SuggestionLable.Text = null;
            this.players = players;
            NameTextBox.Text = players2[1].Trim();
            TeamTextBox.Text = players2[2].Trim();

            string[] sArray = players2[3].Trim().Split('/');// this part is used transfer the date from string to DateTime
            if (int.Parse(sArray[0]) < 10)
            {
                sArray[0] = '0' + sArray[0];
            }
            if (int.Parse(sArray[1]) < 10)
            {
                sArray[1] = '0' + sArray[1];
            }
            string sBeConverted = sArray[0] + sArray[1] + sArray[2];
            DateTime dateTime = DateTime.ParseExact(sBeConverted, "ddmmyyyy", new CultureInfo("en-US", true));
            DateTimePicker.Value = dateTime;

            WeightValue.Value = int.Parse(players2[4].Trim());
            HeightValue.Value = int.Parse(players2[5].Trim());
            BornPlaceTextBox.Text = players2[6].Trim();

            int i = 0;//this part is for give the suggested ID
            while ((players.Exists((Player P) => P.GetID() == i)))
            {
                i++;
            }
            SuggestionLable.Text = "Suggested ID: " + i;
            IDNumericUpDown.Value = i;
        }

        private List<Player> players = new List<Player>();
        private bool yesOrNo = false;// determin if user clicked the yes or no button
        private string date;//birthdate
        private Player addedPlayer;// used to return the player that added

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            date = DateTimePicker.Value.Day.ToString() + '/' + DateTimePicker.Value.Month.ToString() + '/' + DateTimePicker.Value.Year.ToString();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if ((NameTextBox.Text == String.Empty) || (TeamTextBox.Text == String.Empty) || (WeightValue.Value == 0) || (HeightValue.Value == 0) || (BornPlaceTextBox.Text == String.Empty))// makesure the user fill all the empty text box, otherwise the tip will comes out
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

                if (TeamTextBox.Text == String.Empty)
                {
                    StarLabel2.Visible = true;
                    EmptyTip.Visible = true;
                }
                else
                {
                    StarLabel2.Visible = false;
                    EmptyTip.Visible = false;
                }

                if (HeightValue.Value == 0)
                {
                    StarLabel3.Visible = true;
                    EmptyTip.Visible = true;
                }
                else
                {
                    StarLabel3.Visible = false;
                    EmptyTip.Visible = false;
                }

                if (WeightValue.Value == 0)
                {
                    StarLabel4.Visible = true;
                    EmptyTip.Visible = true;
                }
                else
                {
                    StarLabel4.Visible = false;
                    EmptyTip.Visible = false;
                }

                if (BornPlaceTextBox.Text == String.Empty)
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
            else
            {

                StarLabel1.Visible = false;// set the red stars invisiable because all the empty is been fiiled
                StarLabel2.Visible = false;
                StarLabel3.Visible = false;
                StarLabel4.Visible = false;
                StarLabel5.Visible = false;
                EmptyTip.Visible = false;

                date = DateTimePicker.Value.Day.ToString() + '/' + DateTimePicker.Value.Month.ToString() + '/' + DateTimePicker.Value.Year.ToString();

                if (int.Parse(IDNumericUpDown.Value.ToString()) == -1)// Deafult situation without set the ID
                {
                    int i = 0;// find smallest avaliable ID
                    while ((players.Exists((Player P) => P.GetID() == i))){
                        i++;
                    }
                    addedPlayer = new Player(i, NameTextBox.Text.Trim(), TeamTextBox.Text.Trim(), date, byte.Parse(HeightValue.Value.ToString()), byte.Parse(WeightValue.Value.ToString()), BornPlaceTextBox.Text.Trim());
                    yesOrNo = true; 
                    this.Close();
                }

                else if (!players.Exists((Player P) => P.GetID() == int.Parse(IDNumericUpDown.Value.ToString())))// set ID and ID is not exist
                {
                    addedPlayer = new Player(int.Parse(IDNumericUpDown.Value.ToString()), NameTextBox.Text.Trim(), TeamTextBox.Text.Trim(), date, byte.Parse(HeightValue.Value.ToString()), byte.Parse(WeightValue.Value.ToString()), BornPlaceTextBox.Text.Trim());
                    yesOrNo = true;
                    this.Close();
                }
                else if (players.Exists((Player P) => P.GetID() == int.Parse(IDNumericUpDown.Value.ToString())))// set ID and ID is exist
                {
                    MessageBox.Show("This ID is already exist, please change it" + "\n" + "and a suggested ID is placed below", "Tip!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    int i = 0;// find smallest avaliable ID
                    while ((players.Exists((Player P) => P.GetID() == i))){
                        i++;
                    }
                    SuggestionLable.Text = "Suggested ID: " + i ;
                    IDNumericUpDown.Value = i;
                }
            }
        }

        public bool GetYesOrNo()
        {
            return yesOrNo;
        }

        public Player GetPlayer()
        {
            return addedPlayer;
        }

        public string GetTeam()
        {
            return TeamTextBox.Text;
        }

        private void CanceledButton_Click(object sender, EventArgs e)
        {
            yesOrNo = false;
            this.Close();
        }
    }
}
