namespace SchedulePlanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.holidayCheckBox = new System.Windows.Forms.CheckBox();
            this.bDayCheckBox = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.hourNum = new System.Windows.Forms.NumericUpDown();
            this.weatherUpDown = new System.Windows.Forms.DomainUpDown();
            this.hourLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.minuteNum = new System.Windows.Forms.NumericUpDown();
            this.timeLabel = new System.Windows.Forms.Label();
            this.holidayInfo = new System.Windows.Forms.TextBox();
            this.bDayInfo = new System.Windows.Forms.TextBox();
            this.currentLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.plansUpDown = new System.Windows.Forms.DomainUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.hourNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNum)).BeginInit();
            this.SuspendLayout();
            // 
            // holidayCheckBox
            // 
            this.holidayCheckBox.AutoSize = true;
            this.holidayCheckBox.Location = new System.Drawing.Point(426, 38);
            this.holidayCheckBox.Name = "holidayCheckBox";
            this.holidayCheckBox.Size = new System.Drawing.Size(76, 20);
            this.holidayCheckBox.TabIndex = 1;
            this.holidayCheckBox.Text = "Holiday";
            this.holidayCheckBox.UseVisualStyleBackColor = true;
            this.holidayCheckBox.CheckedChanged += new System.EventHandler(this.holidayCheckBox_CheckedChanged);
            // 
            // bDayCheckBox
            // 
            this.bDayCheckBox.AutoSize = true;
            this.bDayCheckBox.Location = new System.Drawing.Point(426, 86);
            this.bDayCheckBox.Name = "bDayCheckBox";
            this.bDayCheckBox.Size = new System.Drawing.Size(78, 20);
            this.bDayCheckBox.TabIndex = 2;
            this.bDayCheckBox.Text = "Birthday";
            this.bDayCheckBox.UseVisualStyleBackColor = true;
            this.bDayCheckBox.CheckedChanged += new System.EventHandler(this.bDayCheckBox_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(351, 450);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(18, 125);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 6;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(395, 232);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(200, 141);
            this.descriptionText.TabIndex = 8;
            this.descriptionText.Visible = false;
            // 
            // hourNum
            // 
            this.hourNum.Location = new System.Drawing.Point(643, 251);
            this.hourNum.Name = "hourNum";
            this.hourNum.Size = new System.Drawing.Size(120, 22);
            this.hourNum.TabIndex = 9;
            this.hourNum.Visible = false;
            // 
            // weatherUpDown
            // 
            this.weatherUpDown.Items.Add("Cloudy");
            this.weatherUpDown.Items.Add("Rainy");
            this.weatherUpDown.Items.Add("Snowy");
            this.weatherUpDown.Items.Add("Stormy");
            this.weatherUpDown.Items.Add("Sunny");
            this.weatherUpDown.Location = new System.Drawing.Point(593, 60);
            this.weatherUpDown.Name = "weatherUpDown";
            this.weatherUpDown.Size = new System.Drawing.Size(120, 22);
            this.weatherUpDown.TabIndex = 10;
            this.weatherUpDown.Text = "Cloudy";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(640, 232);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(36, 16);
            this.hourLabel.TabIndex = 11;
            this.hourLabel.Text = "Hour";
            this.hourLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Weather";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(392, 213);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(126, 16);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description of Plans";
            this.descriptionLabel.Visible = false;
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(640, 276);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(46, 16);
            this.minuteLabel.TabIndex = 15;
            this.minuteLabel.Text = "Minute";
            this.minuteLabel.Visible = false;
            // 
            // minuteNum
            // 
            this.minuteNum.Location = new System.Drawing.Point(643, 295);
            this.minuteNum.Name = "minuteNum";
            this.minuteNum.Size = new System.Drawing.Size(120, 22);
            this.minuteNum.TabIndex = 14;
            this.minuteNum.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(604, 212);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(89, 16);
            this.timeLabel.TabIndex = 16;
            this.timeLabel.Text = "Time of Event";
            this.timeLabel.Visible = false;
            // 
            // holidayInfo
            // 
            this.holidayInfo.Location = new System.Drawing.Point(426, 58);
            this.holidayInfo.Name = "holidayInfo";
            this.holidayInfo.Size = new System.Drawing.Size(100, 22);
            this.holidayInfo.TabIndex = 17;
            this.holidayInfo.Text = "Which Holiday?";
            this.holidayInfo.Visible = false;
            // 
            // bDayInfo
            // 
            this.bDayInfo.Location = new System.Drawing.Point(426, 112);
            this.bDayInfo.Name = "bDayInfo";
            this.bDayInfo.Size = new System.Drawing.Size(100, 22);
            this.bDayInfo.TabIndex = 18;
            this.bDayInfo.Text = "Who\'s Birthday?";
            this.bDayInfo.Visible = false;
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(567, 425);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(81, 16);
            this.currentLabel.TabIndex = 19;
            this.currentLabel.Text = "currentLabel";
            this.currentLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(53, 350);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(134, 350);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 21;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Plans";
            // 
            // plansUpDown
            // 
            this.plansUpDown.Items.Add("School");
            this.plansUpDown.Items.Add("Work");
            this.plansUpDown.Items.Add("Exercise");
            this.plansUpDown.Items.Add("Relax");
            this.plansUpDown.Items.Add("Doctor");
            this.plansUpDown.Items.Add("Dentist");
            this.plansUpDown.Items.Add("Other");
            this.plansUpDown.Location = new System.Drawing.Point(596, 109);
            this.plansUpDown.Name = "plansUpDown";
            this.plansUpDown.Size = new System.Drawing.Size(120, 22);
            this.plansUpDown.TabIndex = 23;
            this.plansUpDown.Text = "School";
            this.plansUpDown.SelectedItemChanged += new System.EventHandler(this.plansUpDown_SelectedItemChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(461, 428);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(685, 393);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 27;
            this.listBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plansUpDown);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.bDayInfo);
            this.Controls.Add(this.holidayInfo);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.minuteNum);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.weatherUpDown);
            this.Controls.Add(this.hourNum);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.bDayCheckBox);
            this.Controls.Add(this.holidayCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox holidayCheckBox;
        private System.Windows.Forms.CheckBox bDayCheckBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.NumericUpDown hourNum;
        private System.Windows.Forms.DomainUpDown weatherUpDown;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.NumericUpDown minuteNum;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox holidayInfo;
        private System.Windows.Forms.TextBox bDayInfo;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown plansUpDown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

