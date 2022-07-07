using System;
using System.Web.UI;

namespace ritg_hodarevd
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            sqlDataSource.Insert();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlDataSource.Update();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            sqlDataSource.Delete();
        }
    }
}