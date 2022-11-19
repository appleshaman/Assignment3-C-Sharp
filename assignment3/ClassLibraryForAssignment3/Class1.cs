using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForAssignment3
{

    public class Team
    {
        private string name;
        private string ground;
        private string coach;
        private short foundedYear;
        private string region;
        private List<Player> listOfPlayers = new List<Player>();

        public Team(string name, string ground, string coach, short foundedYear, string region)
        {
            this.name = name;
            this.ground = ground;
            this.coach = coach;
            this.foundedYear = foundedYear;
            this.region = region;
        }

        public void AddPlayer(Player player)
        {
            listOfPlayers.Add(player);
        }

        public string GetName()
        {
            return name;
        }

        public string GetGround()
        {
            return ground;
        }

        public string GetCoach()
        {
            return coach;
        }

        public short GetFoundedYear()
        {
            return foundedYear;
        }

        public string GetRegion()
        {
            return region;
        }

        public int GetNumberOfPlayer()
        {
            return listOfPlayers.Count();
        }

        public List<Player> GetPlayer()
        {
            return listOfPlayers;
        }

        public string GetInformation()
        {
            return name + "; " + ground + "; " + coach + "; Founded " + foundedYear + ", " + ground;
        }
    }





    public class Player
    {
        private int ID;
        private string name;
        private string birthDate;
        private byte height;
        private byte weight;
        private string placeOfBirth;
        private string team;

        public Player(int ID, string name, string team, string birthDate, byte height, byte weight, string placeOfBirth)
        {
            this.ID = ID;
            this.name = name;
            this.birthDate = birthDate;
            this.height = height;
            this.weight = weight;
            this.placeOfBirth = placeOfBirth;
            this.team = team;
        }

        public string GetName()
        {
            return name;
        }

        public string GetBirthdate()
        {
            return birthDate;
        }

        public string GetPlaceOfBirth()
        {
            return placeOfBirth;
        }

        public int GetID()
        {
            return ID;
        }



        public byte GetWeight()
        {
            return weight;
        }

        public byte GetHeight()
        {
            return height;
        }

        public string GetTeam()
        {
            return team;
        }

        public void SetTeam(string team)
        {
            this.team = team;
        }

        public int GetAge()
        {
            DateTime dateTime = DateTime.Now;

            string[] sArray = birthDate.Split('/');
            if (int.Parse(sArray[0]) < 10)
            {
                sArray[0] = '0' + sArray[0];
            }
            if (int.Parse(sArray[1]) < 10)
            {
                sArray[1] = '0' + sArray[1];
            }
            string sBeConverted = sArray[0] + sArray[1] + sArray[2];
            DateTime dateTimeConverted = DateTime.ParseExact(sBeConverted, "ddmmyyyy", new CultureInfo("en-US", true));

            int age = dateTime.Year - dateTimeConverted.Year;
            if (dateTime.Month < dateTimeConverted.Month)
            {
                age--;
            }
            else if ((dateTime.Month == dateTimeConverted.Month) && (dateTime.Day < dateTimeConverted.Day))
            {
                age--;
            }
            return age;
        }

        public string GetInformation()
        {
            return ID.ToString() + "; " + team + "; " + birthDate + "; " + height.ToString() + "; " + weight.ToString() + "; " + placeOfBirth;
        }
    }


}


