using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;

namespace Server
{
    public partial class adminView : Form
    {
        public adminView()
        {
            InitializeComponent();
        }

        private void BTN_search_Click(object sender, EventArgs e)
        {
            short result;
           
            if(TXTBOX_search.Text!="" || TXTBOX_search.Text!="Enter ID")
            {
                if (RBTN_user.Checked)
                { 
                    getUserResults(int.Parse(TXTBOX_search.Text)); 
                }
                else if (RBTN_event.Checked)
                {
                    getEventResults(int.Parse(TXTBOX_search.Text));
                }
            }
        }
    }
}
