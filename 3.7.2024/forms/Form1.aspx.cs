using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forms
{
    public partial class Form1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblDisplayName.Text = $"Name: {txtName.Text} ";
            
            lblDisplayEmail.Text= $"Email: {txtEmail.Text} ";
            
            lblDisplayID.Text= $"ID: {txtID.Text} ";

            if (rblMale.Checked)
            {
                lblDisplayGender.Text = $"Gender: Male ";
            }else if (rblFemale.Checked)
            {
                lblDisplayGender.Text = $"Gender: Female ";
            }
            string lan = "Languages: ";
            if (chkC.Checked)
            {
                lan += "  C /";
            }
            if (chkCSharp.Checked)
            {
                lan += " C# /";
            }
            if (chkCpp.Checked)
            {
                lan += " C++";
            }
            //else
            //{
            //    lan += "\b";
            //}
            lblDisplayLanguages.Text= lan;
            
            lblDisplayAdditionalInfo.Text= $"Additional Information:  {txtAdditionalInfo.Text} ";

        }
    }
}