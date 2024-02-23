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
using System.Collections.Specialized;
using System.Numerics;

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
        NameValueCollection DaysCollection = new NameValueCollection();
        
        NameValueCollection WeatherCollection = new NameValueCollection();
        NameValueCollection PlanCollection = new NameValueCollection();
        NameValueCollection HourCollection = new NameValueCollection();
        NameValueCollection MinuteCollection = new NameValueCollection();
        NameValueCollection HolidayCollection = new NameValueCollection();
        NameValueCollection BirthdayCollection = new NameValueCollection();
        NameValueCollection whichHolidayCollection = new NameValueCollection();
        NameValueCollection whosBDayCollection = new NameValueCollection();
        NameValueCollection DescriptionCollection = new NameValueCollection();
        
        /*
         *private Dictionary<DateTime, DayEvent> dateCollection = new Dictionary<dateTime,DayEvent>();
         *private List<DateTime> selectedDates;
         */

        //declare variables
        DateTime selected;
        private int count;
        public Day[] days;
        public Form1()
        {
            InitializeComponent();
            count = 0;
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
            /*
            DaysCollection.Add(selected.ToShortDateString(), weatherUpDown.Text);
            DaysCollection.Add(selected.ToShortDateString(), plansUpDown.Text);
            DaysCollection.Add(selected.ToShortDateString(), hourNum.Text);
            DaysCollection.Add(selected.ToShortDateString(), minuteNum.Text);
            DaysCollection.Add(selected.ToShortDateString(), holidayCheckBox.Checked.ToString());
            DaysCollection.Add(selected.ToShortDateString(), bDayCheckBox.Checked.ToString());
            DaysCollection.Add(selected.ToShortDateString(), holidayInfo.Text);
            DaysCollection.Add(selected.ToShortDateString(), bDayInfo.Text);
            DaysCollection.Add(selected.ToShortDateString(), descriptionText.Text);
            ClearObjects();
            //ClearCollections();
            */
            WeatherCollection.Add(selected.ToShortDateString(), weatherUpDown.Text);
            PlanCollection.Add(selected.ToShortDateString(), plansUpDown.Text);
            HourCollection.Add(selected.ToShortDateString(), hourNum.Text);
            MinuteCollection.Add(selected.ToShortDateString(), minuteNum.Text);
            HolidayCollection.Add(selected.ToShortDateString(), holidayCheckBox.Checked.ToString());
            BirthdayCollection.Add(selected.ToShortDateString(), bDayCheckBox.Checked.ToString());
            whichHolidayCollection.Add(selected.ToShortDateString(), holidayInfo.Text);
            whosBDayCollection.Add(selected.ToShortDateString(), bDayInfo.Text);
            DescriptionCollection.Add(selected.ToShortDateString(), descriptionText.Text);
            ClearObjects();
            
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            //ShowDay(days[current]);
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
            weatherUpDown.Text      = d.Weather.ToString();
            plansUpDown.Text        = d.Plan.ToString();
            hourNum.Text            = d.Hour.ToString();
            minuteNum.Text          = d.Minute.ToString();
            holidayCheckBox.Checked = d.Holiday;
            bDayCheckBox.Checked    = d.Birthday;
            holidayInfo.Text        = d.whichHoliday;
            bDayInfo.Text           = d.whosBDay;
            descriptionText.Text    = d.Description;
            ShowObjects();
        }

        private void ClearObjects()
        {
            weatherUpDown.Text = "Cloudy";
            plansUpDown.Text = "School";
            hourNum.Value = 0;
            minuteNum.Value = 0;
            holidayCheckBox.Checked = false;
            bDayCheckBox.Checked = false;
            holidayInfo.Text = "";
            bDayInfo.Text = "";
            descriptionText.Text = "";
        }

        private void ClearCollections()
        {
            
            WeatherCollection.Clear();
            PlanCollection.Clear();
            HourCollection.Clear();
            MinuteCollection.Clear();
            HolidayCollection.Clear();
            BirthdayCollection.Clear();
            whichHolidayCollection.Clear();
            whosBDayCollection.Clear();
            DescriptionCollection.Clear();
            
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
            
            Day d = new Day();
            
            if (d != null)
            {
                d.Weather      = (weatherType)Enum.Parse(typeof(weatherType), weatherUpDown.Text);
                d.Plan         = (plans)Enum.Parse(typeof(plans), plansUpDown.Text);
                //ints not working
                d.Hour         = int.Parse(hourNum.Text);
                d.Minute       = int.Parse(minuteNum.Text);
                d.Holiday      = holidayCheckBox.Checked;
                d.Birthday     = bDayCheckBox.Checked;
                d.whichHoliday = holidayInfo.Text;
                d.whosBDay     = bDayInfo.Text;
                d.Description  = descriptionText.Text;
                //DaysCollection[selected.ToShortDateString()] = "yyyy";
                //DaysCollection[selected.ToShortDateString()] = d.ToString();
            }
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
            //DayEvent d;
            //ShowDay(DaysCollection[selected]);
            //Day d;
            
            weatherUpDown.Text = WeatherCollection[e.Start.ToShortDateString()];
            plansUpDown.Text = PlanCollection[e.Start.ToShortDateString()];
            hourNum.Text = HourCollection[e.Start.ToShortDateString()];
            minuteNum.Text = MinuteCollection[e.Start.ToShortDateString()];
            if (HolidayCollection[e.Start.ToShortDateString()] == "true")
            {
                holidayCheckBox.Checked = true;
                currentLabel.Text = "yes";
            }
            else
            {
                holidayCheckBox.Checked = false;
                currentLabel.Text = "no";
            }
            if (BirthdayCollection[e.Start.ToShortDateString()] == "true")
                bDayCheckBox.Checked = true;
            else
                bDayCheckBox.Checked = false;
            //holidayCheckBox.Checked = HolidayCollection[e.Start.ToShortDateString()];
            //bDayCheckBox.Checked = BirthdayCollection[e.Start.ToShortDateString()];
            holidayInfo.Text = whichHolidayCollection[e.Start.ToShortDateString()];
            bDayInfo.Text = whosBDayCollection[e.Start.ToShortDateString()];
            descriptionText.Text = DescriptionCollection[e.Start.ToShortDateString()];
            
            //textBox1.Text = dateCollection[e.Start.ToShortDateString()];
            selected = e.Start;
            
        }
        /*

         */

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

    }
}
