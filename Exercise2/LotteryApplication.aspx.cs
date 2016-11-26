using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LotteryApplication : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnDrawNumbers_Click(object sender, EventArgs e)
    {
        BCLottery lottery = new BCLottery();
        try
        {
            int numbersToDraw = (ddlLotteryType.Text == "Lottery") ? 7 : 6;
            int maxValue = (ddlLotteryType.Text == "Lottery") ? 39 : 48;

            if (int.Parse(txtNumbersToDraw.Text) > 0)
            {
                for (int i = 0; i < int.Parse(txtNumbersToDraw.Text); i++)
                {
                    lbDrawnNumbers.Text += string.Join(", ", lottery.DrawLoteryRows(numbersToDraw, maxValue)) + "<br /><br />";
                }
            }
            else
            {
                lbDrawnNumbers.Text = "Et voi syöttää 0 riviä!";
            }
        }
        catch (Exception ex) // if something is not right, like the textbox is empty
        {
            lbDrawnNumbers.Text = ex.Message;
        }
        
    }
}
