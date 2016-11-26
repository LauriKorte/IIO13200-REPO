using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CalendarApplication : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime currentDate = DateTime.Today;
        lbCurrentDate.Text = currentDate.ToString("dd.MM.yyyy");

        if (!IsPostBack)
        {
            calendarDate.VisibleDate = DateTime.Today;
        }
    }

    protected void btnPrevious_Click(object sender, EventArgs e) // previous year
    {
        calendarDate.VisibleDate = calendarDate.VisibleDate.AddYears(-1);
    }

    protected void btnNext_Click(object sender, EventArgs e) // next year
    {
        calendarDate.VisibleDate = calendarDate.VisibleDate.AddYears(1);
    }

    protected void calendarDate_SelectionChanged(object sender, EventArgs e) // do the maths
    {
        lbSelectedDate.Text = calendarDate.SelectedDate.ToString("dd.MM.yyyy");

        TimeSpan ts = DateTime.Today - calendarDate.SelectedDate;
        DateTime difference = DateTime.MinValue + ts;
        lbDifference.Text = (difference.Year - 1).ToString() + " vuotta, " + (difference.Month - 1).ToString() + " kuukautta, " + (difference.Day - 1).ToString() + " päivää.";
    }
}