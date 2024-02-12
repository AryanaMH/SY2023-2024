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

//Goal: Allow user to save info about schedule
//When a date is selected, show and edit plans for that day
//Include:
//  Calendar, Textbox(multiline), check box, time, enum selecter
//  4 fields including a bool & enum

namespace SchedulePlanner
{
    public enum morningPlans
    {

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
