using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryForAssignment3;

namespace assignment3For158212
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();

        }

        public Chart(List<Player> player, int mode)//different mode stand for different chart
        {
            InitializeComponent();
            PlayerChartOne.Series.Clear(); 
            if (mode == 1)//weight
            {
                foreach(var P in player)
                {
                    PlayerChartOne.Series.Add(P.GetName());
                    PlayerChartOne.Series[P.GetName()].Points.AddXY("Weight", P.GetWeight());
                }

            } 
            else if(mode == 2)//height
            {
                foreach (var P in player)
                {
                    PlayerChartOne.Series.Add(P.GetName());
                    PlayerChartOne.Series[P.GetName()].Points.AddXY("Height", P.GetHeight());
                }
            }
            else if (mode == 3)//age
            {
                PlayerChartOne.Series.Add("Age <= 10");
                PlayerChartOne.Series.Add("10 < Age <= 20");
                PlayerChartOne.Series.Add("20 < Age <= 30");
                PlayerChartOne.Series.Add("30 < Age <= 40");
                PlayerChartOne.Series.Add("40 < Age <= 50");
                PlayerChartOne.Series.Add("50 < Age <= 60");
                PlayerChartOne.Series.Add("Age > 60");
                var groups = new int[8];

                foreach (var P in player)
                {
                    if (P.GetAge() <= 10)// increase 1 if this player's age fit the gap;
                    {
                        groups[0]++;
                    }
                    else if ((10 < P.GetAge())&&(P.GetAge() <= 20))
                    {
                        groups[1]++;
                    }
                    else if ((20 < P.GetAge())&& (P.GetAge()) <= 30)
                    {
                        groups[2]++;
                    }
                    else if ((30 < P.GetAge())&& (P.GetAge()) <= 40)
                    {
                        groups[3]++;
                    }
                    else if ((40 < P.GetAge())&& (P.GetAge()) <= 50)
                    {
                        groups[4]++;
                    }
                    else if ((50 < P.GetAge())&& (P.GetAge()) <= 60)
                    {
                        groups[5]++;
                    }
                    else if(P.GetAge() > 60)
                    {
                        groups[7]++;
                    } 
                }
                
                PlayerChartOne.Series["Age <= 10"].Points.AddXY("Age", groups[0]);
                PlayerChartOne.Series["10 < Age <= 20"].Points.AddXY("Age", groups[1]);
                PlayerChartOne.Series["20 < Age <= 30"].Points.AddXY("Age", groups[2]);
                PlayerChartOne.Series["30 < Age <= 40"].Points.AddXY("Age", groups[3]);
                PlayerChartOne.Series["40 < Age <= 50"].Points.AddXY("Age", groups[4]);
                PlayerChartOne.Series["50 < Age <= 60"].Points.AddXY("Age", groups[5]);
                PlayerChartOne.Series["Age > 60"].Points.AddXY("Age", groups[6]);
                

            }
        }
    }
}
