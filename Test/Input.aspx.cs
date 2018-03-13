using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftwareQualityAndTesting;

namespace Test
{
    public partial class Input : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CalcPremiumClass c1 = new CalcPremiumClass();
            int age = int.Parse(txtAge.Text);
            string gender = txtGender.Text;

            DisplayAge.Text += age.ToString();
            DisplayGender.Text += gender;
            DisplayPremium.Text += "€" + c1.CalcPremium(age, gender).ToString();
        }
    }
}