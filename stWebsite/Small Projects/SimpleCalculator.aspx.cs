using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Small_Projects_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void add_BTN_Click(object sender, EventArgs e)
    {
        if (firstNumber_TB.Text.Length == 0 || secondNumber_TB.Text.Length == 0)
        {
            errorLabel.Text = "Please enter a numeric value in each text box";
        }
        else
        {
            int valueOne = int.Parse(firstNumber_TB.Text);
            int valueTwo = int.Parse(secondNumber_TB.Text);

            answer.Text = "Answer:" + (valueOne + valueTwo);
        }
    }

    protected void subtract_BTN_Click(object sender, EventArgs e)
    {
        if (firstNumber_TB.Text.Length == 0 || secondNumber_TB.Text.Length == 0)
        {
            errorLabel.Text = "Please enter a numeric value in each text box";
        }
        else
        {
            int valueOne = int.Parse(firstNumber_TB.Text);
            int valueTwo = int.Parse(secondNumber_TB.Text);

            answer.Text = "Answer:" + (valueOne - valueTwo);
        }
    }

    protected void multiply_BTN_Click(object sender, EventArgs e)
    {
        if (firstNumber_TB.Text.Length == 0 || secondNumber_TB.Text.Length == 0)
        {
            errorLabel.Text = "Please enter a numeric value in each text box";
        }
        else
        {
            int valueOne = int.Parse(firstNumber_TB.Text);
            int valueTwo = int.Parse(secondNumber_TB.Text);

            answer.Text = "Answer:" + (valueOne * valueTwo);
        }
    }

    protected void division_BTN_Click(object sender, EventArgs e)
    {
        if (firstNumber_TB.Text.Length == 0 || secondNumber_TB.Text.Length == 0)
        {
            errorLabel.Text = "Please enter a numeric value in each text box";
        }
        else
        {
            int valueOne = int.Parse(firstNumber_TB.Text);
            int valueTwo = int.Parse(secondNumber_TB.Text);

            answer.Text = "Answer:" + (valueOne / valueTwo);
        }
    }
}