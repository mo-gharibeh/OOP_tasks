using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forms
{
    public partial class Calculator : System.Web.UI.Page
    {
        double num1;
        double num2;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(TextBox1.Text);  
            num2 = Convert.ToInt32(TextBox2.Text);

            double sum = num2 + num1;

            Label1.Text = $"Result = {sum}";

        }
    

        protected void Button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);

            double mns = num1 - num2;

            Label1.Text = $"Result = {mns}";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);

            double mult = num2 * num1;

            Label1.Text = $"Result = {mult}";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);
           
                double dev = num1 / num2;
                Label1.Text = $"Result = {dev}";        
        }
    }
}