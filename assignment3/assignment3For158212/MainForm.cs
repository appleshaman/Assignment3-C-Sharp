using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using ClassLibraryForAssignment3;

namespace assignment3For158212
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Team> teams = new List<Team>();// store the teams
        private List<Player> players = new List<Player>();// store the players

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyOpenFileDialog.Filter = "Text file | *.txt";
            if (MyOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                int playerAdded = 0;// record how many players are added in this section
                int teamAdded = 0;// record how many teams are added in this section
                using (FileStream fStream = File.OpenRead(MyOpenFileDialog.FileName))
                {

                    StreamReader reader;
                    reader = new StreamReader(fStream);
                    string line;
                    List<string[]> noTeamPlayer = new List<string[]>();// to stroe the player who has no team

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] sArray = line.Split(';');
                        if (sArray.Length == 4)// it is a team
                        {
                            if (!teams.Exists((Team T) => T.GetName() == sArray[0].Trim()))//skip exist team, only exist team can be added
                            {
                                string[] tempString1 = sArray[3].Trim().Split(',');//split founded year and region
                                string[] tempString2 = tempString1[0].Split(' ');//split 'founded' and year
                                teams.Add(new Team(sArray[0].Trim(), sArray[1].Trim(), sArray[2].Trim(), short.Parse(tempString2[1].Trim()), tempString1[1].Trim()));
                                teamAdded++;
                            }
                        }
                        else if (sArray.Length == 7)// it is a player
                        {
                            if (players.Exists((Player P) => P.GetID() == int.Parse(sArray[0].Trim())))// ID is duplicated
                            {
                                MessageBox.Show("This player's ID is already exist, please change it, and a suggested ID is placed below", "Tip!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                AddPlayerForm addPlayerForm = new AddPlayerForm(players, sArray);
                                addPlayerForm.ShowDialog();
                                if (addPlayerForm.GetYesOrNo())
                                {
                                    if (teams.Exists((Team T) => T.GetName() == sArray[2].Trim()))//ID is duplicated but have team
                                    {
                                        teams[teams.FindIndex((Team T) => T.GetName() == sArray[2].Trim())].AddPlayer(addPlayerForm.GetPlayer());
                                        players.Add(addPlayerForm.GetPlayer());
                                        playerAdded++;
                                        continue;
                                    }
                                    else if (!teams.Exists((Team T) => T.GetName() == sArray[2].Trim()))//ID is duplicated but do not have team
                                    {
                                        Player tempPlayer;
                                        tempPlayer = addPlayerForm.GetPlayer();
                                        
                                        while ((!teams.Exists((Team T) => T.GetName() == addPlayerForm.GetTeam())))//ID is duplicated but do not have team
                                        {
                                            Tip noTeamFound = new Tip();
                                            noTeamFound.SetMessage("This player's team is not exist in the list, do you want to add the team for him/her?");
                                            noTeamFound.ShowDialog();
                                            AddTeamForm addTeamForm = new AddTeamForm();
                                            if (noTeamFound.GetYesOrNo())//confirm to add a team(click can cancle on the tip form)
                                            {
                                                addTeamForm.ShowDialog();
                                                if (addTeamForm.GetYesOrNo())//team are added
                                                {
                                                    Team tempTeam;
                                                    tempTeam = addTeamForm.GetTeam();
                                                    tempPlayer.SetTeam(tempTeam.GetName());
                                                    tempTeam.AddPlayer(tempPlayer);
                                                    teams.Add(tempTeam);
                                                    players.Add(tempPlayer);
                                                    EventRichTextBox.AppendText("One player who has no team and one new team for this player has been added at" + DateTime.Now.ToString() + "\n");
                                                    break;
                                                }

                                            }
                                            else if (!noTeamFound.GetYesOrNo() || (noTeamFound.GetYesOrNo() && addTeamForm.GetYesOrNo()))// cancel to add the team
                                            {
                                                addPlayerForm.ShowDialog();//open the dialog again allows user do more modiication of user infomation
                                            }
                                        }
                                    }
                                }
                                else if (!addPlayerForm.GetYesOrNo())//jump to next line of reading
                                {
                                    continue;
                                }
                            }
                            else if (!players.Exists((Player P) => P.GetID() == int.Parse(sArray[0].Trim())) && (teams.Exists((Team T) => T.GetName() == sArray[2].Trim())))// have team and ID is not duplicated
                            {
                                teams[teams.FindIndex((Team T) => T.GetName() == sArray[2].Trim())].AddPlayer(new Player(int.Parse(sArray[0].Trim()), sArray[1].Trim(), sArray[2].Trim(), sArray[3].Trim(), byte.Parse(sArray[4].Trim()), byte.Parse(sArray[5].Trim()), sArray[6].Trim()));
                                players.Add(new Player(int.Parse(sArray[0].Trim()), sArray[1].Trim(), sArray[2].Trim(), sArray[3].Trim(), byte.Parse(sArray[4].Trim()), byte.Parse(sArray[5].Trim()), sArray[6].Trim()));
                                playerAdded++;
                            }

                            else//do not have team and ID is not duplicated
                            {
                                noTeamPlayer.Add(sArray);
                            }

                        }
                    }
                    EventRichTextBox.AppendText("File was read at " + DateTime.Now.ToString() + "\n");// indicate the file was read
                    int addedSuccf = 0;// added player that has no team
                    while (noTeamPlayer.Count() != 0)
                    {

                        int i;
                        bool ifFounded = false;
                        for(i = 0; i < noTeamPlayer.Count(); i++)//check again if this player's team has been addded at every start of the loop ( the situation that taled in the manunal about two noteam player who got the same team, but the first one is added at last loop,then the second one can be added automatically by this 
                        {
                            if (teams.Exists((Team T) => T.GetName() == noTeamPlayer[i][2].Trim())){
                                ifFounded = true;
                                break;
                            }
                        }
                        if (ifFounded)
                        {
                            teams[teams.FindIndex((Team T) => T.GetName() == noTeamPlayer[i][2].Trim())].AddPlayer(new Player(int.Parse(noTeamPlayer[i][0].Trim()), noTeamPlayer[i][1].Trim(), noTeamPlayer[i][2].Trim(), noTeamPlayer[i][3].Trim(), byte.Parse(noTeamPlayer[i][4].Trim()), byte.Parse(noTeamPlayer[i][5].Trim()), noTeamPlayer[i][6].Trim()));
                            teams.Count();
                            players.Add(new Player(int.Parse(noTeamPlayer[i][0].Trim()), noTeamPlayer[i][1].Trim(), noTeamPlayer[i][2].Trim(), noTeamPlayer[i][3].Trim(), byte.Parse(noTeamPlayer[i][4].Trim()), byte.Parse(noTeamPlayer[i][5].Trim()), noTeamPlayer[i][6].Trim()));
                            playerAdded++;
                            addedSuccf++;
                            noTeamPlayer.RemoveAt(i);
                        }


                        Tip noTeamTip = new Tip(noTeamPlayer);
                        noTeamTip.ShowDialog();
                        if (noTeamTip.GetYesOrNo())
                        {
                            AddTeamForm addTeamForm = new AddTeamForm(noTeamPlayer,teams); // always add the last player in the no team player list
                            addTeamForm.ShowDialog();
                            if (addTeamForm.GetYesOrNo())
                            {
                                players.Add(addTeamForm.GetPlayer());
                                teams.Add(addTeamForm.GetTeam());
                                noTeamPlayer.RemoveAt(noTeamPlayer.Count() - 1);// always add the last player in the no team player list then remove it 
                                addedSuccf++;
                                playerAdded++;
                            }
                            else if (!addTeamForm.GetYesOrNo())
                            {
                                noTeamPlayer.RemoveAt(noTeamPlayer.Count() - 1);
                            }
                        }
                        else if (!noTeamTip.GetYesOrNo())// cancel it add this player, this will skip to add this player
                        {
                            noTeamPlayer.RemoveAt(noTeamPlayer.Count() - 1);
                        }
                    }
                    EventRichTextBox.AppendText(addedSuccf.ToString() + " player(s) who had no team were added at " + DateTime.Now.ToString() + "\n");
                }
                EventRichTextBox.AppendText(playerAdded + " player(s) and " + teamAdded + " team(s) were added at " + DateTime.Now.ToString() + "\n");
            }
        }

        private void SaveAllTeamsAndPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFiles(players, teams);
            EventRichTextBox.AppendText("All exist player(s) and team(s) had been added at " + DateTime.Now.ToString() + "\n");
        }

        private void SaveAllTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFiles(null, teams);
            EventRichTextBox.AppendText("All exist team(s) had been added at " + DateTime.Now.ToString() + "\n");
        }

        private void SaveAllPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFiles(players, null);
            EventRichTextBox.AppendText("All exist player(s) had been added at " + DateTime.Now.ToString() + "\n");
        }

        private void AddPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddPlayerForm addPlayerForm = new AddPlayerForm(players);
            addPlayerForm.ShowDialog();
            if (addPlayerForm.GetYesOrNo())//Confirm to add the player
            {
                Player tempPlayer;
                bool ifAdded = false;
                tempPlayer = addPlayerForm.GetPlayer();
                while ((!teams.Exists((Team T) => T.GetName() == addPlayerForm.GetTeam())))//Team not exist
                {
                    Tip noTeamFound = new Tip();
                    noTeamFound.SetMessage("This player's team is not exiting on the list" + "\n" + "do you want to add the team for him/her?");
                    noTeamFound.ShowDialog();
                    AddTeamForm addTeamForm = new AddTeamForm(addPlayerForm.GetTeam(),teams);
                    if (noTeamFound.GetYesOrNo())//confirm to add a team
                    {
                        addTeamForm.ShowDialog();
                        if (addTeamForm.GetYesOrNo())//team are added
                        {
                            Team tempTeam;
                            tempTeam = addTeamForm.GetTeam();
                            tempPlayer.SetTeam(tempTeam.GetName());
                            tempTeam.AddPlayer(tempPlayer);
                            teams.Add(tempTeam);
                            players.Add(tempPlayer);
                            ifAdded = true;
                            EventRichTextBox.AppendText("One player who has no team and one new team for this player had been added at " + DateTime.Now.ToString() + "\n");
                            break;
                        }
                    }
                    else if (!noTeamFound.GetYesOrNo() || (noTeamFound.GetYesOrNo() && addTeamForm.GetYesOrNo()))// cancle to add the team
                    {
                        ifAdded = false;
                        addPlayerForm.ShowDialog();
                    }
                    if (!addPlayerForm.GetYesOrNo())
                    {
                        ifAdded = false;
                        addPlayerForm.Close();
                        break;
                    }

                }
                if (teams.Exists((Team T) => T.GetName() == addPlayerForm.GetTeam()) && (!ifAdded))//team is exist and not added by the above code
                {
                    teams[teams.FindIndex((Team T) => T.GetName() == addPlayerForm.GetTeam())].AddPlayer(tempPlayer);
                    players.Add(tempPlayer);
                    EventRichTextBox.AppendText("One player has been added at " + DateTime.Now.ToString() + "\n");
                }
            }
        }

        private void AddTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm(teams);
            addTeamForm.ShowDialog();
            if (addTeamForm.GetYesOrNo())
            {
                teams.Add(addTeamForm.GetTeam());
                EventRichTextBox.AppendText("One team has been added at " + DateTime.Now.ToString() + "\n");
            }// varify if this is empty
        }

        private void WeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (players.Count() != 0)
            {
                Chart chart = new Chart(players, 1);
                chart.ShowDialog();
            }
            else
            {
                EventRichTextBox.AppendText("There is no players on the record yet at " + DateTime.Now.ToString() + "\n");
            }// varify if this is empty
        }

        private void HeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (players.Count() != 0)
            {
                Chart chart = new Chart(players, 2);
                chart.ShowDialog();
            }
            else
            {
                EventRichTextBox.AppendText("There is no players on the record yet at " + DateTime.Now.ToString() + "\n");
            }// varify if this is empty
        }

        private void AgeGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (players.Count() != 0)
            {
                Chart chart = new Chart(players, 3);
                chart.ShowDialog();
            }
            else
            {
                EventRichTextBox.AppendText("There is no players on the record yet at " + DateTime.Now.ToString() + "\n");
            }// varify if this is empty
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EventRichTextBox.Clear();
        }

        private void PlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (players.Count() != 0)
            {
                SearchResult searchResult = new SearchResult(players);
                searchResult.ShowDialog();
            }
            else
            {
                EventRichTextBox.AppendText("There is no players on the record yet at " + DateTime.Now.ToString() + "\n");
            }// varify if this is empty

        }

        private void PlayerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((players.Count() != 0) && (teams.Count() != 0))
            {
                ListOfPOrT listOfPOrT = new ListOfPOrT(players, teams);
                listOfPOrT.ShowDialog();
            }
            else
            {
                EventRichTextBox.AppendText("There is no players on the record yet at " + DateTime.Now.ToString() + "\n");
            }// varify if this is empty
            
        }

        private void TeamsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (teams.Count() != 0)
            {
                ListOfPOrT listOfPOrT = new ListOfPOrT(teams);
                listOfPOrT.ShowDialog();
            }
            else
            {
                EventRichTextBox.AppendText("There is no teams on the record yet at " + DateTime.Now.ToString() + "\n");
            }// varify if this is empty
        }

        private void SaveFiles(List<Player> players, List<Team> teams)
        {
            MySaveFileDialog.Filter = "Text file | *.txt";// only txt is allowed
            if (MySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(MySaveFileDialog.OpenFile());
                if(players != null)
                {
                    if (players.Count() > 0)
                    {
                        foreach (var p in teams)
                        {
                            streamWriter.WriteLine(p.GetName() + "; " + p.GetGround() + "; " + p.GetCoach() + "; Founded " + p.GetFoundedYear() + "," + p.GetRegion());//write the team into the file
                        }
                    }
                }
                if(teams != null)
                {
                    if (teams.Count() > 0)
                    {
                        foreach (var p in players)
                        {
                            streamWriter.WriteLine(p.GetID().ToString() + "; " + p.GetName() + "; " + p.GetTeam() + "; " + p.GetBirthdate() + "; " + p.GetHeight() + "; " + p.GetWeight() + "; " + p.GetPlaceOfBirth());// write the player into the file
                        }
                    }
                }
                streamWriter.Close();
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For any help about using, please chekck the user manual.", "Tip!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
