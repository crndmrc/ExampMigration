using ExampMigration.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExampMigration
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true) return;
        }

        protected void btnCreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                EF _eF = new EF();
                _eF.Database.Create();
                lblInfo.Text = "succesfull";
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
        }
    }
}