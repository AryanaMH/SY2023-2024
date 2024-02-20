using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

//Goal: Allow user to save info about schedule
//When a date is selected, show and edit plans for that day
//Include:
//  Calendar, Textbox(multiline), check box, time, enum selecter
//  4 fields including a bool & enum

namespace SchedulePlanner
{
    public enum weatherType
    {
        Cloudy, Rainy, Snowy, Stormy, Sunny
    }

    public enum plans
    {
        School, Work, Exercise, Relax, Doctor, Dentist, Other
    }
    public partial class Form1 : Form
    {
        //declare variables
        private int current;
        private int count;
        public Day[] days;
        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            currentLabel.Text = current.ToString();
            //days = new Day[count];
            days = new Day[50];
        }
//User interactions
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Days.txt"))
            {
                StreamReader inFile = new StreamReader("Days.txt");
                while (!inFile.EndOfStream)
                {
                    string S = inFile.ReadLine();
                    Day d = JsonSerializer.Deserialize<Day>(S);
                    days[count] = d;
                    count++;
                }
                inFile.Close();
                ShowDay(days[0]);
            }
            else
            {
                Day d = new Day();
                d.Weather      = weatherType.Cloudy;
                d.Plan         = plans.School;
                d.Hour         = 7;
                d.Minute       = 30;
                d.Holiday      = false;
                d.Birthday     = false;
                d.whichHoliday = "";
                d.whosBDay     = "";
                d.Description  = "";
                count = 1;
                days[0] = d;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            ShowDay(days[current]);
        }
        private void holidayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowObjects();
        }

        private void bDayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowObjects();
        }

        private void plansUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            ShowObjects();
        }
        private void ShowDay(Day d)
        {
            weatherUpDown.Text = d.Weather.ToString();
            plansUpDown.Text = d.Plan.ToString();
            hourNum.Text = d.Hour.ToString();
            minuteNum.Text = d.Minute.ToString();
            holidayCheckBox.Checked = d.Holiday;
            bDayCheckBox.Checked = d.Birthday;
            holidayInfo.Text = d.whichHoliday;
            bDayInfo.Text = d.whosBDay;
            descriptionText.Text = d.Description;
            ShowObjects();
        }

        //Save
        private void Save()
        {
            UpdateDay();
            StreamWriter outFile = new System.IO.StreamWriter("Days.txt");
            for (int i = 0; i < count; i++)
            {
                string jsonString = JsonSerializer.Serialize(days[i]);
                outFile.WriteLine(jsonString);
            }
            outFile.Close();
        }

        private void UpdateDay()
        {
            Day d = days[current];
            if (d != null)
            {
                d.Weather      = (weatherType)Enum.Parse(typeof(weatherType), weatherUpDown.Text);
                d.Plan         = (plans)Enum.Parse(typeof(plans), plansUpDown.Text);
                d.Hour         = int.Parse(hourNum.Text);
                d.Minute       = int.Parse(minuteNum.Text);
                d.Holiday      = holidayCheckBox.Checked;
                d.Birthday     = bDayCheckBox.Checked;
                d.whichHoliday = holidayInfo.Text;
                d.whosBDay     = bDayInfo.Text;
                d.Description  = descriptionText.Text;
            }
        }

//Declare Day
        public class Day
        {
            public weatherType Weather { get; set; }
            public plans Plan { get; set; }
            public int Hour { get; set; }
            public int Minute { get; set; }
            public bool Holiday { get; set; }
            public bool Birthday { get; set; }
            public string whichHoliday { get; set; }
            public string whosBDay { get; set; }
            public string Description { get; set; }
        }



        private void ShowObjects()
        {
        //plans
            if (plansUpDown.Text == "Other")
            {
                descriptionLabel.Visible = true;
                descriptionText.Visible = true;
                timeLabel.Visible = true;
                hourLabel.Visible = true;
                minuteLabel.Visible = true;
                hourNum.Visible = true;
                minuteNum.Visible = true;
            }
            else
            {
                descriptionLabel.Visible = false;
                descriptionText.Visible = false;
                timeLabel.Visible = false;
                hourLabel.Visible = false;
                minuteLabel.Visible = false;
                hourNum.Visible = false;
                minuteNum.Visible = false;
            }
        //bDay
            if (bDayCheckBox.Checked)
            {
                bDayInfo.Visible = true;
            }
            else
            {
                bDayInfo.Visible = false;
            }
        //holiday
            if (holidayCheckBox.Checked)
            {
                holidayInfo.Visible = true;
            }
            else
            {
                holidayInfo.Visible = false;
            }
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //ShowDay(days[current]);
        }
    }
}
