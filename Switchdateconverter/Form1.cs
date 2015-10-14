using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switchdateconverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_MouseClick(object sender, MouseEventArgs e)
        {
            
            int day = Convert.ToInt16(txtDaynum.Text);
            int month = Convert.ToInt16(txtMonthnum.Text);
            int year = Convert.ToInt16(txtYearNum.Text);

            switch (day)
            {
                case 1: txtDayformatted.Text = day.ToString() +"st";
                    break;
                case 2: txtDayformatted.Text = day.ToString() + "nd";
                    break;
                case 3: txtDayformatted.Text = day.ToString() + "rd";
                    break;
                case 21: txtDayformatted.Text = day.ToString() + "st";
                    break;
                case 22: txtDayformatted.Text = day.ToString() + "nd";
                    break;
                case 23: txtDayformatted.Text = day.ToString() + "rd";
                    break;
                case 31: txtDayformatted.Text = day.ToString() + "st";
                    break;
                default: txtDayformatted.Text = day.ToString() + "th";
                    break;
            }
            switch(month)
            {
                case 1: txtMonthformatted.Text = "January";
                    break;
                case 2: txtMonthformatted.Text = "February";
                    break;
                case 3: txtMonthformatted.Text = "March";
                    break;
                case 4: txtMonthformatted.Text = "April";
                    break;
                case 5: txtMonthformatted.Text = "May";
                    break;
                case 6: txtMonthformatted.Text = "June";
                    break;
                case 7: txtMonthformatted.Text = "July";
                    break;
                case 8: txtMonthformatted.Text = "August";
                    break;
                case 9: txtMonthformatted.Text = "September";
                    break;
                case 10: txtMonthformatted.Text = "October";
                    break;
                case 11: txtMonthformatted.Text = "November";
                    break;
                case 12: txtMonthformatted.Text = "December";
                    break;
            }
            if(year > 80)
            {
                txtYearFormatted.Text = "19" + year.ToString();
            }
            else
            {
                txtYearFormatted.Text = "20" + year.ToString();
            }
        }
    }
}
