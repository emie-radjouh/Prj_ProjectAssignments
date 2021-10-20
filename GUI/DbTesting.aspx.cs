using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prj_PracticeMidterm.DAL;
using System.Windows.Forms;

namespace Prj_PracticeMidterm.GUI
{
    
    public partial class DbTesting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConnectDb_Click(object sender, EventArgs e)
        {
            //To test the database connection
            MessageBox.Show("Database Connect : " + UtilityDB.ConnectDB().State.ToString());

        }
    }
}