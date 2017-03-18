using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_Lab4
{
    public partial class MultiView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mwReg.ActiveViewIndex = 0;
        }

        protected void v1D_Click(object sender, EventArgs e)
        {
            mwReg.ActiveViewIndex = 1;
        }

        protected void v2L_Click(object sender, EventArgs e)
        {
            mwReg.ActiveViewIndex = 0;
        }

        protected void v2D_Click(object sender, EventArgs e)
        {
            mwReg.ActiveViewIndex = 2;
        }

        protected void v3L_Click(object sender, EventArgs e)
        {
            mwReg.ActiveViewIndex = 1;
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            lbl.Text = fid.Text + "@finki.ukim.mk";
            mwReg.ActiveViewIndex = 3;
        }

        protected void start_Click(object sender, EventArgs e)
        {
            /*ime.Text = "";
            prezime.Text = "";
            fid.Text = "";
            adr.Text = "";*/
            adr.Text = tel.Text = fid.Text = prezime.Text = ime.Text = iskustvo.Text = "";
            DropDownList1.SelectedIndex = 0;
            RadioButtonList1.SelectedIndex = -1;
            mwReg.ActiveViewIndex = 0;
        }



        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            mwReg.ActiveViewIndex = 1;           
        }
    }
}