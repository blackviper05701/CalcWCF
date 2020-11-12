using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculatorClient.CalculatorServiceReference;

namespace CalculatorClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CalcutorServiceClient c = new CalcutorServiceClient("BasicHttpBinding_ICalcutorService1");
            int[] numbers = new int[] { 1, 3, 4, 9 };
            double result = c.Add(numbers);
            Label1.Text = result.ToString();
        }
    }
}