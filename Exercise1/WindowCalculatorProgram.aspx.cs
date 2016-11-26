using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WindowCalculatorProgram : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculateWindow_Click(object sender, EventArgs e)
    {
        // meters to millimeters
        //can cause problems if used with very small windows
        float width = float.Parse(txtWidth.Text) / 1000;
        float height = float.Parse(txtHeight.Text) / 1000;
        float border = float.Parse(txtBorderWidth.Text) / 1000;

        txtArea.Text = CalculateArea(width, height, border).ToString();
        txtCirc.Text = CalculateBorderCircle(width, height).ToString();
        txtPrice.Text = CalculateJobPrice(width, height, border).ToString();
    }

    // calculate window area
    private float CalculateArea(float width, float height, float border)
    {
        return width * height;
    }

    // calculate border circle
    private float CalculateBorderCircle(float width, float height)
    {
        return width * 2 + height * 2;
    }

    // calculate total job price
    private float CalculateJobPrice(float width, float height, float border)
    {
        // get data from AppSettings in Web.config
        float squarePrice = float.Parse(ConfigurationManager.AppSettings["squarePrice"]);
        float alunimiumPrice = float.Parse(ConfigurationManager.AppSettings["aluminiumPrice"]);
        float jobPrice = float.Parse(ConfigurationManager.AppSettings["jobPrice"]);
        float balance = float.Parse(ConfigurationManager.AppSettings["balance"]);

        float windowPrice = CalculateArea(width, height, border) * squarePrice;
        float borderPrice = CalculateBorderCircle(width, height) * alunimiumPrice;

        return (1 + balance) * (windowPrice + borderPrice + jobPrice);
    }
}